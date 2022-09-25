using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The 5 randomly-numbered index cards represent an unsorted array, and the 5 blank index cards will contain the sorted array.
             * 
             * Put the unsorted pile to your left, and place the 5 blank sheets of paper in a pile to your right.  
             * 
             * Submit a Word ddoc which has in English (not computer code) the exact steps to sort and copy the numbers in ascending order 
             * from the pile on the left to the pile on the right, without changing the order of the unsorted array.
             * 
             * Any time you touch any piece of paper, you must have an instruction written down
             *
             */



            int[] unsorted = new int[] { 51, 43, 67, 29, 92 };
            int[] sorted = new int[];

            //Console.WriteLine("unsorted: ");
            for(int i = 1; i <= unsorted.Length; i++)
            {
                for (int j = 0; j < unsorted.Length-1; j++)
                {
                    if (unsorted[j] > unsorted[j+1])
                    {
                        int temp = unsorted[j];
                        Console.WriteLine("temp: " + temp);
                        Console.WriteLine("unsorted[j]: " + unsorted[j]);

                        unsorted[j] = unsorted[j + 1];
                        Console.WriteLine("unsorted[j]: " + unsorted[j]);
                        Console.WriteLine("unsorted[j+1]: " + unsorted[j+1]);

                        unsorted[j + 1] = temp;
                        Console.WriteLine("unsorted[j+1]: " + unsorted[j + 1]);
                        Console.WriteLine("temp: " + temp);

                        Console.WriteLine("\n");

                        //sorted[j] = unsorted[j];

                    }
                }
            }

            Console.Write("Sorted array: ");
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
        }
    }
}

