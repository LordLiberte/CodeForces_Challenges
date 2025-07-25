using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158ANextRound
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] n_k = Console.ReadLine().Split(' ');
            int n = int.Parse(n_k[0]);
            int k = int.Parse(n_k[1]);
            string[] points = Console.ReadLine().Split(' ');

            int counter = 0;
            int k_value;

            foreach (string point in points)
            {
                int p = int.Parse(point);
  
                k_value = int.Parse(points[k - 1]);
               
                if (p >= k_value && p > 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
