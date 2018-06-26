using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace TibiaCharInfo.Services
{
    public class ServiceBase
    {
        protected HttpClient _httpClient;

        public string BaseAddress => @"https://api.tibiadata.com/v2/";

        public ServiceBase()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(this.BaseAddress)
            };            
        }

        public async Task<string> GetResponse(string uri)
        {
            var response = await _httpClient.GetAsync(uri);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
