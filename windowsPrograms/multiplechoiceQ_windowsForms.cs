using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplechoiceQuestion_windowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void multipleChoiceQuestionPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultipleChoiceQuestionPaper p = new MultipleChoiceQuestionPaper();
            p.MdiParent = this;
            p.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void multipleChoiceQuestionPaperToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            MultipleChoiceQuestionPaper p = new MultipleChoiceQuestionPaper();
            p.MdiParent = this;
            p.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                MessageBox.Show("login Successful");
                multipleChoiceQuestionPaperToolStripMenuItem.Enabled = true;
                panel1.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials.");

               
            }

        }
    }
}
