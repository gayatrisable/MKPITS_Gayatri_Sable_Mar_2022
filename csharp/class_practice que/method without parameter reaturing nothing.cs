using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_without_parameters_and_returning_nothing_1
{
    internal class Program
    {
        static void square()//called fuction
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            int sq = num * num;
            Console.WriteLine("square = " + sq);
        }
        static void Main(string[] args)
        {
            square(); // calling the method display
            Console.WriteLine("THANK U!");
            Console.ReadLine();
        }
        
    }
}
