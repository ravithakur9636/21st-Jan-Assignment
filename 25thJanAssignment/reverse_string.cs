using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assinment2
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the String:");
            string reverse = Console.ReadLine();
            char[] word = reverse.ToCharArray();
            Array.Reverse(word);
            string reverseString = new string(word);
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }
    }
}