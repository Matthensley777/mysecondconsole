using System;
using System.Collections.Generic;

namespace MySecondConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var children = new List<Child>
            {
            new Child { Name = "Suzie", Sick = false },
            new Child { Name = "Ralph", Sick = true }
            };

            foreach(var child in children)
            {
                if (child.Name = "Suzie")
                {
                    continue;
                }
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }

            Console.WriteLine("This is our second time talking about the same thing.");

            var lineiRead = Console.ReadLine();

        }
    }
}
