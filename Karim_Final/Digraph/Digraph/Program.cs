using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class Digraph
    {
        // the adjacency values for the directed graph version.  
        // Only allow the paths that reach the goal
        static bool[,] mGraph = new bool[,]
        {
                       // RED       INDGO     GRAY      BLUE      YELLOW    ORANGE    PURPLE    GREEN
           /* RED */    { false,    true,     true,     false,    false,    false,    false,    false },
           /* INDIGO */ { false,    false,    false,    true,     true,     false,    false,    false },
           /* GRAY */   { false,    false,    false,    true,     false,    true,     false,    false },
           /* BLUE */   { false,    true,     true,     false,    false,    false,    false,    false },
           /* YELLOW */ { false,    false,    false,    false,    false,    false,    false,    true },
           /* ORANGE */ { false,    false,    false,    false,    false,    false,    true,     false },
           /* PURPLE */ { false,    false,    false,    false,    true,     false,    false,    false },
           /* GREEN */  { false,    false,    false,    false,    false,    false,    false,    false }
        };

        static string[][] lGraph = new string[][]
        {
           /* RED */    new string[] { "indigo", "gray" },
           /* INDIGO */ new string[] { "blue", "yellow" },
           /* GRAY */   new string[] { "blue", "orange" },
           /* BLUE */   new string[] { "indigo", "gray" },
           /* YELLOW */ new string[] { "green" },
           /* ORANGE */ new string[] { "purple" },
           /* PURPLE */ new string[] { "yellow" },
           /* GREEN */  null
        };

        static void Main(string[] args)
        {

        }
    }
}
