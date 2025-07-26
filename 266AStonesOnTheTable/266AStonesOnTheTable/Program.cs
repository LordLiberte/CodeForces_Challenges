using System;

namespace _266AStonesOnTheTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stones_row = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int number_stones = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    number_stones++;
                }
            }

            Console.WriteLine(number_stones);
        }
    }
}
