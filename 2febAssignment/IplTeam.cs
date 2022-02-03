using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPLAssignment
{
    class Cricket
    {
        public int sum;
        public double average;
        int[] TeamScore_array;

        public void Pointscalculation(int no_of_matches)
        {
            TeamScore_array = new int[no_of_matches];
            Console.WriteLine("Enter the score of {0} match : ", no_of_matches);
            Console.WriteLine();
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter the Score {0} Match : ", i + 1);
                TeamScore_array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < TeamScore_array.Length; i++)
            {
                sum = sum + TeamScore_array[i];
            }
            Console.WriteLine("The Sum of Scores in all the Matches : {0} ", sum);
            average = (double)sum / TeamScore_array.Length;
            Console.WriteLine("The Average of Scores in all the Matches : {0} ", average);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int NoOfMatches;
            Console.WriteLine("Enter the number of Match played by team in IPL:");
            NoOfMatches = int.Parse(Console.ReadLine());
            Cricket cricket = new Cricket();
            cricket.Pointscalculation(NoOfMatches);
        }
    }
}
