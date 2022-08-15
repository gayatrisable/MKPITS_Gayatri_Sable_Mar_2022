﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_methods_parameters//methods parameters having same name as classmembers name use this keyword to refer to class member
{
    class Employee
    {
        int empno;
        String empname;
        float salary;
        //creating methods
        public void getdata(int empno, String empname, float salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;

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
            Console.WriteLine("enter employee no");

            int eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            String en = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            float sal = Convert.ToSingle(Console.ReadLine());

            emp.getdata(eno, en, sal);
            emp.displaydata();

            Console.ReadLine();
        }
    }
}
