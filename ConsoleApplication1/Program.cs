using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 1; i <= 128; i++)
            {
                Console.WriteLine("\n", i);
                Console.WriteLine("{0} --------------------------------------", i);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(string.Format("Hallo Michael!", i));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(string.Format("Hallo Mama!", i));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(string.Format("Hallo Papa!", i));
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            Console.ReadKey();
        }
    }
}
