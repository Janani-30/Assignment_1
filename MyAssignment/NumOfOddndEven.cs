using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment
{
    class NumOfOddndEven
    {

        static void Main(string[] args)
        {
            int[] arr =  new int[10];
            int oddcount = 0;
                int evencount = 0;

            Console.WriteLine("enter the values of for the array");
            for(int i =0;i<10;i++)
                {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i =0;i<10;i++)
            {
                if(arr[i]%2==0)
                {
                    evencount++;
                }
                else
                {
                    oddcount++;
                }
            }
            Console.WriteLine(evencount);
            Console.WriteLine(oddcount);
            Console.ReadLine();
            }
    }
}
