using System;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Channels;
//using Internal;

namespace FavoriteColorAndNumber
{
    //Class: Program
    //Author: Nihal Karim
    //Purpose: Console Read/Writw and Exception-handling exercise
    //Restrictions: None
    static internal class Program
    {
        static void PrintMyColor(string colorString)
        {
            colorString += " is your fav color.";
            Console.WriteLine(colorString);
        }

        static void PrintMyColorByReference(ref string colorString)
        {
            colorString += " is your fav color.";
            Console.WriteLine(colorString);
        }

        //Method: Main
        //Purpose:
        //Restrictions: None
        static void Main(string[] args)
        {
            string sFavColor = null;
            sFavColor = "";
            sFavColor.ToUpper();
            sFavColor = sFavColor.ToUpper();
            int nFavNumber = null;

            // prompt the user for their favorite color
            Console.Write("Enter your favourite colour: ");

            // get the user's input and store it in a variable
            //Console.ReadLine(); ==> reads line but doesn't save it!
            sFavColor = Console.ReadLine();


            //pass by var
            PrintMyColor(sFavColor);
            Console.WriteLine(sFavColor);
            //passs by ref
            PrintMyColorByReference(ref sFavColor);
            Console.WriteLine(sFavColor);


            // prompt the user for their favorite number
            Console.Write("Enter your favourite number:\t");

            string sNumber = "";
            do
            {
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nFavNumber));


            // validate that the user entered a valid number
            // do while loop will execute at least once
            do
            {
                try
                {
                    // get the user's input and store it in a variable
                    nFavNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Please enter an integer.\t");
                }
            }
            while (nFavNumber == null);

            // not guaranteed to execute
            while(nFavNumber == null)
            {
                try
                {
                    // get the user's input and store it in a variable
                    nFavNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Please enter an integer.\t");
                }
            }
          

            // change the output text color to match their favorite color
            switch(sFavColor.ToLower())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            // output their favorite color the number of times as their favorite number
            for(int i = 0; i < nFavNumber; ++i)
            {
                //Console.Write("Your favourite colour is " + sFavColor +"!");
                Console.Write($"Your favourite colour is {sFavColor}! \n"); //string interpolation. add $. code block w its own scope
                //Console.Write("Your favourite colour is {0}{1}", sFavColor, "!"); //string substitution
            }

        }
    }
}