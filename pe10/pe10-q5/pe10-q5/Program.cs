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

        }

        /* Write some code for a function that would accept either of the two cup      
         * objects in the above example as a parameter. The function should call 
         * the AddMilk(), Drink(), and Wash() methods for any cup object it is 
         * passed.
         */

        static void Cups(HotDrink cup)
        {
            cup.AddMilk();
            cup.Drink();

            ICup iCup = (ICup)cup
            iCup.Wash();
        }
    }

    abstract class HotDrink
    {
        public void Drink() { }
        public void AddMilk() { }
        public void AddSugar() { }

        public Milk {}
    public Sugar {};
    }
}