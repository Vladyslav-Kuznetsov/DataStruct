using System;
using DataStruct;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            a.Add("Hello");
            a.Add("Nigga");
            a.Add("I");
            a.Add("Fuck");
            a.Add("Your");
            a.Add("Mother");

            var c = a.ToArray();

            

            foreach (var b in c)
            {
                Console.WriteLine(b);
            }
            

           

            Console.ReadLine();
        }
    }
}
