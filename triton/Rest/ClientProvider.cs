using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    public class ClientProvider : IClientProvider
    {
        private static HttpClient client { get; set; }

        public ClientProvider()
        {
            var handler = new HttpClientHandler()
            {
                AllowAutoRedirect = true,
                MaxAutomaticRedirections = 100,
                CookieContainer = new CookieContainer()
            };

            Client = new HttpClient(handler)
            {
                BaseAddress = new Uri("http://10.220.124.100:90")
            };
        }

        public bool IsAuthorized { get; set; }
        public HttpClient Client
        {
            get
            {
                return client;
            }
            set
            {
                client = value;
            }
        }

        public async Task<bool> Authorize()
        {
            var autorized = await Client.GetAsync(new Uri("/account/auth"));
            IsAuthorized = autorized.IsSuccessStatusCode;
            return IsAuthorized;
        }

    }
}
