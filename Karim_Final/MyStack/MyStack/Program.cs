using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam
{
    /* Author: Nihal Karim
     * Name: Program
     * Purpose:
     * Restrictions:
     */
    static class MyStack
    {
        static List<int> myStackList = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Example run to test the Push(int n), Pop(), and Peek() methods on the List<int>\n\n");

            //add numbers
            for (int i = 1; i < 11; i++)
            {
                myStackList.Add(i);
            }

            //original
            Console.Write("myStackList: {");
            for (int i = 0; i < myStackList.Count; i++)
            {
                Console.Write($"{myStackList[i]}, ");
            }
            Console.Write("}\n");

            //add more numbers
            Push(25);
            Push(40);
            Push(53);
            Console.Write(">myStackList: {");
            for (int i = 0; i < myStackList.Count; i++)
            {
                Console.Write($"{myStackList[i]}, ");
            }
            Console.Write("}\n");

            //remove some numbers
            Pop();
            Pop();
            Pop();
            Pop();
            Pop();
            Console.Write(">>myStackList: {");
            for (int i = 0; i < myStackList.Count; i++)
            {
                Console.Write($"{myStackList[i]}, ");
            }
            Console.Write("}\n");

            //check top number
            Peek();
        }

        static void Push(int n)
        {
            myStackList.Insert(0, n);
        }

        static int Pop()
        {
            int popped = myStackList[0];
            myStackList.RemoveAt(0);
            Console.WriteLine(popped);
            return popped;
        }

        static int Peek()
        {
            Console.WriteLine(myStackList[0]);
            return myStackList[0];
        }
    }
}