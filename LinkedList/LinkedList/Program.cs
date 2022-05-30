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
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}


