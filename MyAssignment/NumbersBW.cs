using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class NumbersBW
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i=a;i<b;i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
                    }
    }
}
