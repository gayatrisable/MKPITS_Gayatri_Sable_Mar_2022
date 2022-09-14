using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.ass__salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            float bonous = emp.calculatebonus(Convert.ToInt32(textBox1.Text));
            float totalsal = emp.calulatetotalsalary(Convert.ToSingle(bonous), Convert.ToInt32(textBox3.Text));
            emp.empno = Convert.ToInt32(textBox1.Text);
            emp.empname = textBox2.Text;
            label4.Text ="Employee Number : " +emp.empno.ToString();
            label5.Text = "Employee Name : "+emp.empname;
            label6.Text = "Total Salary : " +totalsal.ToString();

        }
    }
}
