using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231ATeam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number_responses = int.Parse(Console.ReadLine());
            int number_problems = 0;

            for (int i = 0; i < number_responses; i++) {

                string [] options = Console.ReadLine().Split(' ');
                int one = 0;

                foreach (string option in options) {

                    if (option == "1")
                    {
                        one++;
                    }
                }

                if (one >= 2)
                {
                    number_problems++;
                }

            }

            Console.WriteLine(number_problems);
        }
    }
}
