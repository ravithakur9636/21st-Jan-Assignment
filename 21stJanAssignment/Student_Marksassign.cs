using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Student_Marksassign
    {
        static void Main()
        {
            string name;
            float cSharp, HTML, Sql, sum, avg;
            int Subjects = 3;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the Name of Student:");
                name = Console.ReadLine();
                Console.WriteLine("Enter C# Marks:");
                cSharp = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter HTML Marks:");
                HTML = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter Sql Marks:");
                Sql = Convert.ToSingle(Console.ReadLine());
                sum = cSharp + HTML + Sql;
                avg = sum / Subjects;
                if (avg > 50)
                {
                    Console.WriteLine("You have Passed the exam");

                }
                else
                {
                    Console.WriteLine("Sorry, You have Failed in exam");
                }

            }
        }
    }
}