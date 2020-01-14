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
            //1.Print the numbers from 1 to 100 with the following conditions:
            //- if the number is a multiple of 3 "Fizz" should be displayed instead;
            //- if the number is a multiple of 5 "Buzz" should be displayed instead;
            //- if the number is a multiple of both 3 and 5 "FizzBuzz" should be displayed instead.
            Console.WriteLine("FIZZ BUZZ");
            FizzBuzz.FizzBuzzMethod();
            Console.WriteLine();

            // 2. Display a piramid made from a character provided by the user with the height desired by the user as well.
            Console.WriteLine("CHARACTER PIRAMID");
            Piramid.Piramida();
            Console.WriteLine();

            // 3. Ask for a string input from the user and swap the first and last letter/character of the first word.  
            Console.WriteLine("LETTER SWAPPER");
            FirstLastString.FirstLastMethod();
            Console.WriteLine();

            // 4. Create a calculator that will take 2 numbers from the user and add, subtract, multiply, divide and calculate modulo.
            Console.WriteLine("CALCULATOR");
            Calculator.CalculatorMethod();
            Console.WriteLine();

            // 5. Create a program that asks for the temperature in Celsius and converts to Farrenheit and Kelvin.
            Console.WriteLine("TEMPERATURE CONVERTER");
            Temeperature.Converter();
            Console.WriteLine();

            // 6. Create a program that take as input 2 numbers from the user and compares the to see which one is positiv/negative,
            //odd/even and if they are equal or not.
            Console.WriteLine("NUMBER COMPARATOR");
            Comparator userInput = new Comparator();
            Comparator.PozitiveNegativeEqual(userInput.num1, userInput.num2);           
            Comparator.OddEven(userInput.num1, userInput.num2);
                       

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        
    }
}
