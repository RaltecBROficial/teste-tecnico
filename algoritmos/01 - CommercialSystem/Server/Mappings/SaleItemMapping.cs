using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;

namespace CommercialSystem.Server.Mappings
{
    public static class SaleItemMapping
    {
        public static IEnumerable<SaleItem> ConvertToDto(this IEnumerable<SLI_SALEITEM> lstSliSaleItem)
        {
            return (from sliSaleItem in lstSliSaleItem
                    select new SaleItem
                    {
                        Id = sliSaleItem.Id,
                        SaleId = sliSaleItem.SaleId,
                        ProductId = sliSaleItem.ProductId,
                        ProductName = sliSaleItem.Product?.Name ?? string.Empty,
                        ProductVlrUnit = sliSaleItem.Product?.PriceUnit.ToString() ?? string.Empty,
                        QtdProduct = sliSaleItem.QtdProduct.ToString(),
                        Subtotal = sliSaleItem.VlrSubtotal
                    }).ToList();
        }

        public static SaleItem ConvertToDto(this SLI_SALEITEM sliSaleItem)
        {
            return new SaleItem
            {
                Id = sliSaleItem.Id,
                SaleId = sliSaleItem.SaleId,
                ProductId = sliSaleItem.ProductId,
                ProductName = sliSaleItem.Product?.Name ?? string.Empty,
                ProductVlrUnit = sliSaleItem.Product?.PriceUnit.ToString() ?? string.Empty,
                QtdProduct = sliSaleItem.QtdProduct.ToString(),
                Subtotal = sliSaleItem.VlrSubtotal
            };
        }

        public static decimal CalculateDiscountedPrice(this SLI_SALEITEM saleItem, decimal priceUnit)
        {
            if (saleItem is not null)
            {
                if (saleItem.QtdProduct >= 10 && saleItem.QtdProduct < 20)
                {
                    return (priceUnit * saleItem.QtdProduct) * 0.95m; // 5% de desconto
                }
                else if (saleItem.QtdProduct >= 20 && saleItem.QtdProduct < 30)
                {
                    return (priceUnit * saleItem.QtdProduct) * 0.90m; // 10% de desconto
                }
                else if (saleItem.QtdProduct >= 30)
                {
                    return (priceUnit * saleItem.QtdProduct) * 0.80m; // 20% de desconto
                }
                else
                {
                    return (priceUnit * saleItem.QtdProduct); // 0% de desconto
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
