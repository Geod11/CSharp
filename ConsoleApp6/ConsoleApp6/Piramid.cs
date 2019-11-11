using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Piramid
    {
        public static void Piramida()
        {            
            Console.WriteLine("Choose a character that the will represent the building blocks of the pyramid: ");
            char blocks = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Choose how many levels should the pyramid be made out of: ");
            int levels = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < levels; i++)
            {
                for (int j = 0; j < levels - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write($"{blocks} ");
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
