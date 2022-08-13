using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a2.object_class_employee
{
    class employee
    {//2- create a class employee having fields empno,empname,designation and salary create a constructor with no parameters and method display
        int empno;
        string empname;
        string designation;
        int salary;
        //creating a constructor with no parameters
        public employee()//dynamic input or constant this is dynamic method
        {
            Console.WriteLine("Enter Employee Id:");
            this.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name:");
            this.empname = Console.ReadLine();
            Console.WriteLine("Enter Designation:");
            this.designation =Console.ReadLine();
            Console.WriteLine("Enter salary:");
            this.salary = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Employee id = " + empno);
            Console.WriteLine("Employee name = " + empname);
            Console.WriteLine("Employee Designation= " + designation);
            Console.WriteLine("Employee Salary = " + salary);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee p = new employee();//this will call constructor automatically
            p.display();
            Console.ReadLine();
        }
    }
}
