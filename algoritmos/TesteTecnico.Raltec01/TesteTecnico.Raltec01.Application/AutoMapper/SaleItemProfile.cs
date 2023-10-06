using AutoMapper;
using TesteTecnico.Raltec01.Application.ViewModels;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Application.AutoMapper
{
	public class SaleItemProfile : Profile
	{
		public SaleItemProfile()
		{
			CreateMap<SaleItem, SaleItemViewModel>()
				.ForSourceMember(saleItem => saleItem.Product, options => options.DoNotValidate())
				.ForSourceMember(saleItem => saleItem.Sale, options => options.DoNotValidate())
				.ReverseMap()
				.ForMember(saleViewModel => saleViewModel.Product, options => options.Ignore())
				.ForMember(saleViewModel => saleViewModel.Sale, options => options.Ignore());
		}
	}
}
