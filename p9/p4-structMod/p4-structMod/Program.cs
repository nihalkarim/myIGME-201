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
        struct order
        {
            public string itemName;
            public int unitCount;
            public double unitCost;

            public double TotalPrice()
            {
                double total = this.unitCount * this.unitCost;
                return total;
            }

            public string PriceFormat()
            {
                return "Order Information: " + this.unitCount + " \'" + this.itemName + "\' items at $" + this.unitCost + " each, total cost $" + this.TotalPrice() + ".";
            }
        }

        static void Main(string[] args)
        {
            order receipt = new order();

            receipt.unitCount = 20;
            receipt.unitCost = 5;
            receipt.itemName = "books";

            Console.WriteLine($"Count: {receipt.unitCount}\nCost: {receipt.unitCost}");

            receipt.TotalPrice();
            Console.WriteLine(receipt.TotalPrice());

            receipt.PriceFormat();
            Console.WriteLine(receipt.PriceFormat());
        }

    }
}
