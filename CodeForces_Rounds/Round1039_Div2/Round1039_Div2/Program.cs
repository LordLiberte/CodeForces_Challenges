using System;
using System.Collections.Generic;
using System.Linq;

namespace Round1039_Div2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());

            while (testCases > 0)
            {
                int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int n = data[0];
                int c = data[1];
                int totalCost = 0;

                List<int> bags = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


                for (int i = 0; i < n; i++)
                {
                    int min_bag = bags.Min();   

                    if (min_bag > c)
                    {
                        totalCost = bags.Count;
                        break;
                    }

                    bags = bags.Where(b => b != min_bag).ToList();

                    for (int j = 0; j < bags.Count; j++)
                    {
                        bags[j] *= 2;
                    }
                }

                Console.WriteLine(totalCost);
                testCases--;
            }
        }
    }
}