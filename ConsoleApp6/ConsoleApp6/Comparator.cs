using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
     class Comparator
    {
        public double num1;
        public double num2;

        public Comparator()
	    {
            Console.Write("Please type in the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please type in the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }      

        public static void PozitiveNegativeEqual(double Num1, double Num2)
        {
            if ((Num1 > 0 && Num2 > 0) && (Num1 != Num2))
            {
                Console.WriteLine($"Both {Num1} and {Num2} are positive numbers.");
            }
            else if (Num1 < 0 && Num2 < 0 && (Num1 != Num2))
            {
                Console.WriteLine($"Both {Num1} and {Num2} are negative numbers.");
            }
            else if (Num1 > 0 && Num2 < 0)
            {
                Console.WriteLine($"{Num1} is a positive number and {Num2} is a negative number.");
            }
            else if (Num1 < 0 && Num2 > 0)
            {
                Console.WriteLine($"{Num1} is a negative number and {Num2} is a positive number.");
            }
            else if (Num1 == Num2 && ((Num1 < 0 && Num2 < 0) || (Num1 > 0 && Num2 > 0)))
            {
                Console.WriteLine($"{Num1} and {Num2} represent equal numbers.");
            }
            else if (Num1 == 0 || Num2 == 0 || (Num1 == 0 && Num2 == 0))
            {
                Console.WriteLine("The number 0 is not considered either positive nor negative.");
            }

        }

        public static void OddEven(double num1, double num2)
        {
           if ((num1 % 2 == 0) && (num2 % 2 == 0))
	       {
                Console.WriteLine($"Both {num1} and {num2} are even numbers.");
	       }
           else if ((num1 % 2 == 1) && (num2 % 2 == 1))
	       {
                Console.WriteLine($"Both {num1} and {num2} are odd numbers.");
	       }
           else if ((num1 % 2 == 0) && (num2 % 2 == 1)) 
	       {
                Console.WriteLine($"{num1} is an even number and {num2} is an odd number.");
	       }
           else if ((num1 % 2 == 1) && (num2 % 2 == 0)) 
	       {
                Console.WriteLine($"{num1} is an odd number and {num2} is an even number.");
	       }
           else if (num1 == 0 || num2 == 0 || (num1 == 0 && num2 == 0))
           {
                Console.WriteLine("The number 0 is not considered either odd nor even.");
           }
        }
    }
}
