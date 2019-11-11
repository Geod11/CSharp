using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Exercise23
    {
        public static string Excercise23()
        {
            while (true)
            {
                Console.Write("Write a word: ");
                string trimmedUserInput = Console.ReadLine().Trim();
                if (!string.IsNullOrWhiteSpace(trimmedUserInput))
                {
                    var indexOfSpace = trimmedUserInput.IndexOf(' ');
                    string cuv;
                    if (indexOfSpace > 0)
                    {
                        cuv = trimmedUserInput.Substring(0, indexOfSpace);
                    }
                    else
                    {
                        cuv = trimmedUserInput;
                    }
                    var l = cuv.Length;
                    if (l == 1)
                    {
                        return cuv;
                    }
                    else
                    {
                        string res = cuv[l - 1] + cuv.Substring(1, l - 2) + cuv[0];
                        return res;
                    }
                }
            }
        }
    }
}
