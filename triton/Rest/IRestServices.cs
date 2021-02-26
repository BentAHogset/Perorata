using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    public interface IRestServices
    {
        Task<bool> IsAuthorized();
        Task<ConfigDTO> GetConfig();
        Task<List<MenuDTO>> GetMenuItems();
        List<MenuDTO> GetMenuItemsMocked();
    }
}
