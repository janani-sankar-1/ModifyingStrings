using System;
using System.Collections.Generic;

namespace ModifyingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Janani";
            string name_updated = name.Insert(4, "ana");
            Console.WriteLine(name_updated);

            string name_updated2 = name.Remove(2, 4);
            Console.WriteLine(name_updated2);
            Console.ReadKey();
        }
    }
}
