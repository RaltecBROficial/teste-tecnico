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
		private readonly IProductRepository _productRepository;

		public ProductService(IMapper mapper, IProductRepository productRepository)
		{
			_mapper = mapper;
			_productRepository = productRepository;
		}

		public async Task<ProductViewModel> GetByIdAsync(Guid id)
		{
			return _mapper.Map<ProductViewModel>(await _productRepository.GetByIdAsync(id));
		}

		public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
		{
			return _mapper.Map<IEnumerable<ProductViewModel>>(await _productRepository.GetAllAsync());
		}

		public Task AddAsync(ProductViewModel entity)
		{
			return _productRepository.AddAsync(_mapper.Map<Product>(entity));
		}

		public Task UpdateAsync(ProductViewModel entity)
		{
			return _productRepository.UpdateAsync(_mapper.Map<Product>(entity));
		}

		public Task RemoveAsync(ProductViewModel entity)
		{
			return _productRepository.RemoveAsync(_mapper.Map<Product>(entity));
		}

		public void Dispose()
		{
			GC.SuppressFinalize(this);
		}
	}
}
