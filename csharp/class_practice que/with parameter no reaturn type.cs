//method with parameter and no return type
//wap to create a method to square a no.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace with_parameter_and_no_return_type
{
    internal class Program
    {
        void square()
        {
            int num = 5;
            int sq = num * num;
            Console.WriteLine("square = " + sq);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.square(); 
            Console.WriteLine("THANK U!");
            Console.ReadLine();
        }
    }
}
