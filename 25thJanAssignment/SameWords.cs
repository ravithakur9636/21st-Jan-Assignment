using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchedWords
{
    class SameWords
    {
        static void Main()
        {
            Console.WriteLine("Enter the first words:");
            string wrd1 = Console.ReadLine();
            Console.WriteLine("Enter the second words:");
            string wrd2 = Console.ReadLine();
            char[] first = wrd1.ToLower().ToCharArray();
            char[] second = wrd2.ToLower().ToCharArray();

            Array.Sort(first);
            Array.Sort(second);

            string x = new string(first);
            string y = new string(second);

            if (x == y)
            {
                Console.WriteLine("Given String 1 and String 2 both are same");
            }
            else
            {
                Console.WriteLine("Given String 1 and String 2 are not same");
            }
            Console.ReadLine();
        }
    }
}