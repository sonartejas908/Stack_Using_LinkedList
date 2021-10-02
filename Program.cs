using System;

namespace Day14Stack_queue_problems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedListStack
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            Console.WriteLine("-------------------------------------");
            #endregion

            #region LinkedListStack
            LinkedListStack linkedListStack2 = new LinkedListStack();
            linkedListStack2.Push(70);
            linkedListStack2.Push(30);
            linkedListStack2.Push(56);
            linkedListStack2.Display();
            linkedListStack2.IsEmpty();
            Console.WriteLine("------------------------------------");
            #endregion

            #region LinkedListStack
            LinkedListStack linkedListStack3 = new LinkedListStack();
            linkedListStack3.Push(70);
            linkedListStack3.Push(30);
            linkedListStack3.Push(56);
            linkedListStack3.Display();
            #endregion



        }

    }
}
