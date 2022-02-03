using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelChargesAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            int Fare = 500;
            string Name;
            int Age;
            Console.WriteLine("Enter The Name of a Person: ");
            Name = Console.ReadLine();
            CalculateConcession.Concession obj = new CalculateConcession.Concession();
            obj.CalculateConcession1();
        }

    }
}
namespace CalculateConcession
{
    public class Concession
    {
        public double Fare = 500;
        int age;
        public void CalculateConcession1()
        {
            Console.WriteLine("Enter The Person's Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 5)
            {
                Console.WriteLine("Little Champs-Free Tickets:");
            }
            else if (age > 60)
            {
                double CalculatedFare = Fare * 0.30;
                double FinalFare = Fare - CalculatedFare;

                Console.WriteLine("Senior people have to pay:Rs.{0}", FinalFare);
            }
            else
            {
                Console.WriteLine("You have to pay Rs.{0}", Fare);
            }
        }
    }
}
