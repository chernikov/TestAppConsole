using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionItems
{
    public class Collector
    {
        public string Total { get; set; }

        public string Add(string str)
        {
            Total += str;

            return Total;
        }
    }
}
