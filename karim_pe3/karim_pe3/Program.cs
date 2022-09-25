using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /*
     * Author: Nihal Karim
     * Purpose: Create a program to do #5 on the PE3 assignment.
     */
    class Program
    {
        static void Main(string[] args)
        {

            /* Write a console application that obtains four int values from the user and displays the product.
             * Hint: you may recall that the Convert.ToDouble() command was used to covert the input from the console to a double;
             * the equivalent command to convert from a string to an int is Convert.ToInt32(). 
             */

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            int val1 = Convert.ToInt32(input1);
            int val2 = Convert.ToInt32(input2);
            int val3 = Convert.ToInt32(input3);
            int val4 = Convert.ToInt32(input4);
            Console.WriteLine(val1 * val2 * val3 * val4);
        }
    }
}

