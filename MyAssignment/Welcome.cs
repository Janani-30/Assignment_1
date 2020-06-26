using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Welcome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a name");
            String name = Console.ReadLine();

            Console.WriteLine("hi " + name);
            Console.WriteLine("Welcome to the world of c#");
            Console.ReadKey();

        }
    }
}