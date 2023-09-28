using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;

namespace CommercialSystem.Server.Mappings
{
    public static class ProductMapping
    {
        public static IEnumerable<Product> ConvertToDto(this IEnumerable<PRD_PRODUCT> lstPrdProduct)
        {
            return (from prdProduct in lstPrdProduct
                    select new Product
                    {
                        Id = prdProduct.Id,
                        Name = prdProduct.Name,
                        UnitPrice = prdProduct.PriceUnit.ToString()
                    }).ToList();
        }

        public static Product ConvertToDto(this PRD_PRODUCT prdProduct)
        {
            return new Product
            {
                Id = prdProduct.Id,
                Name = prdProduct.Name,
                UnitPrice = prdProduct.PriceUnit.ToString(),
            };
        }
    }
}
