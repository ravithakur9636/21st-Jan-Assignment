
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract25jan
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public float Grade;

        public abstract Boolean IsPassed(float Grade);

        public void GetData()
        {
            Console.WriteLine("Enter the Student Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the Student ID : ");
            StudentId = int.Parse(Console.ReadLine());
        }
        public void DisplayData()
        {
            Console.WriteLine("The Name of the Student is : {0}", Name);
            Console.WriteLine("The Student Id is : {0}", StudentId);
        }
    }
    class UnderGraduate : Student
    {
        public override bool IsPassed(float grade)
        {
            Console.WriteLine("Undergraduate Grade : {0}", grade);
            if (grade >= 70.0f)
            {
                //Console.WriteLine("Passed");
                return true;
            }
            return false;
        }

    }
    class Graduate : Student
    {
        public override bool IsPassed(float grade)
        {
            Console.WriteLine("Graduate Grade : {0}", grade);
            if (grade >= 80.0f)
            {
                //Console.WriteLine("Passed");
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool pass;
            UnderGraduate ug = new UnderGraduate();
            ug.GetData();
            ug.DisplayData();
            pass = ug.IsPassed(78.8f);
            if (pass)
            {
                Console.WriteLine("The Student Passed in Undergraduation.");
            }
            else
            {
                Console.WriteLine("The Student Failed in Undergraduation");
            }
            UnderGraduate ug1 = new UnderGraduate();
            ug1.GetData();
            ug1.DisplayData();
            pass = ug1.IsPassed(56.2f);
            if (pass)
            {
                Console.WriteLine("The Student Passed in Undergraduation.");
            }
            else
            {
                Console.WriteLine("The Student Failed in Undergraduation");
            }
            Graduate grad = new Graduate();
            grad.GetData();
            grad.DisplayData();
            pass = grad.IsPassed(30.0f);
            if (pass)
            {
                Console.WriteLine("The Student Passed in Graduation.");
            }
            else
            {
                Console.WriteLine("The Student Failed in Graduation");
            }
            Graduate grad1 = new Graduate();
            grad1.GetData();
            grad1.DisplayData();
            pass = grad1.IsPassed(87.0f);
            if (pass)
            {
                Console.WriteLine("The Student Passed in Graduation.");
            }
            else
            {
                Console.WriteLine("The Student Failed in Graduation");
            }
            Console.Read();
        }
    }
}
