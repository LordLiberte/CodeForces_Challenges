using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A110NearlyLuchyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int luckyCounter = 0;
            List<char> luckyNumbers;

            // Only have lucky numbers of the input
            luckyNumbers = input.Where(c => c == '4' || c == '7').ToList();

            // Count the lucky numbers
            luckyCounter = luckyNumbers.Count();

            if (luckyCounter == 4 || luckyCounter == 7)
            {
                Console.WriteLine("YES");
            } else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
