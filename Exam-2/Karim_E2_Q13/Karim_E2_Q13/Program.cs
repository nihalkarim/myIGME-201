using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowCoy
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose: make a shallow copy of objectA into objectB
     * Restrictions: none
     */
    static class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            MyClass objectB;

            objectB = (MyClass)objectA.GetCopy();
        }
    }

    public class MyClass
    {
        public object GetCopy()
        {
            return MemberwiseClone();
        }
    }
}
