using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    public interface IStudent
    {

        void ShowDetails(int StudentId, string StudentName);

    }
    class Dayscholar : IStudent
    {
        public void ShowDetails(int StudentId, string StudentName)
        {
            Console.WriteLine($"The person with {StudentId} and {StudentName} belongs to DayScholars");
            Console.ReadLine();
        }
    }

    class Resident : IStudent
    {
        public void ShowDetails(int StudentId, string StudentName)
        {
            Console.WriteLine($"The person with {StudentId} and {StudentName} belongs to Residental");
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dayscholar obj = new Dayscholar();
            obj.ShowDetails(101, "Ravi Thakur");
            obj.ShowDetails(103, "Aayush Sharma");
            obj.ShowDetails(105, "Ankit Mishra");
            Resident obj1 = new Resident();
            obj1.ShowDetails(102, "Shashi Thakur");
            obj1.ShowDetails(104, "Gaurav Arora");
            obj1.ShowDetails(106, "Vinod Kamble");
            Console.Read();
        }
    }
}
