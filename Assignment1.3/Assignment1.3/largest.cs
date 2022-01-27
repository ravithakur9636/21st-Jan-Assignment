using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("first number is greatest among three number");
                }
                else
                {
                    Console.WriteLine("Third number is greates among all three number");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("second number is greates among all three number");
            }
            else
            {
                Console.WriteLine("Third number is largest among all three number");
            }
        }
    }
}
