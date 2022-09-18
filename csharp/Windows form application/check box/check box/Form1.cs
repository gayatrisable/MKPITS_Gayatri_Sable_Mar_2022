using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bsal = Convert.ToInt32(textBox2.Text);
            
            float bonus = bsal * .40f;
            float totalsal =bsal +  0.0f;
            label3.Text = " ";
            label4.Text = " ";
            if (checkBox1.Checked)
            {
                label3.Text = "bonus " + bonus;
            }
            if(checkBox2.Checked)
            {
                label3.Text = "tolal salary" + totalsal;
            }
        }
    }
}
