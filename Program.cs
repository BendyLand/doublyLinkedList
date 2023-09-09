using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DoublyLinkedList<string> lst = new DoublyLinkedList<string>();
        lst.AddToHead("Ben");
        lst.AddToHead("Olivia");
        lst.AddToTail("Olivia");
        Console.WriteLine(lst.Stringify());
        
        lst.RemoveHead();
        Console.WriteLine(lst.Stringify());
        lst.RemoveTail();
        Console.WriteLine(lst.Stringify());

        lst.RemoveByValue("Ben");
        Console.WriteLine(lst.Stringify() + "0");
    }
}