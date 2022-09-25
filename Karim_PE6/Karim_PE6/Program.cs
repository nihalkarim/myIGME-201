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
            Random rand = new Random();

            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            // print the number to the console [for testing purposes]
            Console.WriteLine(randomNumber);

            Console.WriteLine("Let's play a number guessing game! You have 8 tries to guess the number 0-100.");
            Console.WriteLine("You will know if your guess is correct, too low, or too high. If your guess is out of range, you'll have to guess again.");

            int i = 1; // for-loop counter
            bool validInput = false; // boolean value to check if the input is valid

            // loop through giving the player 8 tries to guess the number
            for (i = 1; i <=8; i++)
            {
                int userGuess = 0;
                while (!validInput)
                {
                    // ask for the user to guess a number
                    Console.Write("Turn #" + i + ". Enter a number 0-100: ");

                    // read the user's input into a string then convert to an int 32
                    // use a try-catch to make sure their guess is an integer
                    try
                    {
                        string userGuessString = Console.ReadLine();
                        userGuess = Convert.ToInt32(userGuessString);
                        
                    }
                    catch
                    {
                        Console.WriteLine("Not an integer, try again.");
                        continue;
                    }
                    

                    // the input is valid if it's an int 0-100
                    if (userGuess >= 0 && userGuess <= 100)
                    {
                        validInput = true;
                    }
                    else
                    {
                        // prompt the user to guesss again if their guess is invalid
                        Console.WriteLine("You need to enter an integer 0-100. Guess again.");
                    }

                }

                // let the user know if their guess is correct, too low, or too high
                if (userGuess == randomNumber)
                {
                    Console.WriteLine("Your guess is right, congratulations! It took you " + i + " tries! :)");
                    break;
                }
                else if (userGuess > randomNumber)
                {
                    Console.WriteLine("Too high :(");
                }
                else if (userGuess < randomNumber)
                {
                    Console.WriteLine("Too low :(");
                }

                validInput = false;
            }

            // if the user doesn't get it, let them know the correct answer
            if(i == 9)
            {
                Console.WriteLine("You ran out of guesses. The correct anwer was " + randomNumber);
            }
        }
    }
}

