using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            
            //fake names and birthdays
            friendBirthdays.Add("Bobby", new DateTime(1999, 12, 25));
            friendBirthdays.Add("Michelle", new DateTime(2000, 11, 20));
            friendBirthdays.Add("Lexi", new DateTime(2001, 10, 15));
            friendBirthdays.Add("Alex", new DateTime(2002, 8, 12));


            foreach (KeyValuePair<string, DateTime> kvp in friendBirthdays)
            {
                Console.WriteLine($"{kvp.Key}'s birthday is on {kvp.Value.ToString("MM/dd/yyyy")}");
            }

        }
    }
}