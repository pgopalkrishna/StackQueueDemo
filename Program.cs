using System;
using System.Collections;

namespace StackQueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            Console.WriteLine("=====================StackDemo=====================");
            Stack s = new Stack();
            for (int i = 1; i <= 10; i++)
            {
                s.Push(i);
            }
            Console.WriteLine("S=>");
            foreach (var item in s.ToArray())
            {
                Console.WriteLine(item);
            }
            Stack Cloned_Stack = new Stack();
            Cloned_Stack = (Stack)s.Clone();
            Console.WriteLine("Printing Stack with peek :S=>");
            Console.WriteLine(s.Peek());
            Console.WriteLine("Printing Stack with pop : S=>");
            PrintStack(s);
            Console.WriteLine("Printing clonned Stack  : Cloned_Stack =>");
            PrintStack(Cloned_Stack);
            #endregion
            #region Queue
            Console.WriteLine("=====================QueueDemo=====================");
            Queue q1 = new Queue();
            for (int i = 1; i <= 10; i++)
            {
                q1.Enqueue(i);
            }
            Console.WriteLine("q1=>");
            foreach (var item in q1.ToArray())
            {
                Console.WriteLine(item);
            }
            Queue Cloned_q1 = new Queue();
            Cloned_q1 = (Queue)q1.Clone();
            Console.WriteLine("Printing Queue with peek :q1=>");
            Console.WriteLine(q1.Peek());
            //PrintQueue(q1, false);
            Console.WriteLine("Printing Queue with Dequeue : q1=>");
            PrintQueue(q1);
            Console.WriteLine("Printing clonned Queue  : Cloned_q1 =>");
            PrintQueue(Cloned_q1);
            #endregion
        }
        public static void PrintStack(Stack s)
        {
            while (s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }
        }
        public static void PrintQueue(Queue q, bool retainFlag = true)
        {
            if (retainFlag)
                while (q.Count > 0)
                {
                    Console.WriteLine(q.Dequeue());
                }
            for (int i = 1; i <= q.Count; i++)
            {
                Console.WriteLine(q.Peek());
            }
        }
    }
}
