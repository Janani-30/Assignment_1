using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class GreatestAmongThree
    {
        static void Main(string[] args)
        {
            ///int num1, num2, num3;
            Console.WriteLine("Enter three values");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("Number two is the largest!\n");
            }
            else
            {
                Console.Write("Number three is the largest!\n");
            }

            Console.ReadLine();
        }

    }
}
