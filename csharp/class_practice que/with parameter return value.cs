using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_parameter_and_returning_value
{
    internal class Program
    {
        static int square(int num)
        {

            int sq = num * num;
            
            return sq;
        }
        static void Main(string[] args)
        {
            int num = 5;
            int res = square(num); 
            Console.WriteLine("square " + res);
            Console.WriteLine("THANK U!");
            Console.ReadLine();
        }
    }
}
