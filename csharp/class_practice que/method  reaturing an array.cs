using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_returning_an_array
{
    internal class Program
    {
        static int[] returnarray()
        {
            int[] num = { 1, 2, 3,4,5 };
            return num;
        }
        static void Main(string[] args)
        {
            int[] arr = returnarray();
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
