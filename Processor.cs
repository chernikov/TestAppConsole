using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionItems
{
    public class Processor
    {
        private Collector collector;

        public Processor()
        {
            collector = new Collector();
        }


        public void Process()
        {
            collector.Add("One");
            collector.Add("Two");

            Console.WriteLine(collector.Total);
        }
    }
}
