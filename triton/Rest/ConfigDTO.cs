using System;
using System.Collections.Generic;
using System.Text;

namespace triton.Rest
{
    public class ConfigDTO
    {
        public int Version { get; set; }
        public Dictionary<String, String> CacheList { get; set; }
        public Dictionary<String, String> ConfigList { get; set; }

        //public ConfigDTO()
        //{
        //    CacheList = new Dictionary<String, String>();
        //    ConfigList = new Dictionary<String, String>();
        //}
    }
}
