using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteEligibility_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = Convert.ToInt32(textBox1.Text);
            if(Age<18)
            {
                label2.Text = "You are Minor in Age.";
                label3.Text = "Sorry Not Eligible For Vote.";
            }
            else if(Age>18 && Age<50)
            {
                label2.Text = "You are Young in Age.";
                label3.Text = "Congratulations!! you are Eligible For Vote.";

            }
            else if(Age>50)
            {
                label2.Text = "You are Old in Age.";
                label3.Text = "Congratulations!! you are Eligible For Vote.";
            }
        }
    }
}
