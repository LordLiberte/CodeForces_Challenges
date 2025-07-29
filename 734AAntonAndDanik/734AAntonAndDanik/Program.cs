using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _734AAntonAndDanik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int games = int.Parse(Console.ReadLine());
            string wins = Console.ReadLine();

           
               // Corrección: Usar Count en lugar de Where y corregir el operador de comparación y la sintaxis de la lambda
               int antonWins = wins.Count(b => b == 'A');
               int danikWins = wins.Count(b => b == 'D');

               if (antonWins > danikWins)
               {
                    Console.WriteLine("Anton");
               }
               else if (antonWins == danikWins)
               {
                    Console.WriteLine("Friendship");
               }
               else
               {
                    Console.WriteLine("Danik");
               }
        }
    }
}
