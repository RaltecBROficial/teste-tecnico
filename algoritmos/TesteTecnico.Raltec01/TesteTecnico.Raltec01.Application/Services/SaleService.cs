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
		private readonly ISaleRepository _saleRepository;

		public SaleService(IMapper mapper, ISaleRepository saleRepository)
		{
			_mapper = mapper;
			_saleRepository = saleRepository;
		}

		public async Task<SaleViewModel> GetByIdAsync(Guid id)
		{
			return _mapper.Map<SaleViewModel>(await _saleRepository.GetByIdAsync(id));
		}

		public async Task<IEnumerable<SaleViewModel>> GetAllAsync()
		{
			return _mapper.Map<IEnumerable<SaleViewModel>>(await _saleRepository.GetAllAsync());
		}

		public Task AddAsync(SaleViewModel entity)
		{
			return _saleRepository.AddAsync(_mapper.Map<Sale>(entity));
		}

		public Task UpdateAsync(SaleViewModel entity)
		{
			return _saleRepository.UpdateAsync(_mapper.Map<Sale>(entity));
		}

		public Task RemoveAsync(SaleViewModel entity)
		{
			return _saleRepository.RemoveAsync(_mapper.Map<Sale>(entity));
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
