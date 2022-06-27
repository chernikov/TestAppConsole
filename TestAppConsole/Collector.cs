using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class Collector : ICollector
    {
        public string Total { get; set; }

        public string Add(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("Parameter shoun't be null");
            }
            Total += str;
            return Total;
        }
    }
}
