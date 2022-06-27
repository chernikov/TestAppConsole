using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public interface ICollector
    {
        string Total { get; }
        string Add(string str);
    }
}
