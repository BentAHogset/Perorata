using System;
using System.Collections.Generic;
using System.Text;

namespace triton.Rest
{
    public class MenuDTO
    {
        public string MenuId { get; set; }
        
        public string Name { get; set; }
        
        public string Url { get; set; }
        
        public string Icon { get; set; }
        
        public int ActionCount { get; set; }
    }
}
