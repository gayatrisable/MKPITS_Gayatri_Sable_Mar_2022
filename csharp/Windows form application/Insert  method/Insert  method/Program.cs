using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Insert__method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(12);
            ar.Add(13);
            //displaying values of arraylist
            Console.WriteLine("array list colection without sorting");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }
            ar.Insert(2, 17);

            Console.WriteLine("array list colection after adding element at 2 position");
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }
            Console.ReadLine();

        }
    }
}
