using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose: recreate Math.Round(double, int)
     * Restrictions: not working :(
     */
    class Program
    {
        delegate double MathRound(double dec, int rounding);

        static void Main(string[] args)
        {
            MathRound myRound;

            myRound = new MathRound(Math.Round);

            double result = myRound(84.92732, 2);

            Console.WriteLine(result);

            /* Create a console application that uses a delegate to impersonate the Math.Round(double, int) function.
             * (Refer to "Math Delegate", "MemoryGame" or the attached "Number Sorter" application for delegate code examples). 
             * 1 extra point will be given for each additional implementation you can demonstrate using abbreviated notation, anonymous methods, the lambda operator and/or the generic template type. (Up to 5 extra points are available!)
             */
        }

    }
}