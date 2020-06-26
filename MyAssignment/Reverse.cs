using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Reverse
    {

        static void Main(string[] args)

        {
            Console.WriteLine("enter the String");
            string name = Convert.ToString(Console.ReadLine());
            string[] words = name.Split(' ');
            Array.Reverse(words);
            name = String.Join(" ", words);
            Console.WriteLine("THe reverse of the string is "+name);
            Console.ReadLine();
        }
    }
}
