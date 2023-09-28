using CommercialSystem.Shared.Entitys;
using CommercialSystem.Shared.DTOs;

namespace CommercialSystem.Server.Mappings
{
    public static class SaleMapping
    {
        public static IEnumerable<Sale> ConvertToDto(this IEnumerable<SL_SALE> lstSlSale)
        {
            return (from slSale in lstSlSale
                    select new Sale
                    {
                        Id = slSale.Id,
                        VlrAmount = slSale.VlrAmount,
                        SaleDate = slSale.DateSale,
                        lstProductInform = slSale.GetLstProductInform()
                    }).ToList();
        }

        public static Sale ConvertToDto(this SL_SALE slSale)
        {
            return new Sale
            {
                Id = slSale.Id,
                VlrAmount = slSale.VlrAmount,
                SaleDate = slSale.DateSale,
                lstProductInform = slSale.GetLstProductInform()
            };
        }

        public static List<string> GetLstProductInform(this SL_SALE slSale)
        {
            return (from sliSaleItem in slSale.SaleItems
                    select $"{sliSaleItem.QtdProduct}x {sliSaleItem.Product?.Name}").ToList();
        }
    }
}
