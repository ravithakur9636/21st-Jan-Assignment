using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAssignment
{
    class product
    {
        public int Id;
        public string Name;
        Dictionary<string, Double> Product1 = new Dictionary<string, double>();

        public void GetData()
        {
            Console.WriteLine("Enter 10 products in Dictionary format : ");
            for (int i = 0; i < 10; i++)
            {
                Product1.Add(Console.ReadLine(), double.Parse(Console.ReadLine()));
            }
        }
        public void Sortdata()
        {
            Console.WriteLine("------------Sorted by product Price--------------");
            foreach (KeyValuePair<string, Double> Price in Product1.OrderBy(key => key.Value))
            {
                Console.WriteLine("product name is: {0}, Value of product is: {1}", Price.Key, Price.Value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            product item = new product();
            item.GetData();
            item.Sortdata();
        }
    }
}
