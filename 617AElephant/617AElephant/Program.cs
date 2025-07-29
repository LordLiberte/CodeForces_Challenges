using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _617AElephant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int distance = int.Parse(Console.ReadLine());
            int steps = 0;
            float five_steps = distance / 5;
            float residual = distance % 5;

            if (residual == 0)
            {
                steps = (int)five_steps;
            }
            else if (residual != 0)
            {
                steps = (int)five_steps + 1;
            }



            Console.WriteLine(steps);

        }
    }
}
