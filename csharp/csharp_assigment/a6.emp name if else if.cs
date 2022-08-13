using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6.emp_name_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - wap to accept empid, empname , basicsalary and calculate hra ie 32 % of basic, da ie 45 % of basic display empno,empname , hra , da , total salary 
            string name,a;
            int i;
            Console.WriteLine("Enter employee id:");
            name = Console.ReadLine();
            Console.WriteLine("Enter employee name:");
            a = Console.ReadLine();
            Console.WriteLine("Enter employee basic salary:");
            i = Convert.ToInt32(Console.ReadLine());
            float hr = (32/100.0f)*i ;
            float da = (45/100.0f)*i;
            float total = i + hr + da;
            Console.WriteLine("employee id: "+name);
           

            Console.WriteLine("employee name:" + a);
            
            Console.WriteLine("employee basic salary: " + i);
            
            Console.WriteLine("employee hr: " + hr);
            
            Console.WriteLine("employee da: " + da);
            
            Console.WriteLine("employee total salary: " + total);
            Console.ReadLine();

        }
    }
}
