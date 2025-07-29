using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59AWord
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            short upperCount = 0;
            short lowerCount = 0;

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    upperCount++;
                }

                else if (char.IsLower(c))
                {
                    lowerCount++;
                }
            }

            if (upperCount > lowerCount)
            {
                input = input.ToUpper();
            } else if (lowerCount >= upperCount)
            {
                input = input.ToLower();
            }

            Console.WriteLine(input);
        }
    }
}
