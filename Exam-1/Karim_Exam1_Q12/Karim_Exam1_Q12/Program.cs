using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose: Prompt the user for their name. Give them a raise and congratulate them if their name is Nihal.
     * Restrictions: none
     */
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            // prompt the user's name
            Console.Write("What's your name? ");
            sName = Console.ReadLine();

            // format name so it starts with a capital letter
            sName = char.ToUpper(sName[0]) + sName.Substring(1);

            // call GiveRaise function
            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine($"Congratulations {sName}, you got a raise! \nYour new salary is {dSalary.ToString("C2")}!");
            } else
            {
                Console.WriteLine($"Hello {sName}. Your salary is {dSalary}!");
            }

        }

        static bool GiveRaise(string name, ref double salary)
        {
            // if the user's name is nihal, increase their salary by 19,999.99
            if(name.ToLower() == "nihal")
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}