using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<double, string> prod = new SortedList<double, string>();
            Console.WriteLine("Enter Details of 10 Products:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the {0} stationary Item price and {1} Stationary Item Name", i + 1, i + 1);
                double ProductPrice = Convert.ToDouble(Console.ReadLine());
                string ProductName = Console.ReadLine();
                prod.Add(ProductPrice, ProductName);
            }
            Console.WriteLine("stationary Details after sort:");
            foreach (KeyValuePair<double, string> KV in prod)
            {
                Console.WriteLine("Stationary Item Name: {1} \t Stationary Item price: {0}", KV.Key, KV.Value);
            }
        }
    }
}
