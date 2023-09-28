using Microsoft.AspNetCore.Mvc;
using CommercialSystem.Server.Repositories;
using CommercialSystem.Shared.DTOs;
using CommercialSystem.Shared.Entitys;
using CommercialSystem.Server.Mappings;

namespace CommercialSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly SaleRepository _saleRepository;

        public SaleController(SaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sale>>> GetAllSales()
        {
            IEnumerable<SL_SALE> slSales = await _saleRepository.GetAllSalesAsync();

            if(slSales is null)
                return NotFound();

            return Ok(slSales.ConvertToDto());
        }

        [HttpPost]
        public async Task<ActionResult<Sale>> PostSale([FromBody] Sale sale)
        {
            var newSale = await _saleRepository.PostSaleAsync(new SL_SALE
            {
                VlrAmount = sale.VlrAmount,
                DateSale = DateTime.Now
            });

            return Ok(newSale.ConvertToDto());
        }

        [HttpPut]
        public async Task<ActionResult<Sale>> PutSale([FromBody] Sale sale)
        {
            var newSale = await _saleRepository.PutSaleAsync(new SL_SALE
            {
                Id = sale.Id,
                VlrAmount = sale.VlrAmount,
                DateSale = DateTime.Now
            });

            return Ok(newSale.ConvertToDto());
        }

        [HttpPost]
        [Route("item")]
        public async Task<ActionResult<SaleItem>> PostSaleItem([FromBody] SaleItem saleItem)
        {
            var newSaleItem = await _saleRepository.PostSaleItemAsync(new SLI_SALEITEM
            {
                SaleId = saleItem.SaleId,
                ProductId = saleItem.ProductId,
                QtdProduct = Convert.ToInt32(saleItem.QtdProduct)
            });

            return Ok(newSaleItem.ConvertToDto());
        }
    }
}
