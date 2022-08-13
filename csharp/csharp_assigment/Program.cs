using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition_of_3_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the 1st Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number:");
            num3 = Convert.ToInt32(Console.ReadLine());
            int r = num1 + num2 + num3;
            Console.WriteLine("Addition of three Number"+ r);
            Console.ReadLine();

        }
    }
}
