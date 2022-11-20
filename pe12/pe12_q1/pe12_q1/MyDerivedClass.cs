using System;
using Q1;

namespace pe12_q1
{
    public class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            Console.WriteLine(base.GetString() + " (output from the derived class)");
            return base.GetString() + " (output from the derived class)";
        }

       
            
       /* Create a console application and derive the public class MyDerivedClass from MyClass.
        * Override the GetString() method to return the string from the base class by using the base implementation of the method,
        * but append the text " (output from the derived class)" to the returned string.
        * Have the Main() instantiate a MyDerivedClass object and output the string returned by the GetString() method.
        * 
        * 
        * Remember how we could use base to call the base constructor.  
        * For example in the Shape example:
        *      public Rectangle(double h, double w) : base(h,w)
        * The Rectangle constructor calls the constructor in the parent class by using base.
        * 
        * 
        * In the same way, for any derived class, you can call an accessible method in a parent class by using base.MethodName(), even if the method name is the same and being    
        * overridden.
        */
    }
}

