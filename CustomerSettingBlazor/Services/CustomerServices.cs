using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerSettingBlazor.Entities;
using System.Net.Http;
using System.Net.Http.Json;

namespace CustomerSettingBlazor.Services
{
    public class CustomerServices : ICustomerServices
    {
        public HttpClient _httpClient;

        public CustomerServices(HttpClient httpClient) 
        { 
            _httpClient = httpClient; 
        }

        public async Task<List<CustomerSettingModel>> getAll()
        {
            var result = await _httpClient.GetFromJsonAsync<List<CustomerSettingModel>>("/api/CustomerSetting");
            return result;
        }
    }
}
