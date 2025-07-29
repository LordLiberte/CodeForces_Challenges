using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _977AWrongSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            string n = input[0];
            short k = short.Parse(input[1]); // Number of decreases

            while (k-- > 0)
            {
                int number = int.Parse(n);
                short lastDigit = short.Parse(n[n.Length-1].ToString()); // Get the last digit

                if (lastDigit != 0)
                {
                    number--;
                    n = number.ToString();
                } else
                {
                    number /= 10;
                    n = number.ToString();
                }
            }

            Console.WriteLine(n);

        }
    }
}
