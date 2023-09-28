using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CommercialSystem.Server.Data;
using System;
using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;

namespace CommercialSystem.Server.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _dbcontext;

        public ProductRepository(AppDbContext context)
        {
            _dbcontext = context;
        }

        public async Task<IEnumerable<PRD_PRODUCT>> GetAllProductsAsync()
        {
            return await _dbcontext.PRD_PRODUCT.ToListAsync();
        }

        public async Task<PRD_PRODUCT> GetProductById(int productId)
        {
            return await _dbcontext.PRD_PRODUCT.FindAsync(productId) ?? new PRD_PRODUCT();
        }

        public async Task<PRD_PRODUCT> AddProductAsync(PRD_PRODUCT prdProduct)
        {
            var newProduct = await _dbcontext.PRD_PRODUCT.AddAsync(prdProduct);
            await _dbcontext.SaveChangesAsync();
            return newProduct.Entity;
        }

        public async Task<PRD_PRODUCT?> RemoveProductAsync(int productId)
        {
            PRD_PRODUCT? prdProduct = await _dbcontext.PRD_PRODUCT.FindAsync(productId);

            if(prdProduct is not null)
            {
                _dbcontext.Remove(prdProduct);
                await _dbcontext.SaveChangesAsync();
            }

            return prdProduct;
        }
    }
}
