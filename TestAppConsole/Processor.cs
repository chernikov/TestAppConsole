using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class Processor
    {
        private ICollector collector;


        public Processor(ICollector collector)
        {
            this.collector = collector;
        }


        public void Process()
        {
            collector.Add("One");
            collector.Add("Two");
            collector.Add("Three");

            Console.WriteLine(collector.Total);
        }

        
    }
}
