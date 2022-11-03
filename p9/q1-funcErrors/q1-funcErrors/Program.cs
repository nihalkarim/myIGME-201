using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcErrors
{
    /* Author: Nihal Karim
     * Name: funcErrors
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        static void Main(string[] args)
        {
            string label = "heyyy";
            bool showLabel = false;
            int[] nums = new int[] { 1, 2, 3, 4, 5 };

            Write();
            myFunction(label, showLabel, nums);
        }

        static bool Write()
        {
            Console.WriteLine("Text output from function.");
            return true;
        }

        static void myFunction(string label, bool showLabel, params int[] args)
        {
            if (showLabel)
            {
                Console.WriteLine(label);
            }

            foreach (int i in args)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
