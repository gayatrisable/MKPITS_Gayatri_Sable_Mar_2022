using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace aaray_list_1_std_info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("amit");
            ar.Add("raj");
            ar.Add("dilip");
            Console.WriteLine("Student Name : ");
            //displaying values of arraylist
            foreach (Object obj in ar)
            {
                Console.WriteLine( obj);
            }
            Console.ReadLine();
        
        }
    }
}
