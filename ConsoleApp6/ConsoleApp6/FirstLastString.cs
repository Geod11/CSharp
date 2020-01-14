using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class FirstLastString
    {
        public static string FirstLastMethod()
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
                        Console.WriteLine($"Din cuvantul \"{cuv}\" prima si ultima litera vor fi schimbate intre ele.");
                    }
                    else
                    {
                        cuv = trimmedUserInput;
                        Console.WriteLine($"Din cuvantul \"{cuv}\" prima si ultima litera vor fi schimbate intre ele.");
                    }
                    var l = cuv.Length;
                    if (l == 1)
                    {
                        Console.WriteLine(cuv);
                        return cuv;
                    }
                    else
                    {

                        string res = cuv[l - 1] + cuv.Substring(1, l - 2) + cuv[0];
                        Console.WriteLine($"Noul cuvant este \"{res}\".");
                        return res;
                    }
                }
            }
        }
    }
}
