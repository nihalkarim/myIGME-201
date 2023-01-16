using System;
using System.Timers;


namespace Memory
{
    class Program
    {
        // declare "global" class-scoped variables
        // which need to be accessed by all members of the class

        // bTimeOut boolean
        static bool bTimeOut = false;

        // timeOutTimer Timer
        static Timer timeOutTimer;

        static void Main(string[] args)
        {
            // declare the local variables for the game

        start:

            // a displayString which holds the code sequence
            string displayString = "";

            // initialize timeout flag
            bTimeOut = false;

            // a counter integer which loops through the code sequence
            int counter = 0;

            // the rand Random number generator object
            Random rand;

            // create the random number generator
            rand = new Random();

            // clear the screen
            Console.Clear();

            // while the user has not timed out
            while( !bTimeOut )
            {
                // append a random letter to displayString
                // we need to cast as char since rand.Next() returns int, so 'A' + int = int
                displayString += (char)('A' + rand.Next(0, 26));

                // use counter to loop through displayString
                for(counter = 0; counter < displayString.Length; ++counter)
                {
                    // write displayString[counter] to the console
                    Console.Write(displayString[counter]);

                    // delay for 500 milliseconds
                    System.Threading.Thread.Sleep(500);
                }

                // clear the Console (hide the answer)
                Console.Clear();

                // create timeOutTimer with an elapsed time of displayString.Length * 500ms + 1sec
                // 0.5 seconds per character in the code + 1 second "buffer"
                timeOutTimer = new Timer(displayString.Length * 500 + 1000);

                /*
                // Timer calls the Timer.Elapsed event handler when the time elapses
                // The Timer.Elapsed event handler uses a delegate function with the following signature:
                        public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);

                // we want TimesUp() to be called when the timer elapses

                // we can assign our delegate function variable in several steps like we did before
                ElapsedEventHandler elapsedEventHandler;
                elapsedEventHandler = new ElapsedEventHandler(TimesUp);

                // add the TimesUp() delegate function to the timeOutTimer.Elapsed event handler
                timeOutTimer.Elapsed += elapsedEventHandler;
                */

                // or we can just do that in one line
                // add the TimesUp() delegate function to the timeOutTimer.Elapsed event handler
                // TimesUp() will be called when the Timer elapses
                timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp);

                // start the timeOutTimer
                timeOutTimer.Start();

                // read the user's attempt
                string sAnswer = Console.ReadLine();

                // stop the timeOutTimer
                timeOutTimer.Stop();

                // if they entered the correct code sequence and they didn't timeout
                if(sAnswer.ToUpper() == displayString && !bTimeOut)
                {
                    // congratulate and write their current score
                    Console.WriteLine($"Well Done!  Your score is {displayString.Length}.");
                }
                else
                {
                    // otherwise display the correct code sequence and their final score
                    Console.WriteLine($"Wrong!  The code is: {displayString}.  Your score is {displayString.Length - 1}.");

                    // set bTimeOut to true to exit the game loop
                    bTimeOut = true;
                }
            }

            Console.Write("Press Enter to Play Again");
            Console.ReadLine();

            goto start;
        }


        static void TimesUp(object source, ElapsedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Your time is up!");

            // set the bTimeOut flag to quit the game
            bTimeOut = true;

            // stop the timeOutTimer
            timeOutTimer.Stop();
        }
    }
}