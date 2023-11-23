using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankAccount Act = null;
            int act_no = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            string tt = textBox3.Text;
            if(tt=="saving")
            {
                Act = new saving();
            }
            else if(tt=="current")
            {
                Act = new current();
            }
            else
            {
                Console.WriteLine("Oops Something went wrong");
            }
            label4.Text = Act.deposit(act_no, amt);
            label5.Text = Act.showbalance();
        }
    }
}
