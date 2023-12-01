using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emp_Ass_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emp_Nmae = textBox1.Text;
            float basic_salary = Convert.ToInt32(textBox2.Text);
            string designation = textBox3.Text;

            float totalsalary = 0;
            float bonus = 0;
            float hra = 0;

            if(designation=="peun")
            {
                hra = basic_salary * 0.15f;
                bonus = basic_salary * 0.2f;
            }
            else if (designation == "Clerk")
            {
                hra = basic_salary * 0.30f;
                bonus = basic_salary * 0.25f;
            }
            else if (designation == "Manager")
            {
                hra = basic_salary * 0.45f;
                bonus = basic_salary * 0.50f;
            }
            label4.Text = "HRA:" + hra;
            label5.Text = "Bonus:" + bonus;
            totalsalary= hra + bonus + basic_salary;
            label6.Text = "TotalSalary:" + totalsalary;
        }
    }
}
