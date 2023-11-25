using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Employeeby_Arrylistin_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        Employee emp;
        ArrayList arr = new ArrayList();
        private void button2_Click(object sender, EventArgs e)
        {
            emp = new Employee((textBox1.Text),Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), (textBox4.Text));
            arr.Add(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee emp in arr)
            {
                sb.Append("Emp_Name:" + emp.Emp_name);
                sb.Append("Emp_no:" + emp.Emp_name);
                sb.Append("Emp_Salaryt:" + emp.Emp_name);
                sb.Append("Designation:" + emp.Emp_name);
            }

            label5.Text = sb.ToString();

        }
    }
}
