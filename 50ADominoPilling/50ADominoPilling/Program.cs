using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50ADominoPilling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');
            int piece = 2;

            int number_pieces = (int.Parse(input[0]) * int.Parse(input[1])) / piece;
            Console.WriteLine(number_pieces);


        }
    }
}
