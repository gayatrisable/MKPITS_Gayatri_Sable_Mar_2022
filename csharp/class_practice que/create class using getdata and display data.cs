using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_class_using__getdata_and_display_data
{
    //create a class employee having fields empno,empname and salary
    class Employee
    {
        int empno;
        String empname;
        float salary;
        //creating methods
        public void getdata()
        {

            Console.WriteLine("enter employee no");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            salary = Convert.ToSingle(Console.ReadLine());

        }
        public void displaydata()
        {
            Console.WriteLine("empno " + empno);
            Console.WriteLine("empname " + empname);
            Console.WriteLine("salary " + salary);
        }

    }

    class Program
    {
        static void Main()
        {
            //creating an object(instance) of employee class
            //syntax classname objectname =new classname();
            Employee emp = new Employee();

            emp.getdata();
            emp.displaydata();

            Console.ReadLine();
        }
    }
}
