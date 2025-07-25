using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112APetyaAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int entrys = 2;
            string[] inputs = new string[entrys];

            for (int i = 0; i < entrys; i++)
            {
                string entry = Console.ReadLine();
                inputs[i] = entry.ToLower();
            }

            string first = inputs[0];
            string second = inputs[1];

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine("-1");
                    return;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine("1");
                    return;
                }
            }

            if (first == second)
            {
                Console.WriteLine("0");
            }
        }
    }
}
