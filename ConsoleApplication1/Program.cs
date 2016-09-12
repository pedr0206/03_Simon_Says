using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03_Simon_Says;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Simon simon = new Simon();
            Console.WriteLine(simon.Echo("Hello Mum - send me more money"));
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("the value of I is ; " + i ) ;
            }
            // Console.WriteLine(simon.Shout("hello"));
            Console.Write("Press any key...");
            Console.ReadKey();
        }
    }
}
