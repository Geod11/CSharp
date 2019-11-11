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
            // 1. Print the numbers from 1 to 100 with the following conditions:
            // - if the number is a multiple of 3 "Fizz" should be displayed instead;
            // - if the number is a multiple of 5 "Buzz" should be displayed instead;
            // - if the number is a multiple of both 3 and 5 "FizzBuzz" should be displayed instead.
            ////FizzBuzz.FizzBuzzMethod(); 

            // 2. Display a piramid made from a character provided by the user with the height desired by the user as well.
            ////Piramid.Piramida();

            // 3. Ask for a string input from the user and swap the first and last letter/character of the first word.       
            ////FirstLastString.FirstLastMethod();

            // 4. Create a calculator that will take 2 numbers from the user and add, subtract, multiply, divide and calculate modulo.
            Calculator.CalculatorMethod();


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}
