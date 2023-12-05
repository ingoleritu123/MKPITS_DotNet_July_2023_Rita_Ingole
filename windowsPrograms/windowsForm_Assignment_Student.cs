using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDows_Assignment_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string Name = textBox1.Text;
            int age = Convert.ToInt32(numericUpDown1.Value);
            if(textBox1.Text==" " && numericUpDown1.Value==0)
            {
                MessageBox.Show("Please Enter Name and age:");
            }
            else if(textBox1.Text=="")
            {
                MessageBox.Show("Enter Your Name First.");
            }
            else if(numericUpDown1.Value==0)
            {
                MessageBox.Show("please Enter Your Age First.");
            }
            else if(numericUpDown1.Value<18)
            {
                MessageBox.Show("OOps!! Your Age should be 18 or greater than 18.")
            }
            sb.Append("Name:" + Name+"\n");
            sb.Append("Age:" +age+"\n");


            label4.Text = sb.ToString();
        }
    }
}
