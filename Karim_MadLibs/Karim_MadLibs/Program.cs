using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /* 
     * Author: Nihal Karim
     * Class name: Program
     * Purpose: to create a Mad Libs game that allows users to pick from a sset of stories and shows the final story with their inputs
     * Restrictions: none
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            
            int numLibs = 0; 
            int counter = 0;
            int choice = 0; // user's story choice

            string finalStory = ""; // final displayed story
            string placeholderWord = ""; // user input



            // input file declaration
            StreamReader readFile;

            // open the template file to count how many Mad Libs it contains
            readFile = new StreamReader("MadLibsTemplate.txt");

            string line = null;
            while((line = readFile.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close file
            readFile.Close();



            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            readFile = new StreamReader("MadLibsTemplate.txt");

            line = null;
            while ((line = readFile.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[counter] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[counter] = madLibs[counter].Replace("\\n", "\n");

                ++counter;
            }
            // close file
            readFile.Close();



            // prompt the user for which Mad Lib they want to play (choice)
            Console.Write("Which Mad Lib do you want to play? Pick a story 1-6 --> ");
            choice = Convert.ToInt32(Console.ReadLine());

            // split the Mad Lib into separate words
            string[] words = madLibs[choice-1].Split(' ');

            foreach(string word in words)
            {
                // if word is a placeholder
                if (word[0]  == '{')
                {
                    // remove brackets, underscores, commas, etc from displaying
                    placeholderWord = word.Replace("{", "").Replace("}", "").Replace("_", " ").Replace(",", "");

                    // prompt the user for the replacement
                    // convert to lower case so it looks cleaner
                    Console.Write("Input a {0}: ", placeholderWord.ToLower());

                    // and append the user response to the result string
                    finalStory += Console.ReadLine() + " ";
                }
                else
                {
                    finalStory += word + " ";
                }
            }

            Console.WriteLine(finalStory);

        }
    }
}