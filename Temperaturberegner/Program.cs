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
            // Prompt user to input temperature in Celsius
            Console.WriteLine("What temperature do you want to calculate?");
            Console.Write("> ");

            // Read and parse user input into the 'celsius' variable
            double celcius = double.Parse(Console.ReadLine());

            // Calculate temperature in Fahrenheit using the conversion formula
            double fahrenheit = (celcius * 1.8) + 32;

            // Calculate temperature in Reamur using the conversion formula
            double reamur = celcius * 0.8;

            // Display the calculated temperatures in Celsius, Fahrenheit, and Reamur
            Console.WriteLine("\nCelcius = " + celcius + " °C" + "\nFahrenheit = " + fahrenheit + " °F" + "\nReamur = " + reamur + " °Ré");

            // Wait for user input before exiting
            Console.ReadLine();
        }
    }
}
