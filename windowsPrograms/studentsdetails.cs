using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_details_windowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student[] stud = new Student[5];
        int cnt=0;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new Student();
            stud[1] = new Student();
            stud[2] = new Student();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 10)
            {
                stud[cnt].StudentName = textBox1.Text;
                stud[cnt].RollNo = Convert.ToInt32(textBox2.Text);
                stud[cnt].JoiningDate = textBox3.Text;
                stud[cnt].PaidFees = Convert.ToInt32(textBox4.Text);
                
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if(cnt==10)
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    MessageBox.Show("Details of 10 Students accepted.");
                }
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
