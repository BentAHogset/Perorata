using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace triton.Rest
{
    public interface IRestServices
    {
        Task<ConfigDTO> GetConfig();
        Task<List<MenuDTO>> GetMenuItems();
    }
}
