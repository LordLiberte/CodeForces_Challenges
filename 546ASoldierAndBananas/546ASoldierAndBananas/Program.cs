using System;

namespace _546ASoldierAndBananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int k = int.Parse(data[0]); // Price of first banana
            int n = int.Parse(data[1]); // Dollars available
            int w = int.Parse(data[2]); // Number of bananas to buy
            int totalCost = 0;

            // Calculate the total cost of bananas
            totalCost = k * w * (w + 1) / 2;

            // Calculate the amount to borrow
            int amountToBorrow = totalCost > n ? totalCost - n : 0;

            Console.WriteLine(amountToBorrow);
        }
    }
}
