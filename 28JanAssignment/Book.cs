using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Demo
{
    struct NewBooks
    {
        private int Book_Id;
        public int n
        {
            get
            {
                return Book_Id;
            }
            set
            {
                if (value < 40)
                    Book_Id = value;
            }
        }
        public void BooksMethod()
        {
            Console.WriteLine("\n the stored value of book_id is: {0}\n", Book_Id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n Declares a structure called Books with a property, a method to display the value of Book_id and a private field called Book_id(int):\n");
            Console.WriteLine("------------------------------------------------------");
            NewBooks ravi = new NewBooks();
            ravi.n = 20;
            ravi.BooksMethod();
        }
    }
}
