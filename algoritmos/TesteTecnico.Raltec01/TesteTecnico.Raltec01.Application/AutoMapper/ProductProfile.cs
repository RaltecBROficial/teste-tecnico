using AutoMapper;
using TesteTecnico.Raltec01.Application.ViewModels;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Application.AutoMapper
{
	public class ProductProfile : Profile
	{
		public ProductProfile()
		{
			CreateMap<Product, ProductViewModel>().ReverseMap();
		}
	}
}
