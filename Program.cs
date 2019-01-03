using System;
using System.Text;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Console.WriteLine(worker.compute(" 1 + 2 +4+ 1"));
            Console.ReadLine();
        }

        
    }
}
