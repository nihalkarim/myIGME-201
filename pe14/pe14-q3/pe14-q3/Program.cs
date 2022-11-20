using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PE14_q2_q3
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class Program
    {
        // Write a console application which has a Main() and a method called MyMethod() with the following signature:
        //      public static void MyMethod(object myObject)
        // 
        // Using the class and interface definitions you created in #2, create objects of both classes and call MyMethod with each object.  
        // The code in MyMethod must use the interface to call the common method name.
        static void Main(string[] args)
        {
            Chess chess = new Chess();
            Lacrosse lacrosse = new Lacrosse();

            MyMethod(chess);
            MyMethod(lacrosse);
        }

        public static void MyMethod(object myObject)
        {
            iSport sport = (iSport)myObject;
            sport.Play();
        }
    }

    // Create 2 classes and an interface.
    // The interface should define a method, and both classes must inherit the interface and implement the method defined by the interface.
    // The class-implemented methods must have different code in their code blocks (eg. Console.WriteLine() different strings).
    interface iSport
    {
        void Play();
    }

    public class Chess: iSport
    {
        public void Play()
        {
            Console.WriteLine("chess is a sport");
        }
    }

    public class Lacrosse : iSport
    {
        public void Play()
        {
            Console.WriteLine("i used to be a lacrosse goalie");
        }
    }
}
