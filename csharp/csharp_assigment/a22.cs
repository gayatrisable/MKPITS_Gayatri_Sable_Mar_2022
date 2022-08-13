using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6.prime_number_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print prime number 1 to 20
            int a, b;
            for (a = 1; a <= 20; a++)
            {
                int cnt = 0;
                for (b = 1; b <= a; b++)
                {
                    if (a % b == 0)
                    {
                        cnt++;

                    }
                }
                if (cnt == 2)
                {
                    Console.Write(a + " ");
                }
            }
            Console.ReadLine();
        }
    }
}





