using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goto_even_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //goto even odd
            int num ;
            Console.WriteLine("enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) goto even;
            Console.WriteLine("this is odd number");
            goto end;

        even:
            Console.WriteLine("number is even");
            goto end;
        end:
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
