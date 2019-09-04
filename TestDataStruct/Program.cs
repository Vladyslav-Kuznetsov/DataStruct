using System;
using DataStruct;

namespace TestDataStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.Add(1);
            a.Add(2);
            a.Add("Hello");
            a.Add(6);
            a.Insert(new Node("Hello"), "Nigga");
            
            var b = a.ToArray();

            foreach (var c in b)
            {
                Console.WriteLine(c);
            }
            
            Console.ReadLine();
        }
    }
}
