using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.parameterized_constructor_with_4_parameters
{//3 create a class employee having fields empno,empname , designation and salary create a constructor with no parameters and create another parameterized constructor with 4 parameters
    class employee
    {
        int empno;
        string empname, designation;
        int salary;
        //creating a constructor with no parameters
        public employee()
        {
            empno = 167;
            empname = "Neha";
            designation = "Manager";
            salary = 20000;
        }
        //constructor with 4 parameters(parameterized constructor)
        public employee(int empno, string empname, string designation, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Enter Employee Id: " + empno);
            Console.WriteLine("Enter Employee Name: " + empname);
            Console.WriteLine("Enter Designiation: " + designation);
            Console.WriteLine("Enter Salary: " + salary);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            employee b = new employee();//this will call constructor automatically

            b.display();
            Console.WriteLine("-----------------1st employee detail ----------");
            employee b1 = new employee(168, "MONU", "Manager", 27000);
            b1.display();

            Console.ReadLine();
        }
    }
}
