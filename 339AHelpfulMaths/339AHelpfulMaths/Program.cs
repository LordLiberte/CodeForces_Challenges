using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _339AHelpfulMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lee la entrada de numeros separados por '+'
            string[] numbers = Console.ReadLine().Split('+');
            List<int> sortedNumbers = new List<int>();
            // Convierte los numeros a enteros, los ordena y los concatena en una cadena
            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int num))
                {
                    sortedNumbers.Add(num);
                }
            }
            sortedNumbers.Sort();


            // Construye la cadena de salida con los numeros ordenados
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < sortedNumbers.Count; i++)
            {
                result.Append(sortedNumbers[i]);
                if (i < sortedNumbers.Count - 1)
                {
                    result.Append('+');
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
