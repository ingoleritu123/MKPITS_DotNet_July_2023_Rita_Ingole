using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountwith2button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] AccountNumber = new int[2];
        int[] AccountHolderName = new int[2];
        int[] AccountBalance = new int[2];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 2)

            {
                AccountNumber[cnt] = Convert.ToInt32(textBox1.Text);
                cnt++;
                textBox1.Clear();
                textBox1.Focus();
                if (cnt == 2)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have allredy entered  2 account details");
                }
                AccountHolderName[cnt] = textBox2.Text;
                cnt++;
                textBox2.Clear();
                textBox2.Focus();
                if (cnt == 2)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have allredy entered 2 account details");
                }
                AccountBalance[cnt] = Convert.ToInt32(textBox2.Text);
                cnt++;
                textBox3.Clear();
                textBox3.Focus();
                if (cnt == 2)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have allredy entered 2 account details");
                }

            }
            for (int i = 0; i <= 2; i++)
            {
                Account b1 = new Account();
                b1.AccountNumber = Convert.ToInt32(textBox1.Text);
                b1.AccountHolderName = textBox2.Text;
                b1.Balance = Convert.ToInt32(textBox3.Text);

                StringBuilder sb = new StringBuilder();e
                sb.Append("AccoountNumber : " + b1.AccountNumber + "\n");
                sb.Append("AccountHolderName : " + b1.AccountHolderName + "\n");
                sb.Append("0Balance : " + b1.Balance + "\n");
                label4.Text = sb.ToString();

                Account b2 = new Account();
                b2.AccountNumber = Convert.ToInt32(textBox1.Text);
                b2.AccountHolderName = textBox2.Text;
                b2.Balance = Convert.ToInt32(textBox3.Text);

                StringBuilder SB = new StringBuilder();
                SB.Append("AccoountNumber : " + b2.AccountNumber + "\n");
                SB.Append("AccountHolderName : " + b2.AccountHolderName + "\n");
                SB.Append("0Balance : " + b2.Balance + "\n");
                label4.Text = SB.ToString();
            }
        }
    }
}
