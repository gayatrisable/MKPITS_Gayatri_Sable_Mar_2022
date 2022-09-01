using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace student_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);
            //displaying values of arraylist
            foreach (int obj in ar)
            {
                Console.WriteLine("student rno " + obj);
            }


            Console.WriteLine("Capacity: {0} ", ar.Capacity);
            Console.WriteLine("Count: {0}", ar.Count);
            Console.ReadLine();
        }
    }
}
