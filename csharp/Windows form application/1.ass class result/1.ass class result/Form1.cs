using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.ass_class_result
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Result res = new Result();
            
            int total = res.calculatetotal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            float per = res.calculatepercentage(Convert.ToInt32(total));
            string grade = res.calculategrade(Convert.ToSingle(per));
            label4.Text = "total = "+total.ToString();
            label4.Visible = true;
            label5.Text = "Persentage = "+per.ToString();
            label6.Text = "Grade = "+grade;
        }
    }
}
