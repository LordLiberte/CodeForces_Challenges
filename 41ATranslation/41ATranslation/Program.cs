using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _41ATranslation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine().Replace(" ", "");
            string input2 = Console.ReadLine().Replace(" ", "");
            Console.WriteLine(input2[^1]);
            int counter_coincidence = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                if (input1[i] == input2[-1 + (-i)])
                {
                    counter_coincidence++;
                }
            }

            if (counter_coincidence == input1.Length)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
