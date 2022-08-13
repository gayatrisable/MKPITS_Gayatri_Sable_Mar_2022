using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2.print_table_by_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print table by do while
            int i = 1, n, res;
            Console.WriteLine("Enter the number:");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                res = n * i;
                Console.WriteLine(n+ " * " +i+ " = " +res);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
