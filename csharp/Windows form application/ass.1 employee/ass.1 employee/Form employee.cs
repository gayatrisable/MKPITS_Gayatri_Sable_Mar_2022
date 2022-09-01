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
    public partial class Form_employee : Form
    {
        public Form_employee()
        {
            InitializeComponent();
        }
        ArrayList al = new ArrayList();
       employee[] stud = new employee[4];
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 4)
            {
                stud[i - 1] = new employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
                al.Add(stud[i - 1]);
            }

            if (i == 4)
            {
                MessageBox.Show("4 Employee added");
                button1.Enabled = false;
            }

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
