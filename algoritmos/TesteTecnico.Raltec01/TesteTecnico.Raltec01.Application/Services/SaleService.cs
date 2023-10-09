using AutoMapper;
using TesteTecnico.Raltec01.Application.Interfaces;
using TesteTecnico.Raltec01.Application.ViewModels;
using TesteTecnico.Raltec01.Domain.Entities;
using TesteTecnico.Raltec01.Domain.Repositories;

namespace TesteTecnico.Raltec01.Application.Services
{
	public class SaleService : ISaleService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public SaleService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task<SaleViewModel> GetByIdAsync(Guid id)
		{
			return _mapper.Map<SaleViewModel>(await _unitOfWork.SaleRepository.GetByIdAsync(id));
		}

		public async Task<IEnumerable<SaleViewModel>> GetAllAsync()
		{
			return _mapper.Map<IEnumerable<SaleViewModel>>(await _unitOfWork.SaleRepository.GetAllAsync());
		}

		public async Task AddAsync(SaleViewModel entity)
		{
			CalculateSaleValue(entity);
			var sale = _mapper.Map<Sale>(entity);

			foreach (var item in sale.Items)
			{
				item.SaleId = sale.Id;
			}

			await _unitOfWork.SaleRepository.AddAsync(sale);
			await _unitOfWork.SaveAsync();
		}

		public Task UpdateAsync(SaleViewModel entity)
		{
			return _unitOfWork.SaleRepository.UpdateAsync(_mapper.Map<Sale>(entity));
		}

		public Task RemoveAsync(SaleViewModel entity)
		{
			return _unitOfWork.SaleRepository.RemoveAsync(_mapper.Map<Sale>(entity));
		}

		public void Dispose()
		{
			_unitOfWork.DisposeAsync();
			GC.SuppressFinalize(this);
		}

		private void CalculateSaleValue(SaleViewModel sale)
		{
			decimal discount;

			foreach (var itemSale in sale.Items)
			{
				if (itemSale.Quantity > 30)
				{
					discount = 20;
				}
				else if (itemSale.Quantity > 20)
				{
					discount = 10;
				}
				else
				{
					discount = 5;
				}

				var product = _unitOfWork.ProductRepository.GetByIdAsync(itemSale.ProductId);

				itemSale.Value = product.Result.UnitValue * itemSale.Quantity;
				decimal discountPrice = itemSale.Value * (discount / 100);

				itemSale.Value -= discountPrice;
			}
		}
	}
}
