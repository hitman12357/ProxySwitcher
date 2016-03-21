using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic
{
    public class LoadSettings
    {
        public static string ProxyListPath { get; set; }

        public static string[] LoadProxyList()
        {
            ProxyListPath = "proxylist.conf";
            string[] lines;

            lines = System.IO.File.ReadAllLines(ProxyListPath);

            return lines;
        }

        
    }
}
