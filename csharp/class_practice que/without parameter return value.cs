using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace without_parameters_and_returning_value
{
    internal class Program
    {
        static int square()
        {
            //method without parameters and returning value
            //wap to create a method to square a no.
            int num = 5;
            int sq = num * num;
            return sq;
        }
        static void Main(string[] args)
        {
            int res = square(); 
            Console.WriteLine("square " + res);
            Console.WriteLine("THANK U!");
            Console.ReadLine();
        }
    }
}
