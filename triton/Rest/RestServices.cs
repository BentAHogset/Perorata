using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    
    public class RestServices: RestServiceBase, IRestServices
    {

        public RestServices(IClientProvider clientProvider): base(clientProvider)
        {

        }

        public List<MenuDTO> GetMenuItemsMocked()
        {
            return GetMockedMenuData<List<MenuDTO>>();
        }

        public async Task<List<MenuDTO>> GetMenuItems()
        {
            //NB! API i triton må settes opp med TritonAuth Module/function
            return await GetResultFromRestApi<List<MenuDTO>>("/api/MenuApi/GetMenu");
        }

        public async Task<ConfigDTO> GetConfig()
        {
            return await GetResultFromRestApi<ConfigDTO>("/api/NativeConfig/GetConfig");
        }
      
    }
}
