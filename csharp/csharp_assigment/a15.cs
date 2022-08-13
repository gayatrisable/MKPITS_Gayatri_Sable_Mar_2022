using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a15.prime_number_by_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept a no. and print whether it is primeno or not.
            int i, num, cnt = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cnt++;
                }
            }
            switch (cnt)
            {
                case 2:
                    Console.WriteLine("Prime number");
                    break;
                default:
                    Console.WriteLine("Not a prime number");
                    break;
            }
            Console.ReadLine();
        }
    }
}
