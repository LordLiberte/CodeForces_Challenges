using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _282ABit__
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cicles = int.Parse(Console.ReadLine());
            int x_value = 0;

            for (int i = 0; i < cicles; i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < input.Length; j++)
                {

                    string item = input[j].ToString();

                    if (item == "X")
                    {
                        continue;
                    }
                    else if (item == "+")
                    {
                        x_value++;
                        break;
                    }
                    else if (item == "-")
                    {
                        x_value--;
                        break;
                    }

                }

            }

            Console.WriteLine(x_value);
        }
    }
}
