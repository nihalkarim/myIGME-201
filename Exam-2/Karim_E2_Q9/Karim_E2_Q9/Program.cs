using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage
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
            Beverage[] drinks = new Beverage[2];
            drinks[0] = new Tea();
            drinks[1] = new Coffee();

            MakeColdDrink(drinks[1]);
            MakeColdDrink(drinks[0]);

            //another option:
            //Tea myTea = new Tea();
            //Coffee myCoffee = new Coffee();
            //MakeColdDrink(myTea);
            //MakeColdDrink(myCoffee);
        }

        static void MakeColdDrink(object obj)
        {
            ICold drink = (ICold)obj;
            drink.ChooseKind();

            if(obj is Tea)
            {
                ICold icedTea = (ICold)obj;
                icedTea.AddIce();
                icedTea.UseStraw();

                Tea tea = (Tea)obj;
                tea.kind = "green";
                Console.WriteLine($"Made delicious {tea.kind} iced tea!\n");
            }
            else if (obj is Coffee)
            {
                ICold icedCoffee = (ICold)obj;
                icedCoffee.AddIce();
                icedCoffee.UseStraw();

                Coffee coffee = (Coffee)obj;
                coffee.origin = "Guatemala";
                Console.WriteLine($"Iced coffee made with beans from {coffee.origin}\n");
            }

        }
    }

    public abstract class Beverage
    {
        public double temperature;
        public string size;
        public bool homemade;
        private double caffeineAmount;

        public double CaffeineAmount
        {
            get { return this.caffeineAmount; }
        }

        public abstract void Brew();

        public virtual void GetPrice() { }
    }

    interface IHot
    {
        public void ChooseKind();
        public void BoilWater();
        public void GetMug();
    }

    interface ICold
    {
        public void ChooseKind();
        public void AddIce();
        public bool UseStraw();
    }

    public class Tea : Beverage, IHot, ICold
    {
        public string kind;
        public bool looseleaf;

        public override void Brew()
        {
            Console.WriteLine("brewing up some tea!");
        }

        public override void GetPrice()
        {
            base.GetPrice();
        }

        public void ChooseKind() {
            Console.WriteLine("choosing tea kind from black, green, white, and oolong");
        }

        public void BoilWater() {
            Console.WriteLine("make sure the water is hot!");
        }

        public void GetMug() {
            Console.WriteLine("you can choose a mug based on your mood");
        }

        public void AddIce() {
            Console.WriteLine("add ice to your cup for refreshing iced tea");
        }

        public bool UseStraw() { return true; }
    }

    public class Coffee : Beverage, IHot, ICold
    {
        public string roast;
        public string origin;

        public override void Brew()
        {
            Console.WriteLine("let's brew some coffee :D");
        }

        public override void GetPrice()
        {
            base.GetPrice();
        }

        public void ChooseKind() {
            Console.WriteLine("our roasts include dark, medium, and blonde");
        }

        public void BoilWater() {
            Console.WriteLine("you might need to boil some water depending on how you're making your coffee");
        }

        public void GetMug() {
            Console.WriteLine("choose a regular or travel mug for your coffee");
        }
        public void AddIce() {
            Console.WriteLine("iced coffee is the best (even in 30º weather)");
        }

        public bool UseStraw() { return true; }
    }
}
