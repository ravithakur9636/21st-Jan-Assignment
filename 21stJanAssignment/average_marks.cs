using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter all the 5 subject marks");
            int[] marks = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < marks.Length; i++)
            {

                sum = sum + marks[i];
            }
            Console.WriteLine(" TOTAL MARKS IN EXAM" + sum);
            int avg = sum / 5;
            Console.WriteLine("AVERAGE MARKS IN EXAM " + avg);
            Console.WriteLine("MINIMUM MARKS SCORED IN EXAM " + marks.Min());
            Console.WriteLine("MAXIMUM MARKS SCORED IN EXAM " + marks.Max());


            Array.Sort(marks);
            Console.WriteLine("MARKS obtained by student in Asc order");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Array.Reverse(marks);
            Console.WriteLine("MARKS obtained by student in Desc Order");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
