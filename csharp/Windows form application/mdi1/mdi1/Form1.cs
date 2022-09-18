using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register_form r = new register_form();
            r.MdiParent = this;
            r.Show();

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            account_form a = new account_form();
            a.MdiParent = this;
            a.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI Gayatri Sable!");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI Priyanka!");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            account_form a = new account_form();
            a.MdiParent = this;
            a.Show();
        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            register_form r = new register_form();
            r.MdiParent = this;
            r.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
