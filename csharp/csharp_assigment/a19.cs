using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.factorial_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //factorial while loop
            int i, num, fact = 1;
            Console.WriteLine("Enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            i = num;
            while (i > 0)
            {
                fact = fact * i;
                i--;
            }
            Console.WriteLine(fact);
            Console.ReadLine();
        }
    }
}
