using System;
using System.Collections.Generic;

namespace StackObject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack ms = new MyStack();
            ms.Push("World");
            ms.Push(" ");
            ms.Push("Hello");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ms.Peek());
                ms.Pop();
            }
        }
    }

    class MyStack
    {
        public IList<Object> myStack;
        public MyStack()
        {
            myStack = new List<Object>();
        }

        public void Push(object o)
        {
            myStack.Add(o);
        }
        public void Pop()
        {

            myStack.RemoveAt(myStack.Count - 1);
        }
        public Object Peek()
        {

            Object o = myStack[myStack.Count-1];
            return o;
        }
    }
}
