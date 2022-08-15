using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace local_and_global_veriable_decleration
{
    internal class Program
    {
        static int gnum = 20;//gobal varible decleration
        static void display()
        {
            int num = 5;//local variable declearation.
            Console.WriteLine("num inside method " + num);
            Console.WriteLine("gnum inside method " + gnum);
        }
        static void Main(string[] args)
        {
            display();
            // Console.WriteLine("num = " + num); error since num is local variable
            Console.WriteLine("gnum inside main" + gnum);
            Console.ReadLine();
        }
        
    }
}
