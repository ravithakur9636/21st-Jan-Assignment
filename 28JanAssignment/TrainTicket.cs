using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicket
{
    class TicketBookingException : ApplicationException
    {
        public TicketBookingException(string msg) : base(msg)
        {

        }
    }
    class passenger
    {
        int age;
        string name;
        int No_of_ticket;
        public void TicketBooking()
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of ticket you want:");
            int No_of_ticket = int.Parse(Console.ReadLine());
            if(No_of_ticket>5)
            {
                throw (new TicketBookingException("you cannot book more than five ticket at a time"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            passenger pas = new passenger();
            try
            {
                pas.TicketBooking();
            }
            catch(TicketBookingException ex)
            {
                Console.WriteLine(ex.Message +" "+ ex.Source);
            }
            Console.ReadLine();
        }
    }
}
