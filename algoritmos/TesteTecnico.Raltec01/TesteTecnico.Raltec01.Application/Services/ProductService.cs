using AutoMapper;
using TesteTecnico.Raltec01.Application.Interfaces;
using TesteTecnico.Raltec01.Application.ViewModels;
using TesteTecnico.Raltec01.Domain.Entities;
using TesteTecnico.Raltec01.Domain.Repositories;

namespace TesteTecnico.Raltec01.Application.Services
{
	public class ProductService : IProductService
	{
		private readonly IMapper _mapper;
		private readonly IUnitOfWork _unitOfWork;

		public ProductService(IMapper mapper, IUnitOfWork unitOfWork)
		{
			_mapper = mapper;
			_unitOfWork = unitOfWork;
		}

		public async Task<ProductViewModel> GetByIdAsync(Guid id)
		{
			return _mapper.Map<ProductViewModel>(await _unitOfWork.ProductRepository.GetByIdAsync(id));
		}

		public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
		{
			return _mapper.Map<IEnumerable<ProductViewModel>>(await _unitOfWork.ProductRepository.GetAllAsync());
		}

		public async Task AddAsync(ProductViewModel entity)
		{
			entity.Id = Guid.NewGuid();
			await _unitOfWork.ProductRepository.AddAsync(_mapper.Map<Product>(entity));
			await _unitOfWork.SaveAsync();
		}

		public async Task UpdateAsync(ProductViewModel entity)
		{
			await _unitOfWork.ProductRepository.UpdateAsync(_mapper.Map<Product>(entity));
			await _unitOfWork.SaveAsync();
		}

		public async Task RemoveAsync(ProductViewModel entity)
		{
			await _unitOfWork.ProductRepository.RemoveAsync(_mapper.Map<Product>(entity));
			await _unitOfWork.SaveAsync();
		}

		public void Dispose()
		{
			_unitOfWork.DisposeAsync();
			GC.SuppressFinalize(this);
		}
	}
}
