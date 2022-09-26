using System;

namespace UT1_BugSquash
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose: use user inputs to solve x^y
     * Restrictions: none
     */
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // int nY => Compile-time error: missing ';'
            int nY; //rewritten
            int nAnswer;

            //Console.WriteLine(This program calculates x ^ y.); => Compile-time error: the text isn't in ""
            Console.WriteLine("This program calculates x ^ y."); //rewritten

            do
            {
                Console.Write("Enter a whole number for x: ");
                //Console.ReadLine(); => Logic error: The answer is not saved anywhere
                sNumber = Console.ReadLine(); //rewritten
            } while (!int.TryParse(sNumber, out nX)); //Compile-time error: sNumber was originally unassigned, but works now bc the code in the 'do' was fixed

            bool positive = false; //adding for the while loop to check validity
            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();

                // logic, possible run time error: not checking if y is positive. Infinite loop if user enters neg. num.
                // add a try catch to make sure nY is pos.
                try
                {
                    nY = int.Parse(sNumber);
                    if (nY >= 0)
                    {
                        positive = true;
                    }
                }
                catch
                {
                    Console.Write("Please enter a positive number.");
                }

                nY = int.Parse(sNumber); // parse sNumber into an int for nY now that we know it's a pos. num.
            } //while (int.TryParse(sNumber, out nX)); => Runtime error: missing 'not'/!, causes infinite loop. Compile error: nX instead of nY, nY used but never defined
            while (!positive); //rewritten

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            //Console.WriteLine("{nX}^{nY} = {nAnswer}"); => Logic error: need a $ before the "" for interpolation
            Console.WriteLine($"{nX}^{nY} = {nAnswer}"); //rewritten
        }


        //int Power(int nBase, int nExponent) => Compile error: without static keyword, causes an error when assigning nAnswer
        static int Power(int nBase, int nExponent) //rewritten
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                //returnVal = 0; => Logic error: x^0 = 1 not 0
                returnVal = 1; //rewritten
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                //nextVal = Power(nBase, nExponent + 1); => Logic and runtime error: adding 1 instead of subtracting creates an infinite loop
                nextVal = Power(nBase, nExponent - 1); //rewritten

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            //returnVal; => Compile and logic error: missing the return keyword. Also fixes the error in the method declaration
            return returnVal; //rewritten
        }
    }
}
