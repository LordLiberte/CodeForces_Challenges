using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71A_WayTooLongWords
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int wordCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < wordCount; i++)
            {

                string word = Console.ReadLine();
                string[] words = word.Split(' ');

                if (word.Length > 10)
                {
                    string shortenedWord = word[0] + (word.Length - 2).ToString() + word[word.Length - 1];
                    Console.WriteLine(shortenedWord);
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
