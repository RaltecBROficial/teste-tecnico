using Microsoft.EntityFrameworkCore;
using CommercialSystem.Server.Data;
using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;
using CommercialSystem.Server.Mappings;
using System.Collections.ObjectModel;

namespace CommercialSystem.Server.Repositories
{
    public class SaleRepository
    {
        private readonly AppDbContext _context;
        private readonly ProductRepository _productRepository;

        public SaleRepository(AppDbContext context, ProductRepository productRepository)
        {
            _context = context;
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<SL_SALE>> GetAllSalesAsync()
        {
            return await _context.SL_SALE.Include(s => s.SaleItems).ThenInclude(si => si.Product).ToListAsync();
        }

        public async Task<SL_SALE> PostSaleAsync(SL_SALE slSale)
        {
            var newSale = await _context.SL_SALE.AddAsync(slSale);
            await _context.SaveChangesAsync();

            return newSale.Entity;
        }

        public async Task<SL_SALE> PutSaleAsync(SL_SALE slSale)
        {
            var saleEntity = await _context.SL_SALE.FindAsync(slSale.Id);

            if(saleEntity is not null)
            {
                saleEntity.DateSale = DateTime.Now;
                saleEntity.VlrAmount = slSale.VlrAmount;
                await _context.SaveChangesAsync();

                var saleItems = await _context.SLI_SALEITEM
                    .Where(si => si.SaleId == saleEntity.Id)
                    .Include(si => si.Product)
                    .ToListAsync();

                saleEntity.SaleItems = new Collection<SLI_SALEITEM>(saleItems);

                return saleEntity;
            }
            else
            {
                throw new Exception("Ococreu um erro inesperado!");
            }
        }

        public async Task<SLI_SALEITEM> PostSaleItemAsync(SLI_SALEITEM sliSaleItem)
        {
            PRD_PRODUCT prdProduct = await _productRepository.GetProductById(sliSaleItem.ProductId);

            sliSaleItem.VlrSubtotal = sliSaleItem.CalculateDiscountedPrice(prdProduct.PriceUnit);

            var newSale = await _context.SLI_SALEITEM.AddAsync(sliSaleItem);
            await _context.SaveChangesAsync();

            newSale.Entity.Product = prdProduct;

            return newSale.Entity;
        }
    }
}
