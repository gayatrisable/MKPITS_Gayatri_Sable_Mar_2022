using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_input_get_by_user
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
            //accept the values from the user
            Employee emp = new Employee();
            Console.WriteLine("enter employee no");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            emp.empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            emp.salary = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("salary " + emp.salary);
            Console.ReadLine();
        }
    }
}
