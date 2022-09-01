using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ass._1_employee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList al = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            employee e1 = new employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
            employee e2 = new employee(Convert.ToInt32(textBox3.Text), textBox4.Text);
            al.Add(e1);
            al.Add(e2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (employee s in al)
            {
                sb.Append("Employee Id : " + s.Employee_Id + "    Employee Name : " + s.name + "\n");
            }
            label3.Text = sb.ToString();

        }
    }
}
