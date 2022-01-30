using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_assignment
{
    class LoanException : ApplicationException
    {
        public LoanException(string msg) : base(msg)
        {

        }
    }
    class LoanProcess
    {
        public long Loan_No;
        public string CustomerName;
        public float LoanAmount;
        public float EMI_Amount;
        public float Account_Balance;
        public LoanProcess()
        {
            Console.WriteLine("Enter the Customer name: ");
            CustomerName = Console.ReadLine();

            Console.WriteLine("Enter the Loan No of Customer: ");
            Loan_No = Convert.ToInt32(Console.ReadLine());
        }

        public void calculate_EMI()
        {

            Console.WriteLine("Enter the loan amount: ");
            LoanAmount = float.Parse(Console.ReadLine());
            EMI_Amount = (LoanAmount * 13 * 3) / 100;
            Console.WriteLine("EMI Amount to be paid : " + EMI_Amount);
        }

        public void CheckBalance()
        {
            Console.WriteLine("Enter Your Account Balance : ");
            Account_Balance = float.Parse(Console.ReadLine());
            if (Account_Balance < EMI_Amount)
            {
                throw (new LoanException("Not Sufficient Balance to repay Loan"));
            }
            else
            {
                Console.WriteLine("EMI amount debited from your account");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LoanProcess obj = new LoanProcess();
            Console.WriteLine("Account Name: " + obj.CustomerName);
            Console.WriteLine("Loan details: " + obj.Loan_No);
            Console.WriteLine("-------------------------------------------------");
            obj.calculate_EMI();
            try
            {
                obj.CheckBalance();
            }
            catch (LoanException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.Read();
        }
    }
}
