using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___3___Temperature_converter
{
    class Program
    {

        static void Main(string[] args)
        {

            char ChooseSecondUnit()
            {
                Console.WriteLine("Choose second unit: ");
                char c = Console.ReadKey(true).KeyChar;
                return c;
            }

            double HowManyDegrees(char c)
            {
                string name;
                switch(c)
                {
                    case 'k':
                        name = "kelvin";
                        break;
                    case 'f':
                        name = "fahrenheit";
                        break;
                    case 'c':
                        name = "celsius";
                        break;
                    default:
                        name = null;
                        break;
                }
                Console.WriteLine("How many " + name + " degrees?");
                string input = Console.ReadLine();
                double d;
                Double.TryParse(input, out d);
                return d;
            }

            double ConvertCelsius(char choosed, double value)
            {
                switch (choosed)
                {
                    //Fahrenheit
                    case 'f':
                        return (value * 9 / 5) + 32;
                        break;
                    //Kelvin
                    case 'k':
                        return value + 273.15;
                        break;
                }
                return value;
            }

            double ConvertFahrenheit(char choosed, double value)
            {
                switch (choosed)
                {//Celsius
                    case 'c':
                        return (value - 32) * 5 / 9;
                        break;
                    //Kelvin
                    case 'k':
                        return (value - 32) * 5 / 9 + 273.15;
                        break;
                }
                return value;
            }
    
            double ConvertKelvin(char choosed, double value)
            {
                switch (choosed)
                {//Celsius
                    case 'c':
                        return value - 273.15;
                        break;
                    //Fahrenheit
                    case 'f':
                        return (value - 273.15) * 9 / 5 + 32;
                        break;
                }
                return value;
            }

            char fUnit,choice;
            double hm;
            do
            {
                Console.WriteLine("Welcome to the Temperature converter \n" +
                    "Available units:\n" +
                    "Celsius - C\n" +
                    "Fahrenheit - F\n" +
                    "Kelvin - K\n" +
                    "Choose starting unit: ");
                fUnit = Console.ReadKey(true).KeyChar;
                switch (fUnit)
                {
                    //Celsius
                    case 'c':
                        Console.WriteLine("From -> Celsius");
                        choice = ChooseSecondUnit();
                        Console.WriteLine("To -> " + choice);
                        hm = HowManyDegrees(fUnit);
                        Console.WriteLine(ConvertCelsius(choice, hm));
                        break;

                    //Fahrenheit
                    case 'f':
                        Console.WriteLine("From -> Fahrenheit");
                        choice = ChooseSecondUnit();
                        Console.WriteLine("To -> " + choice);
                        hm = HowManyDegrees(fUnit);
                        Console.WriteLine(ConvertFahrenheit(choice, hm));
                        break;

                    //Kelvin
                    case 'k':
                        Console.WriteLine("From -> Kelvin");
                        choice = ChooseSecondUnit();
                        Console.WriteLine("To -> " + choice);
                        hm = HowManyDegrees(fUnit);
                        Console.WriteLine(ConvertKelvin(choice, hm));
                        break;
                }
                Console.WriteLine("\n");
            }while(true);

        }
    }
}
