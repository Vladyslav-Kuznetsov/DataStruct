using System;
using DataStruct;

namespace DataStruct.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList a = new LinkedList();
            //a.Add(1);
            //a.Add(2);
            //a.Add("Hello");
            //a.Add(6);
            //a.Insert(new Node("Hello"), "Nigga");

            //var b = a.ToArray();

            //foreach (var c in b)
            //{
            //    Console.WriteLine(c);
            //}

            //DoublyLinkedList a = new DoublyLinkedList();
            //a.Add(1);
            //a.Add(2);
            //a.Add(3);
            //a.Add(4);
            //a.Add(5);
            //a.Add(6);
            //a.Add(7);
            //a.Add(8);
            //a.RemoveFirst();
            //a.RemoveLast();
            //a.Remove(5);
            //Console.WriteLine(a.Contains(4));
            //var c = a.ToArray();

            //foreach (var i in c)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(a.Count);

            Queue a = new Queue();
            a.Enqueue(1);
            a.Enqueue(2);
            a.Enqueue(3);
            a.Dequeue();
            
            Console.WriteLine(a.Contains(50));

            var b = a.ToArray();

            foreach (var c in b)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            Console.WriteLine(a.Peek());

            Console.ReadLine();
        }
    }
}
