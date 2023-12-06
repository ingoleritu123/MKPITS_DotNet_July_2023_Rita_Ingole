using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ragistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RagistrationForm r = new RagistrationForm();
            r.MdiParent = this;
            r.Show();
        }

        private void enquiryFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnquiryForm f = new EnquiryForm();
            f.MdiParent = this;
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ragistrationFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RagistrationForm r = new RagistrationForm();
            r.MdiParent = this;
            r.Show();
        }

        private void enquiryFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EnquiryForm f = new EnquiryForm();
            f.MdiParent = this;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin") 
            {
                MessageBox.Show("login Successfull");
                ragistrationFormToolStripMenuItem.Enabled = true;
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            

            

            
            

        }
    }
}
