using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class FizzBuzz
    {
        //Numerele de la 1 la 100. Daca este multiplu de 3 sa se afiseze Fizz
        //Daca este multiplu de 5 sa se afiseze Buzz
        //Daca este multiplu si de 3 si de 5 sa se afiseze FizzBuzz
        public static void FizzBuzzMethod()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz ");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz ");
                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                else
                {
                    Console.WriteLine($"{i} ");
                }
            }
        }

    }
}
