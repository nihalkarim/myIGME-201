using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionEight
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence. No will be replaced with yes!");

            string input;
            string[] words;


            input = Console.ReadLine();
            words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == "no")
                {
                    words[i] = "yes";
                }

            }


            Console.WriteLine("You said:");
            foreach (string word in words)
            {
                Console.Write($"{word} ");
            }

        }
    }
}
