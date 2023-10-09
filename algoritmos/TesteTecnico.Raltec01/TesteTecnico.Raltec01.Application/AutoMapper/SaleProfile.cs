using AutoMapper;
using TesteTecnico.Raltec01.Application.ViewModels;
using TesteTecnico.Raltec01.Domain.Entities;

namespace TesteTecnico.Raltec01.Application.AutoMapper
{
	public class SaleProfile : Profile
	{
		public SaleProfile()
		{
			CreateMap<Sale, SaleViewModel>()
				.ForMember(sale => sale.Items,
					options => options.MapFrom(src => src.Items));

			CreateMap<SaleViewModel, Sale>()
				.ForMember(sale => sale.Items,
					options => options.MapFrom(src => src.Items));
		}
	}
}
