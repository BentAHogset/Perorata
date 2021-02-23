using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    
    public class RestServices 
    {
        private HttpClient _client;

        public RestServices()
        {
            _client = new HttpClient();
        }

        public async Task<ConfigDTO> GetConfig()
        {
            var uriConfig = "http://10.220.124.79:90/api/NativeConfig/GetConfig";
            HttpResponseMessage response = await _client.GetAsync(uriConfig);
            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();
                var items = JsonConvert.DeserializeObject<ConfigDTO>(content);
                return items;
            }
            return null;
        }


    }
}
