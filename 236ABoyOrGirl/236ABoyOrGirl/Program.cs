using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _236ABoyOrGirl
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int differentCharsCount = input.Distinct().Count();

            Console.WriteLine(differentCharsCount % 2 == 0 ? "CHAT WITH HER!" : "IGNORE HIM!");

        }
    }
}
