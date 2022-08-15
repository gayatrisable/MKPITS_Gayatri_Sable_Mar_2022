using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    internal class Program
    {                                                //example of params is used to multiple array dislay
        static void display(params int[] num)//syntax of params
        {
            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);

        }
        static void Main(string[] args)
        {
            display(2, 3, 4);
            Console.ReadLine();
        }
        
    }
}
