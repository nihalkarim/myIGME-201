using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListTuple
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose: Use a sorted list that takes in a tuple of 3 doubles and a double. Use the list to calcualte values for z = 4y^3 + 2x^2 - 8w + 7
     * Restrictions: none
     */
    class Program
	{
		static void Main(string[] args)
		{
			SortedList<(double, double, double), double> zSortedList = new SortedList<(double, double, double), double>();


            /* Use the necessary for() loops to store the values of z (which would also be a double) for the following ranges of w, x and y using the tuple as the index key.
             * You must round w,x and y to 1 decimal place, and round z to 3 decimal places:
                    -2 <= w <= 0 in 0.2 increments 
                    -1 <= y <= 1 in 0.1 increments 
                    0 <= x <= 4 in 0.1 increments
             */

            //z = 4y^3 + 2x^2 - 8w + 7

            double w = 0;
            double x = 0;
            double y = 0;
            double z = 0;

            int nW = 0;
            int nX = 0;
            int nY = 0;

            for(w = -2; w <= 0; w += 0.2, nW++)
            {
                w = Math.Round(x, 1);

                nX = 0;

                for (x = 0; x <= 4; x += 0.1, nX++)
                {
                    x = Math.Round(x, 1);

                    nY = 0;

                    for (y = -1; y <= 1; y += 0.1, nY++)
                    {
                        y = Math.Round(y, 1);

                        // formula: z = 4y ^ 3 + 2x ^ 2 - 8w + 7

                        // calculate this value of z and round to 3 decimal places
                        z = 4*Math.Pow(y, 3) + 2*Math.Pow(x, 2) - 8*w + 7;
                        z = Math.Round(z, 3);

                        // store z for this (w,x,y) coordinate
                        zSortedList[(w, x, y)] = z;
                    }

                }

            }
        }
    }
}
