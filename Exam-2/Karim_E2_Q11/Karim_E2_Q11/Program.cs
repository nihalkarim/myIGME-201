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

        public class MyClass
        {
            public int myInt;

            public MyClass(int nVal)
            {
                this.myInt += nVal;
            }
        }

        public class MyDerivedClass : MyClass
        {
            public MyDerivedClass(int nVal) : base(nVal)
            {
                this.myInt = (this.myInt + 2) * 4;
            }
        }



        static void Main(string[] args)
        {
            MyDerivedClass myObj = new MyDerivedClass(42);
        }
    }
}
