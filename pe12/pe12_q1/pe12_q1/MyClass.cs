using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MyDerivedClass = pe12_q1.MyDerivedClass;

namespace Q1
{
    /* Author: Nihal Karim
     * Name: Program
     */
    static class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derived = new MyDerivedClass();
            derived.GetString();
        }
    }


    public class MyClass
    {
        private string myString = "myString in MyClass";

        public string MyString
        {
            set
            {
                this.myString = value;
            }
        }

        public virtual string GetString() {
            return this.myString;
        }
    }
}