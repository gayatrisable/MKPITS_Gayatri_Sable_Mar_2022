using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_type
{
    //create a class employee having fields empno,empname and salary
    class Employee
    {
        public int empno;
        public String empname;
        public float salary;

    }

    class Program
    {
        static void Main()
        {
            //creating an object(instance) of employee class
            //syntax classname objectname =new classname();
            Employee emp = new Employee();//not taking input by user
            emp.empno = 123;
            emp.empname = "mohit";

            emp.salary = 12345.2f;

            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("salary " + emp.salary);
            Console.ReadLine();
        }
    }
}
