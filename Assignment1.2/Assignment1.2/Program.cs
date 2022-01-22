using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number:");
            i = int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.WriteLine("Entered number is an Even number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Entered number is an Odd number");
                Console.ReadLine();
            }
        }
    }
}
