using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloWorld
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;

            public employee(string name, double salary)
            {
                this.sName = name;
                this.dSalary = salary;
            }
        }

        static void Main(string[] args)
        {
            employee employeeStruct = new employee("", 30000);

            // prompt the user's name
            Console.Write("What's your name? ");
            employeeStruct.sName = "nihal";//Console.ReadLine();

            // format name so it starts with a capital letter
            employeeStruct.sName = char.ToUpper(employeeStruct.sName[0]) + employeeStruct.sName.Substring(1);

            bool raise = GiveRaise(employeeStruct);
            // call GiveRaise function
            if (raise)
            {
                Console.WriteLine($"Congratulations {employeeStruct.sName}, you got a raise! \nYour new salary is {employeeStruct.dSalary.ToString("C2")}!");
            }
            else
            {
                Console.WriteLine($"Hello {employeeStruct.sName}. Your salary is {employeeStruct.dSalary}!");
            }

        }

        static bool GiveRaise(employee user)
        {
            // if the user's name is nihal, increase their salary by 19,999.99
            if (user.sName.ToLower() == "nihal")
            {
                user.dSalary += 19999.99;
                Console.WriteLine(user.dSalary);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}