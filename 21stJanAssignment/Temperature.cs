using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double Fahrenheit;
            Console.WriteLine("Enter the temperature in Fahrenheit:");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: "+celsius);
            Console.ReadLine();
        }
    }
}
