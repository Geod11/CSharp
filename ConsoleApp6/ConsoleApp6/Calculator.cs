using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Calculator
    {
        public static void CalculatorMethod()
        {
            Console.Write("Please type in the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please type in the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            int add = num1 + num2;
            Console.WriteLine("The result of " + num1 + " + " + num2 + " = " + add);
            int subtract = num1 - num2;
            Console.WriteLine("The result of {0} - {1} = {2}", num1, num2, subtract);
            int multiply = num1 * num2;
            Console.WriteLine($"The result of {num1} x {num2} = {multiply}");
            double divide = Convert.ToDouble(num1) / Convert.ToDouble(num2);           
            if (num1 == 0 || num2 == 0 || (num1 == 0 && num2 == 0))
            {
                Console.WriteLine("Sorry but division by 0 is not possible");
            }
            else
            {
                int moduloResult = num1 % num2;
                Console.WriteLine($"The result of {num1} / {num2} = {divide}");
                Console.WriteLine($"The result of {num1} % {num2} = {moduloResult}");
            }          
        }
    }
}
