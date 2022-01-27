using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student25Jan
{
    class Student
    {
        public int RollNo;
        public int Class;
        public string Name;
        public int Semester;
        public string Branch;
        public float Average;
        public int[] marks = new int[5];

        public Student(int rollno, int Class1, int sem, string name, string branch)
        {
            RollNo = rollno;
            Class = Class1;
            Name = name;
            Semester = sem;
            Branch = branch;
        }
        public void GetMarks()
        {
            Console.WriteLine($" {Name} Marks.....");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Enter subject {0} marks", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            int Sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                Sum = Sum + marks[i];
            }
            Average = Sum / marks.Length;
            Console.WriteLine("Average Marks of all subject is : {0}", Average);
        }
        public void result()
        {

            int flag = 0;
            foreach (int subMarks in marks)
            {
                if (subMarks < 35)
                {
                    flag = 1;
                }
                else if (subMarks > 35 && Average < 50)
                {
                    flag = 2;
                }
                else if (Average > 50)
                {
                    flag = 3;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Result : Failed");
            }
            else if (flag == 2)
            {
                Console.WriteLine("Result : Failed");
            }
            else if (flag == 3)
            {
                Console.WriteLine("Result : Passed");
            }
        }
        public void DisplayData()
        {
            Console.WriteLine("");
            Console.WriteLine($"Name of student is : {Name} ");
            Console.WriteLine($"RollNo of student is : {RollNo}");
            Console.WriteLine($"Class : {Class}");
            Console.WriteLine($"Semester : {Semester}");
            Console.WriteLine($"Branch : {Branch}");
            Console.WriteLine($"Average marks of all subject are : {Average}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(65, 8, 7, "Ravi Thakur", "Computer");
            student.GetMarks();
            student.DisplayResult();
            student.DisplayData();
            student.result();
            Console.Read();
        }
    }
}
