using CommercialSystem.Shared.DTOs;
using System.Net.Http.Json;

namespace CommercialSystem.Client.Services
{
    public class SalesService
    {
        private readonly HttpClient _httpClient;

        public SalesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Sale>> GetSalesAsync()
        {
            var sales = await _httpClient.GetFromJsonAsync<List<Sale>>("api/sale");
            return sales ?? new List<Sale>();
        }

        public async Task<Sale> AddSaleAsync(Sale sale)
        {
            var response = await _httpClient.PostAsJsonAsync("api/sale", sale);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<Sale>() ?? new Sale();
            else
                throw new Exception($"Erro ao adicionar a venda: {response.ReasonPhrase}");
        }

        public async Task<Sale> AlterSaleAsync(Sale sale)
        {
            var response = await _httpClient.PutAsJsonAsync("api/sale", sale);
            return await response.Content.ReadFromJsonAsync<Sale>() ?? new Sale();
        }

        public async Task<SaleItem> AddSaleItemAsync(SaleItem saleItem)
        {
            var response = await _httpClient.PostAsJsonAsync("api/sale/item", saleItem);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<SaleItem>() ?? new SaleItem();
            else
                throw new Exception($"Erro ao adicionar a venda: {response.ReasonPhrase}");
        }
    }
}
