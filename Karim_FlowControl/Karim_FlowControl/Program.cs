using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /* Author: Nihal Karim
     * Purpose: To complete #2 on the Flow Control homework document
     * Restrictions: none  */

    class Program
    {
        static void Main(string[] args)
        {

            bool validInput = false;
            int var1 = 0;
            int var2 = 0;

            while (!validInput)
            {

                Console.WriteLine("Enter 2 numbers. Only one may be greater than 10");
                Console.Write("Enter var1: ");
                var1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter var2: ");
                var2 = Convert.ToInt32(Console.ReadLine());

                if (var1 > 10 && var2 > 10)
                {
                    validInput = false;
                    Console.WriteLine("Invalid input. Only one number can be > 10. Please try again.");
                }
                else
                {
                    validInput = true;
                }
            }


            bool result;
           
            if (var1 > 10 ^ var2 > 10)
            {
                result = true;
                if (var1 > 10)
                {
                    Console.WriteLine("The result is " + result + "\n" + var1 + " is > 10!");
                }
                else if (var2 > 10)
                {
                    Console.WriteLine("The result is " + result + "\n" + var2 + " is > 10!");
                }
            }
            else
            {
                result = false;
                Console.WriteLine("The result is " + result + "\n" + "Neither of the numbers are > 10");
            }


        }
    }
}

