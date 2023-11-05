using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountEX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = Convert.ToInt32(textBox1.Text);
            b1.AccountHolderName = textBox2.Text;
            b1.Balance = Convert.ToInt32(textBox3.Text);

            StringBuilder sb = new StringBuilder();
            sb.Append("AccoountNumber : " + b1.AccountNumber + "\n"); 
            sb.Append("AccountHolderName : " +b1.AccountHolderName + "\n");
            sb.Append("Balance : " + b1.Balance + "\n");
            label4.Text = sb.ToString();

        }
    }
}
