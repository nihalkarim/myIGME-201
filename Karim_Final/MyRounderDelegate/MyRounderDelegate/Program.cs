using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DelegateFunction.Program;

namespace DelegateFunction
{
    class Program
    {
        public delegate double MyRounder(double d, int n);
        static void Main(string[] args)
        {
            // create variable of delegate function type 
            MyRounder myRounder;

            // your code here
            myRounder = new MyRounder(delegate (double d, int n) { return Math.Round(d, n); });

            myRounder = delegate (double d, int n) { return Math.Round(d, n); };

            myRounder = (double d, int n) => { return Math.Round(d, n); };

            myRounder = (d, n) => { return Math.Round(d, n); };

            myRounder += new MyRounder((double d, int n) => { return Math.Round(d, n); });

            myRounder += delegate (double d, int n) { return Math.Round(d, n); };

            myRounder += (double d, int n) => { return Math.Round(d, n); };

            myRounder += (d, n) => { return Math.Round(d, n); };

            myRounder += (d, n) => Math.Round(d, n);

            myRounder += Math.Round;

            myRounder += new MyRounder(Math.Round);

        }
    }
}