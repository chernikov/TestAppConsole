using System;

namespace TestAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collector = new Collector();
            var processor = new Processor(collector);

            processor.Process();
            Console.ReadLine();
        }
    }
}
