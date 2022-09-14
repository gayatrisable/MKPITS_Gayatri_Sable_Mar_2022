using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using calculate;

namespace calculate1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calclate cal = new calclate();
        private void button1_Click(object sender, EventArgs e)
        {
            int res = cal.addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = "Addition : " + res;
            int res1 = cal.substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label4.Text = "Substraction : " + res1;
        }

      
    }
}
