using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz.FizzBuzzMethod();

            Piramid.Piramida();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Exercise23.Excercise23());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}
