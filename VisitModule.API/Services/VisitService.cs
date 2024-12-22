using System.Net.Http.Json;
using VisitModule.Domain.Models;

namespace VisitModule.UI.Services
{
    public class VisitService
    {
        private readonly HttpClient _httpClient;

        public VisitService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Visit>> GetVisitsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Visit>>("visits") ?? new List<Visit>();
        }

        public async Task<Visit?> GetVisitByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Visit>($"visits/{id}");
        }

        public async Task<bool> AddVisitAsync(Visit visit)
        {
            var response = await _httpClient.PostAsJsonAsync("visits", visit);
            return response.IsSuccessStatusCode;
        }
    }
}
