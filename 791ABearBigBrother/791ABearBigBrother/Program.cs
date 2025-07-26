using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _791ABearBigBrother
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] weigths = Console.ReadLine().Split(' ');
            int limack = int.Parse(weigths[0]);
            int bear = int.Parse(weigths[1]);
            int years = 0;

            while (limack <= bear)
            {
                limack *= 3;
                bear *= 2;
                years++;
            }

            Console.WriteLine(years);


        }
    }
}
