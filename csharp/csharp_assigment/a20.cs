using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a4.factorial_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print factorial do while
            int i, n, fact = 1;
            Console.WriteLine("Enter number");
            n = Convert.ToInt32(Console.ReadLine());
            i = n;
            do
            {
                fact = fact * i;
                i--;
            } while (i > 0);
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
