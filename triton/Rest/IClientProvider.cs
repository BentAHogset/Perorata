using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    public interface IClientProvider
    {
        HttpClient Client { get; set; }
        bool IsAuthorized { get; set; }
        Task<bool> Authorize();
    }
}
