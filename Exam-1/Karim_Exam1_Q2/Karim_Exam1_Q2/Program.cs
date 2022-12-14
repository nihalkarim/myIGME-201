using System;

namespace WordSort
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose: to prompt the user to enter a sentence and choose if they want it to be sorted in an ascending or descending order
     * Restrictions: none!
     */
    class Program
    {
        // the definition of the delegate function data type
        delegate string sortingFunction(string[] a);

        static void Main(string[] args)
        {
            // declare the unsorted and sorted arrays
            string[] unsorted;
            string[] sorted;

            // declare the delegate variable which will point to the function to be called
            sortingFunction findHiLow;

        // a label to allow us to easily loop back to the start if there are input issues
        start:
            Console.WriteLine("Enter a sentence:");

            // read the sentence
            string inputSentence = Console.ReadLine();

            // split the string into the an array of strings which are the individual words
            string[] sentArray = inputSentence.Split(' ');

            // initialize the size of the unsorted array to 0
            int unsortedLength = 0;

            // a double used for parsing the current array element
            //double nThisNumber;
            string sThisNum;

            // iterate through the array of word strings
            foreach (string word in sentArray)
            {
                // if the length of this string is 0 (ie. they typed 2 spaces in a row)
                if (word.Length == 0)
                {
                    // skip it
                    continue;
                }

                ++unsortedLength;
            }

            // now we know how many unsorted words there are
            // allocate the size of the unsorted array
            unsorted = new string[unsortedLength];

            // reset unsortedLength back to 0 to use as the index to store the words in the unsorted array
            unsortedLength = 0;
            foreach (string word in sentArray)
            {
                // still skip the blank strings
                if (word.Length == 0)
                {
                    continue;
                }

                // store the value into the array
                unsorted[unsortedLength] = word;

                // increment the array index
                unsortedLength++;
            }

            // allocate the size of the sorted array
            sorted = new string[unsortedLength];

            // prompt for <a>scending or <d>escending
            Console.Write("Ascending or Descending? ");
            string sDirection = Console.ReadLine();

            if (sDirection.ToLower().StartsWith("a"))
            {
                findHiLow = new sortingFunction(FindLowestValue);
            }
            else
            {
                findHiLow = new sortingFunction(FindHighestValue);
            }

            // start the sorted length at 0 to use as sorted index element
            int nSortedLength = 0;

            // while there are unsorted values to sort
            while (unsorted.Length > 0)
            {
                // store the lowest or highest unsorted value as the next sorted value
                sorted[nSortedLength] = findHiLow(unsorted);

                // remove the current sorted value
                RemoveUnsortedValue(sorted[nSortedLength], ref unsorted);

                // increment the number of values in the sorted array
                ++nSortedLength;
            }

            // write the sorted array of words
            Console.WriteLine("The sorted list is: ");
            foreach (string word in sorted)
            {
                Console.Write($"{word} ");
            }

            Console.WriteLine();
        }


        // find the lowest value in the array of strings
        static string FindLowestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string currWord in array)
            {
                //if the current value is less than the saved lowest value
                if (currWord.CompareTo(returnVal) < 0)
                {
                    // save this as the lowest value
                    returnVal = currWord;
                }
            }

            // return the lowest value
            return (returnVal);
        }


        // find the lowest value in the array of strings
        static string FindHighestValue(string[] array)
        {
            // define return value
            string returnVal;

            // initialize to the first element in the array
            // (we must initialize to an array element)
            returnVal = array[0];

            // loop through the array
            foreach (string currWord in array)
            {
                // if the current value is greater than the saved highest value
                if (currWord.CompareTo(returnVal) > 0)
                {
                    // save this as the lowest value
                    returnVal = currWord;
                }
            }

            // return the highest value
            return (returnVal);
        }


        // remove the first instance of a value from an array
        static void RemoveUnsortedValue(string removeValue, ref string[] array)
        {
            // allocate a new array to hold 1 less value than the source array
            string[] newArray = new string[array.Length - 1];

            // we need a separate counter to index into the new array, 
            // since we are skipping a value in the source array
            int dest = 0;

            // the same value may occur multiple times in the array, so skip subsequent occurrences
            bool bAlreadyRemoved = false;

            // iterate through the source array
            foreach (string srcNumber in array)
            {
                // if this is the word to be removed and we didn't remove it yet
                if (srcNumber == removeValue && !bAlreadyRemoved)
                {
                    // set the flag that it was removed
                    bAlreadyRemoved = true;

                    // and skip it (ie. do not add it to the new array)
                    continue;
                }

                // insert the source number into the new array
                newArray[dest] = srcNumber;

                // increment the new array index to insert the next number
                ++dest;
            }

            // set the ref array equal to the new array, which has the target number removed
            // this changes the variable in the calling function (aUnsorted in this case)
            array = newArray;
        }
    }
}
