using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    
    public class RestServices : RestServiceBase, IRestServices
    {
        public async Task<List<MenuDTO>> GetMenuItems()
        {
            return await GetResultFromRestApi<List<MenuDTO>>("api/MenuApi/GetMenu");
        }

        public async Task<ConfigDTO> GetConfig()
        {
            return await GetResultFromRestApi<ConfigDTO>("api/NativeConfig/GetConfig");
        }
      
    }
}
