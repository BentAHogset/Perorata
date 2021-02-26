using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    public class RestServiceBase
    {
        private readonly IClientProvider _clientProvider;

        public RestServiceBase(IClientProvider clientProvider)
        {
            _clientProvider = clientProvider;
        }

        public async Task<bool> IsAuthorized()
        {
            if(!_clientProvider.IsAuthorized)
            {
                return await _clientProvider.Authorize();
                
            }
            return _clientProvider.IsAuthorized;
        }

        

        public async Task<T> GetResultFromRestApi<T>(string api)
        {
            var response = await _clientProvider.Client.GetAsync(api);
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


        public T GetMockedMenuData<T>()
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
    }
}