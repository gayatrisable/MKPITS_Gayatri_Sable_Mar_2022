using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition_of_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter the 1st number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            int res = num1 + num2;
            Console.WriteLine("Addition of two Number is:" + res);
            Console.ReadLine();

        }
    }
}
