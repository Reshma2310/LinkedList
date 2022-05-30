using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            LinkedListClass list = new LinkedListClass();
            list.Add(70);
            list.AddFirst(30);
            list.AddFirst(56);
            list.Display();
        }
    }
}


