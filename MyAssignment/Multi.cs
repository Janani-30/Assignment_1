using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Multi
    {
        public static void Main(string[] args)
        {
            int j, n;
            Console.WriteLine("Display the multiplication table:\n");

            Console.WriteLine("Input the number to be calculated : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (j = 1; j <= 20; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            Console.ReadLine();
        }
    }
}
