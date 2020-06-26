using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Length
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter the String");
        string name =Convert.ToString(Console.ReadLine());
        int nameLength = name.Length;
        Console.WriteLine("The name " + name + " contains " + nameLength + "letters.");
            Console.ReadLine();
            }
    }
}
