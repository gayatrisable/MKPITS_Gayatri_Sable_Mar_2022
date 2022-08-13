using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a16.even_or_odd_by_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // wap to accept a no. and print whether it is even no or oddno. by switch
            int r, num;
            Console.WriteLine("enter any number");
            num = Convert.ToInt32(Console.ReadLine());
            r = num % 2;
            switch (r)
            {
                case 0:
                    Console.WriteLine("Even number");
                    break;
                default:
                    Console.WriteLine("odd number");
                    break;
            }

            Console.ReadLine();
        }
    }
}
