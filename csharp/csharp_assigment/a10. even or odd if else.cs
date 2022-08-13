using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10.even_or_odd_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept a no. and print whether it is even no or oddno.
            int num;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("even number");

            }
            else
            {
                Console.WriteLine("odd number");

            }
            Console.ReadLine();
        }
    }
}
