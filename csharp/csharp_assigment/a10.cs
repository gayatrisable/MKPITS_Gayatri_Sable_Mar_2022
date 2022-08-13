using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10.prime_number_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12- wap to accept a no. and print whether it is primeno or not.
            
            Console.WriteLine("Enter a number:");
            int i,num,cnt = 0;
            
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cnt = cnt + 1;
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
