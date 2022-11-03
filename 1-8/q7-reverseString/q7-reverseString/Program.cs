using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
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
            string input = "";

            Console.Write("Enter a string: ");
            input = Console.ReadLine();

            Console.WriteLine($"\nthe word is: {input}");

            char[] letters = input.ToCharArray();
            
            Array.Reverse(letters);
            Console.Write("\nthe reversed word is: ");
            foreach (char letter in letters)
            {
                Console.Write($"{letter}");
            }

        }
    }
}