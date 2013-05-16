using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Random rand = new Random();
            for (int i = 0; i < 81; i++)
            {
                Console.WriteLine(rand.Next(999));
            }
            Console.ReadKey();
        }
    }
}
