using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Library;

namespace WindowsForm_ByreferranceBank
{
   /* namespace Bank_Library
    {

        public abstract class account
        {
            public int accountno;
            public int balance = 1000;
            public abstract string deposit(int amount);
            public string withdrawl(int amount)
            {
                string res = null;
                if (balance > amount)
                {
                    res = "insuffient fund.cannot withdrawl money!";
                }
                else
                {
                    balance = balance - amount;
                    res = "amount withdrawl successfully , balance is " + balance.ToString();
                }
                return res;
            }
            public string showbalance()
            {
                return "balnce amount is : " + balance.ToString();
            }
        }
        public class saving : account
        {
            public override string deposit(int amount)
            {
                int interest = 300;
                balance = balance + amount + interest;
                return "amount deposited successfully,balance is : " + balance.ToString();
            }
        }
        public class current : account
        {
            public override string deposit(int amount)
            {
                balance = balance + amount;
                return "amount deposited successfully,balance is : " + balance.ToString();
            }
        }

    }*/

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        account act = null;
        private void button1_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = res;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="saving")

            {
                act = new saving();
            }
            else if(comboBox1.Text=="Current")
            {
                act = new current();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.accountno = Convert.ToInt32(textBox1.Text);
            string res = act.showbalance();
            label4.Text = res;
        }
    }
}
