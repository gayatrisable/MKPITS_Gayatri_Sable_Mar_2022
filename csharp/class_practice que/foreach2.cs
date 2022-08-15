using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example of foreach loop
            //create an array of 5 element
            string[] num = new string[3];

            num[0] = "amit";
            num[1] = "raj";
            num[2] = "dilip";
            //using foreach loop to iterate over the elements of an array
            foreach (string i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
