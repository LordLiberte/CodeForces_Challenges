using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _263ABeautifulMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int entrys = 5;
            int[,] matrix = new int[5, 5];
            int row_pos = 0;
            int col_pos = 0;


            // Creación de la matriz
            for (int i = 0; i < entrys; i++)
            {
                string[] strings = Console.ReadLine().Split(' ');

                foreach (string s in strings)
                {
                    int value = int.Parse(s);
                    matrix[i, Array.IndexOf(strings, s)] = value;
                }
            }

            // Definimos la posición del 1
            for (int n = 0; n < 5; n++)
            {
                for (int m = 0; m < 5; m++)
                {
                    if (matrix[n, m] == 1)
                    {
                        row_pos = n;
                        col_pos = m;
                    }
                
                }
            }

            // Cálculo de movimientos
            int moves = 0;
            if (row_pos > 2)
            {
                moves += row_pos - 2;
            }
            else if (row_pos < 2)
            {
                moves += 2 - row_pos;
            }

            if (col_pos > 2)
            {
                moves += col_pos - 2;
            }
            else if (col_pos < 2)
            {
                moves += 2 - col_pos;
            }



            Console.WriteLine(moves);
        }
    }
}
      
