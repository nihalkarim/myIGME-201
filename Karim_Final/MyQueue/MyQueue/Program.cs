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
    static class MyQueue
    {
        static List<int> myQueueList = new List<int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Example run to test the Enqueue(int n), Dequeue(), and Peek() methods on the List<int>\n\n");

            //add numbers
            for (int i = 10; i > 0; i--)
            {
                myQueueList.Add(i);
            }

            //original
            Console.Write("myStackList: {");
            for (int i = 0; i < myQueueList.Count; i++)
            {
                Console.Write($"{myQueueList[i]}, ");
            }
            Console.Write("}\n");



            Enqueue(324);
            Enqueue(93);
            Enqueue(70);
            Console.Write("myStackList: {");
            for (int i = 0; i < myQueueList.Count; i++)
            {
                Console.Write($"{myQueueList[i]}, ");
            }
            Console.Write("}\n");



            Dequeue();
            Console.Write("myStackList: {");
            for (int i = 0; i < myQueueList.Count; i++)
            {
                Console.Write($"{myQueueList[i]}, ");
            }
            Console.Write("}\n");



            Dequeue();
            Dequeue();
            Dequeue();
            Console.Write("myStackList: {");
            for (int i = 0; i < myQueueList.Count; i++)
            {
                Console.Write($"{myQueueList[i]}, ");
            }
            Console.Write("}\n");

            Peek();
        }

        static void Enqueue(int n)
        {
            myQueueList.Add(n);
        }

        static int Dequeue()
        {
            int dequeued = myQueueList[myQueueList.Count - 1];
            Console.WriteLine(dequeued);
            myQueueList.RemoveAt(myQueueList.Count - 1);
            return dequeued;
        }

        static int Peek()
        {
            Console.WriteLine(myQueueList[0]);
            return myQueueList[0];
        }
    }
}