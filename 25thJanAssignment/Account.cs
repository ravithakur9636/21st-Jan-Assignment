using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account25jan
{
    class Account
    {
        public long AccNo;
        public string Name;
        public string AccType;
        public string TransactionType;
        public int Amount;
        public float balance;

        public Account(long accountno, string name, string acctype, string transaction, int amount)
        {
            AccNo = accountno;
            Name = name;
            AccType = acctype;
            TransactionType = transaction;
            Amount = amount;
        }
        public void Credit(int amt)
        {
            balance = balance + amt;
        }
        public void Debit(int amt)
        {
            balance = balance - amt;
        }
        public void update()
        {
            if (TransactionType == "Deposite")
            {
                Credit(Amount);
            }
            else if (TransactionType == "Withdraw")
            {
                Debit(Amount);
            }
        }

        public void BalanceofAccount()
        {
            Console.WriteLine("Enter Account balance before transaction: ");
            balance = float.Parse(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine($"Name of Account Holder: {Name}");
            Console.WriteLine($"Account Number : {AccNo}");
            Console.WriteLine($"Account Type : {AccType}");
            Console.WriteLine($"Transacation Type : {TransactionType}");
            Console.WriteLine($"Balance : {balance}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Account Ac = new Account(7873567656, "RAVI THAKUR", "Saving", "Deposite", 5000);
            Ac.BalanceofAccount();
            Ac.update();
            Ac.show();
            Console.WriteLine(" ");
            Account Ac1 = new Account(0484256314, "SAPNA SHARMA", "Loan", "Withdraw", 9000);
            Ac1.BalanceofAccount();
            Ac1.update();
            Ac1.show();
            Console.Read();
        }
    }
}