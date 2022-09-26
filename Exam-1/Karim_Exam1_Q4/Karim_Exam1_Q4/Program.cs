using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Timers;

namespace HelloWorld
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static internal class Program
    {
        //private static System.Timers.Timer aTimer;

        static bool bTimeOut = false;

        static System.Timers.Timer timeOutTimer;


        static void Main(string[] args)
        {
            int questionNum = 0;
            int question = 0;
            string[] questions = new string[] { "What is your favourite colour?", "What is the answer to life, the universe, and everything?", "What is the airspeed velocity of an unladen swallow?" };
            string[] answers = new string[] { "black", "42", "What do you mean? African or European swallow?" };
            string userAnswer = "";
            string playAgain = "";
            bool stop = false;
            bool isValid = false;

            // timer
            System.Timers.Timer timeOut = new System.Timers.Timer(5000);


        start:
            // prompt user for question
            while (!isValid)
            {
                try
                {
                    Console.Write("Choose your question (1-3): ");
                    questionNum = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("You have 5 seconds to answer the following question.");
                    if (questionNum > 0 && questionNum < 4)
                    {
                        isValid = true;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number between 1-3.");
                }
            }

            while (!stop)
            {
                question = questionNum;
                switch (question)
                {
                    case 1:
                        Console.WriteLine(questions[0]);
                        userAnswer = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(questions[1]);
                        userAnswer = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine(questions[2]);
                        userAnswer = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please enter an integer 1-3.");
                        break;
                }
                timeOutTimer = new System.Timers.Timer(5000);

                if (question == 1)
                {
                    if (userAnswer.ToLower() == answers[0])
                    {
                        Console.WriteLine("Well done!");

                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The answer is: {answers[0]}");
                    }
                }
                else if (question == 2)
                {
                    if (userAnswer.ToLower() == answers[1])
                    {
                        Console.WriteLine("Well done!");

                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The answer is: {answers[1]}");
                    }

                }
                else
                {
                    if (userAnswer.ToLower() == answers[2])
                    {
                        Console.WriteLine("Well done!");

                    }
                    else
                    {
                        Console.WriteLine($"Wrong! The answer is: {answers[2]}");
                    }
                }

                Console.Write("Play again?\t");
                playAgain = Console.ReadLine();
                if (playAgain.ToLower().StartsWith("y"))
                {
                    stop = true;
                    goto start;
                }
            }


            ElapsedEventHandler elapsedEventHandler = null;

            elapsedEventHandler = new ElapsedEventHandler(TimesUp);

            timeOutTimer.Elapsed += elapsedEventHandler;
            timeOutTimer.Elapsed += TimesUp;

        }


        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("");
            Console.WriteLine("Time's up!");
            Console.WriteLine($"Wrong! The answer is: xxxxx");
            Console.WriteLine("Please press enter.");
            bTimeOut = true;
            timeOutTimer.Stop();
        }
    }
}
