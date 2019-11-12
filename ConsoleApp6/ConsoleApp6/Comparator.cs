using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Comparator
    {
        public static void UserInput()
        {


        }

        public static void PozitiveNegativeEqual ()
        {
            Console.Write("Please type in the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please type in the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > 0 && num2 > 0)
            {
                Console.WriteLine($"Both {num1} and {num2} are positive.");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine($"Both {num1} and {num2} are negative.");
            }
            else if (num1 > 0 && num2 < 0)
            {
                Console.WriteLine($"{num1} is a positive value and {num2} is a negative value.");
            }
            else if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine($"{num1} is a negative value and {num2} is a positive value.");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"{num1}  and {num2} represent equal values.");
            }
            else if (num1 == 0 || num2 == 0 || (num1 == 0 && num2 == 0))
            {
                Console.WriteLine("The value 0 is not considered either positive nor negative");
            }
        }

        public static void OddEven ()
        {

        }
    }
}
