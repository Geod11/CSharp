using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Temeperature
    {
        public static void Converter()
        {
            Console.Write("Please type the value in Celsius degress that you want converted to Farrenheit and Kelvin: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double farrenheit = (celsius * 9) / 5 + 32;
            double kelvin = celsius + 273.15;
            Console.WriteLine($"The conversion from {celsius} Celsius to Farrenheit is {farrenheit}");
            Console.WriteLine($"The conversion from {celsius} Celsius to Kelvin is {kelvin}");
        }
    }
}
