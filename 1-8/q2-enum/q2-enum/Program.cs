using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        enum Rainbow : short
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            purple,
            black,
            white
        }

        enum Rainbow2 : byte
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            purple,
            black,
            white
        }


        static void Main(string[] args)
        {

        }
    }
}