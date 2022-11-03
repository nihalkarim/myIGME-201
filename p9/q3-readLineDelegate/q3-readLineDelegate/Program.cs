using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLineDelegate
{
    /* Author: Nihal Karim
     * Name: ReadLineDelegate
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        delegate string ReadLineD();

        static void Main(string[] args)
        {
            ReadLineD readLine;

            readLine = new ReadLineD(Console.ReadLine);

            string str = readLine();
        }
    }
}
