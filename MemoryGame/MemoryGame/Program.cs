using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Timers;
using Timer = System.Timers.Timer;

namespace MemoryGame
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static internal class Program
    {
        static bool timeOut = false;
        static Timer timeoutTimer;

        static void MyIncrementer(Action d)
        {
            d();
        }

        static void Main(string[] args)
        {
            // template date type --> anonymous delegate type
            {
                int i = 0;
                int j = 0;

                //anon delegate 'inrement' pointing to an anon method
                // Action = dleegate method that does not return anything
                Action increment = delegate ()
                {
                    ++i;
                    ++j;
                };

                Action<int, int> adder = (int x, int y) =>
                {
                    i += x;
                    j += y;
                };

                Func<int> fnIncrement = delegate ()
                {
                    ++i;
                    ++j;
                    return ( i + j);
                };

                Func<int, int, int> fnAdder = (int x, int y) =>
                {
                    i += x;
                    j += y;
                    return (i + j);
                };

                MyIncrementer(increment);

                increment();
                increment();
            }

            start: 
            string displayString = "";

            Random rand = new Random();

            Console.Clear();

            while(!timeOut)
            {
                displayString += (char)('A' + rand.Next(0, 26)); // have to cast as char bc rand will return an int

                foreach(char c in displayString)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(500);
                }

                Console.Clear();

                timeoutTimer = new Timer(displayString.Length * 500 + 1000);

                ElapsedEventHandler elapsedEventHandler;
                elapsedEventHandler = new ElapsedEventHandler(TimeUp);
                timeoutTimer.Elapsed += elapsedEventHandler;

                //timeoutTimer.Elapsed += TimeUp;

                // anonymous function
                timeoutTimer.Elapsed += delegate (object sender, ElapsedEventArgs e)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Your timeis up!");
                        timeOut = true;
                        timeoutTimer.Stop();
                    };

                // lambda function
                timeoutTimer.Elapsed += //(object sender, ElapsedEventArgs e) =>
                (sender, e) => { Console.WriteLine("");
                                 Console.WriteLine("Your timeis up!");
                                 timeOut = true;
                                 timeoutTimer.Stop();
                               };


                string answer = null;
                answer = Console.ReadLine();

                timeoutTimer.Stop();

                if( answer.ToUpper() == displayString && !timeOut)
                {
                    Console.WriteLine("Well done! Your current score is {0}", displayString.Length);
                }
                else
                {
                    Console.WriteLine("you suck. the correct answer was {0}.\nYour final score is: {1}", displayString, displayString.Length - 1);
                    timeOut = true;
                }
            }

            Console.WriteLine("Press enter to play again.");
            Console.ReadLine();

            goto start;

        }


        static void TimeUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("Your timeis up!");
            timeOut = true;
            timeoutTimer.Stop();
        }


        static void TimeUp2(object sender, ElapsedEventArgs e)
        {

        }

    }

}
