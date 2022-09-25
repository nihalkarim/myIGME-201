using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            string response = "";

            while(!isValid)
            {
                Console.Write("Which one can you live without: good, fast, or cheap? \t");
                response = Console.ReadLine();
                response = response.ToLower();
                if(response == "good" || response == "cheap" || response == "fast")
                {
                    isValid = true;
                }
            }

            if(response == "good")
            {
                Console.WriteLine("Your product will be {0} and {1}.", "fast", "cheap");
            }
            else if (response == "fast")
            {
                Console.WriteLine("Your product will be {0} and {1}.", "good", "cheap");
            }
            else if (response == "cheap")
            {
                Console.WriteLine("Your product will be {0} and {1}.", "good", "fast");
            }
        }
    }
}