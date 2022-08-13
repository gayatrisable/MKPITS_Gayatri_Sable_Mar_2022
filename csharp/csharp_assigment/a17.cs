using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1_print_table_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program to print table using  while
            int i=1, n, res;
            Console.WriteLine("Enter Number:");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= 10) 
            {
                res = i * n;
                Console.WriteLine(n + " * " + i + " = " + res);
                i++;
            }
            Console.ReadLine();

        }
    }
}
