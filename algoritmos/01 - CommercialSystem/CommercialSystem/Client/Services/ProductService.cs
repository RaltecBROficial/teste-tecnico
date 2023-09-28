using System.Net.Http.Json;
using CommercialSystem.Shared.DTOs;

namespace CommercialSystem.Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var products = await _httpClient.GetFromJsonAsync<List<Product>>("api/product");
            return products ?? new List<Product>();
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            var response = await _httpClient.PostAsJsonAsync("api/product", product);

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<Product>() ?? new Product();
            else
                throw new Exception($"Erro ao adicionar o produto: {response.ReasonPhrase}");
        }

        public async Task RemoveProductAsync(int productId)
        {
            await _httpClient.DeleteAsync($"api/product/{productId}");
        }
    }
}
