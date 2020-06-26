using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Series
    {

       static void Main(string[] args)
        {
            int i, j;
            for(i = 0; i <= 20; i++)
            {
                j = i * i;
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
