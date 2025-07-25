using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _281AWordCapitalization
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            // Obtiene la primera letra
            string firstLetter = input[0].ToString();
            // Obtiene el resto de la cadena
            string subString = input.Substring(1);
            // Convierte la primera letra a mayúscula y concatena con el resto de la cadena
            string capitalizedFirstLetter = firstLetter.ToUpper() + subString;

            Console.WriteLine(capitalizedFirstLetter);
        }
    }
}
