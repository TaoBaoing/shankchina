using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 爬虫
{
    public class Config
    {
        public Config()
        {
            ConfigWebs = new List<ConfigWeb>();
        }
        public string SaveFilePath { get; set; }

        public List<ConfigWeb> ConfigWebs { get; set; }
    }

    public class ConfigWeb
    {
        public string WebName { get; set; }
        public string WebUrl { get; set; }
        public int Days { get; set; }
        public string TxtName { get; set; }
    }
}
