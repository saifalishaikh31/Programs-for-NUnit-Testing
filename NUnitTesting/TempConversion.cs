using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NUnitTesting
{
    class TempConversion
    {
        public void TemperatureConversion()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n1. Convert Celsius to Fahrenheit"
                             + "\n2. Convert Fahrenheit to Celsius");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the temperature in Celsius: ");
                        double tempCelcius = Convert.ToDouble(Console.ReadLine());
                        double resultFahrenheit = (tempCelcius * 9 / 5) + 32;
                        Console.WriteLine(tempCelcius + "°C to " + resultFahrenheit + "°F");
                        break;
                    case 2:
                        Console.WriteLine("Enter the temperature in Fahrenheit: ");
                        double tempFahrenheit = Convert.ToDouble(Console.ReadLine());
                        double resultCelcius = (tempFahrenheit - 32) * 5 / 9;
                        Console.WriteLine(tempFahrenheit + "°F to " + resultCelcius + "°C");
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
