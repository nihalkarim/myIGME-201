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
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //    }
    //}

    public class Zoo
    {
        private string name;
        public string Name
        {
            get
            {
                
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
    }


    public sealed class Circus
    {
        public string name;
    }


    static class Program
    {
        static void Main()
        {

            Circus myCircus = new Circus();
            Console.WriteLine(myCircus);
        }
    }

}
