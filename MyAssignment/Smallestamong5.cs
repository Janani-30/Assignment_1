using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Smallestamong5
    {
        static void Main(string[] args)
        {
            int smallest;
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            smallest = num1;
            if (num2 < num1)
                smallest = num2;
            if (num3 < num2)
                smallest = num3;
            if (num4 < num3)
                smallest = num4;
            if (num5 < num4)
                smallest = num5;

            else if (num5 < num1)
                smallest = num5;
            Console.WriteLine("The smallest number is:"+ smallest);
            Console.ReadLine();
        }
    }
}
