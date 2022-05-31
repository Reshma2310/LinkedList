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
            //list.Add(30);
            list.Add(70);
            list.Display();
            int place = list.Search(56);            
            list.InsertAtPosition(place + 1, 30);
            list.Display();
            list.RemoveFirstNode(56);
            list.Display();
        }
    }
}


