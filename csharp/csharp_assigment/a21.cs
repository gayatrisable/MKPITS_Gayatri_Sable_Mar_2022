using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a5.prime_number_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept a number and print whether it is prime no. or not.
            int i, n, cnt = 0;
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cnt++;
                }
            }
            if (cnt == 2)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not a prime number");
            }
            Console.ReadLine();
        }
    }
}
