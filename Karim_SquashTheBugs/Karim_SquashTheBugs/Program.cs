using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Nihal Karim
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            //int i = 0; // compile-time error; missing semicolon
            decimal i = 0; // logic error; some of the results should have decimal points -> convert int to decimal

            // declare string to hold all numbers
            string allNumbers = null; //moved to the outside of the for loop

            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)  // logic error; does not include 10
            for (i = 1; i <= 10; ++i) 
            {
                // declare string to hold all numbers
                //string allNumbers = null;  // logic error; string declared inside of for loop, which creates an issue with the last satement -> moved to lines 23-24

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ");  // compile-time error; can't use '-' with an int and a string
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1));  // runtime error; attempts to divide by 0 on the first run -> try catch block
                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("Error: Can not divide by 0");
                }

                // concatenate each number to allNumbers
                allNumbers += i + "  ";

                // increment the counter
                //i = i + 1;  // logic error; adds number before incrementing
                i = i++;
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers);  // compile-time error; allNumbers was not defined in this scope
                                                                                    // compile-time error; need to concatinate the string w/ variable
            Console.WriteLine("These numbers have been processed: " + allNumbers); 
        }
    }
}
