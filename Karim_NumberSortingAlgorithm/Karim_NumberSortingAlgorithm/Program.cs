using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal;

namespace HelloWorld
{
    static internal class Program
    {
        static void Main(string[] args)
        {
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



        static void ArraySort()
        {
            double[] unsorted;
            double[] sorted;

            start:

            Console.WriteLine("Enter a list of space separated numbers:");
            string numString = Console.ReadLine();
            string[] numbers = numString.Split(' ');

            int unsortedLength = 0;
            double currNum = 0;

            foreach(string currNumStr in numbers)
            {
                if(currNumStr.Length == 0)
                {
                    continue;
                }

                try
                {
                    currNum = double.Parse(currNumStr);
                    ++unsortedLength;
                } catch
                {
                    Console.WriteLine($"Number #{unsortedLength + 1} is not a valid number.");
                    goto start;
                }
            }

            unsorted = new double[unsortedLength];

            unsortedLength = 0;

            foreach (string currNumStr in numbers)
            {
                if (currNumStr.Length == 0)
                {
                    continue;
                }

                currNum = double.Parse(currNumStr);
                unsorted[unsortedLength] = currNum;
                ++unsortedLength;
            }

            sorted = new double[unsortedLength];

            int sortedLength = 0;
            while(unsorted.Length > 0)
            {
                sorted[sortedLength] = FindLowestValue(unsorted);
                RemoveUnsortedValue(sorted[sortedLength], ref unsorted);
                ++sortedLength;
            }
        }


        static double FindLowestValue(double[] array)
        {
            double returnVal = array[0];

            foreach(double num in array)
            {
                if(num < returnVal)
                {
                    returnVal = num;
                }
            }
            return returnVal;
        }

        static void RemoveUnsortedValue(double removeVal, ref double[] array) 
        {
            //code in github
        }
    }

}

