using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturberegner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temperature do you want to calculate?");
            Console.Write("> ");
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = (celcius * 1.8) + 32;
            double reamur = celcius * 0.8;

            Console.WriteLine("\nCelcius = " + celcius + " °C" + "\nFahrenheit = " + fahrenheit + " °F" + "\nReamur = " + reamur + " °Ré");
            Console.ReadLine();
        }
    }
}
