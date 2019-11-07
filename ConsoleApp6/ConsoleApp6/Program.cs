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
            //Numerele de la 1 la 100. Daca este multiplu de 3 sa se afiseze Fizz
            //Daca este multiplu de 5 sa se afiseze Buzz
            //Daca este multiplu si de 3 si de 5 sa se afiseze FizzBuzz

            //for (int i = 1; i < 101; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz ");
            //    }

            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz ");
            //    }

            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz ");                    
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{i} ");
            //    }                                
            //}

            //Un program care cere un cuvant si inverseaza prima cu ultima litera
            Console.Write("Write a word: ");
            string userInput = Console.ReadLine();
            char[] userInputArray = userInput.ToCharArray();
            
            for (int i = 0; i < userInputArray.Length; i++)
            {
                char primul = userInputArray[i];
                userInputArray[i] = userInputArray[0];
                userInputArray[0] = primul;

                //char ultimul = userInputArray[i];
                //userInputArray[i] = userInputArray[userInputArray.Length - 1];
                //userInputArray[userInputArray.Length - 1] = ultimul;
            }

            string result = new string(userInputArray);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
