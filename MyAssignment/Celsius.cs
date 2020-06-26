using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class Celsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the temperature in celsius");
            double celsius=double.Parse(Console.ReadLine());

            double farenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("The temperature in celsius is " + celsius + "and in farenheit is " + farenheit);
            Console.ReadLine();
        }
        
    }
}
