using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_type_short
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short s;
            Console.WriteLine("Enter short data:");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("short data is: " + s);
            Console.ReadLine();
        }
    }
}
