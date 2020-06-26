using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Fact
    {
       public static void Main(string[] args)
        {
            int fact = 1, n;
            Console.WriteLine("enter a number");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++) 
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);

            Console.ReadLine();
        }


    }
}
