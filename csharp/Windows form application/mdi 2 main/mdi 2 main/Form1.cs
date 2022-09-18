using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_2_main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_form r = new Register_form();
            r.MdiParent = this;
            r.Show();
           
           

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account_Form r = new Account_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Register_form r = new Register_form();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Account_Form r = new Account_Form();
            r.MdiParent = this;
            r.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
