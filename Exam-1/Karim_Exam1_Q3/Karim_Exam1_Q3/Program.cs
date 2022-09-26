using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /* Author:
     * Name:
     * Purpose:
     * Restrictions:
     */
    class Program
    {
        delegate double MathFunction(double d1, int precision);

        static void Main(string[] args)
        {
            /* Create a console application that uses a delegate to impersonate the Math.Round(double, int) function.
             * (Refer to "Math Delegate", "MemoryGame" or the attached "Number Sorter" application for delegate code examples). 
             * 1 extra point will be given for each additional implementation you can demonstrate using abbreviated notation, anonymous methods, the lambda operator and/or the generic template type. (Up to 5 extra points are available!)
             */

            /// delegate steps
            /// 1. define the delegate method data type based on the method signature
            ///         delegate double MathFunction(double n1, double n2);
            /// 2. declare the delegate method variable
            ///         MathFunction processDivMult;
            /// 3. point the variable to the method that it should call
            ///         processDivMult = new MathFunction(Multiply);
            /// 4. call the delegate method
            ///         nAnswer = processDivMult(n1, n2);

            // the definition of the delegate function data type

            MathFunction mathRound;

        }

        static double MathRound(double d1,  int precision)
        {
            d1
        }
    }
}