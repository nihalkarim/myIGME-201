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
            //z = 3y^2 + 2x - 1

            // 1 <= x <= 1 in 0.1 increments
            // 1 <= y <= 4 in 0.1 increments

            double[,,] zFunc = new double[21, 31, 3];

            double x = 0;
            double y = 0;
            double z = 0;

            int nX = 0;
            int nY = 0;

            for(x = -1; x <= 0.1; x +=  0.1, nX++)
            {
                x = Math.Round(x, 1);
                nY = 0;
                for (y = -1; y <= 0.1; x += 0.1, ++nY)
                {
                    y = Math.Round(y, 1);

                    z = 3 * Math.Pow(y, 2) + 2 * x - 1;
                    z = Math.Round(z, 3);

                    zFunc[nX, nY, 0] = x;
                    zFunc[nX, nY, 1] = y;
                    zFunc[nX, nY, 2] = z;

                    Console.WriteLine($"x = {zFunc[nX, nY, 0]}  y = {zFunc[nX, nY, 1]}   z = {zFunc[nX, nY, 2]}");
                }

            }

        }
    }
}