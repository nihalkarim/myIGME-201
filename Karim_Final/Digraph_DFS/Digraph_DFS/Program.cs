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

        static (string, int)[][] lGraph = new (string, int)[][]
        {
           /* RED */    new (string, int)[] { ("indigo", 1 ), ("gray", 5) },
           /* INDIGO */ new (string, int)[] { ("blue", 1), ("yellow", 8) },
           /* GRAY */   new (string, int)[] { ("blue", 1), ("orange", 1) },
           /* BLUE */   new (string, int)[] { ("indigo", 1), ("gray", 0) },
           /* YELLOW */ new (string, int)[] { ("green", 6) },
           /* ORANGE */ new (string, int)[] { ("purple", 1) },
           /* PURPLE */ new (string, int)[] { ("yellow", 1) },
           /* GREEN */  null
        };

        static void Main(string[] args)
        {

        }

        static void DFS()
        {
            bool[] visited = new bool[lGraph.Length];

            DFSUtil(v, visited);
        }

        static void DFSUtil(int v, bool[] visited)
        {
           
        }
    }
}
