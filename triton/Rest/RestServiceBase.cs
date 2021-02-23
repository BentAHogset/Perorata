using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    public class RestServiceBase
    {
        protected HttpClient client;

        public RestServiceBase()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri("http://10.220.124.79:90")
            };
        }

        public async Task<T> GetMockedMenuData<T>()
        {
            var list = new List<MenuDTO>
            {
                new MenuDTO
                {
                    ActionCount = 2,
                    Icon = "icon--absence",
                    MenuId = "MENU_SYKEFRAVÆR",
                    Name = "Fravær",
                    Url = "/absence/"
                },

                new MenuDTO
                {
                    ActionCount = 1,
                    Icon = "icon--vacation",
                    MenuId = "MENU_FERIE",
                    Name = "Ferie",
                    Url = "/vacation/"
                },

                new MenuDTO
                {
                    ActionCount = 1,
                    Icon = "icon--travel",
                    MenuId = "MENU_REISEREGNIGN",
                    Name = "Reiseregning",
                    Url = "/Expenses/"
                }
            };

            var content = JsonConvert.SerializeObject(list);
            return DeserializeJson<T>(content);
        }

        public async Task<T> GetResultFromRestApi<T>(string api)
        {
            var response = await client.GetAsync(api);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return DeserializeJson<T>(content);
            }
            return DeserializeJson<T>("");
        }

        private T DeserializeJson<T>(string json)
        {
            if (!string.IsNullOrEmpty(json))
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            return JsonConvert.DeserializeObject<T>("");
        }
    }
}