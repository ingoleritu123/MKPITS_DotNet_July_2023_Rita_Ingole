using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_details_windowsform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[3];
        int cnt = 0; 

        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            

            if (cnt < 3)
            {
                emp[cnt].employeename = textBox1.Text;

                
                emp[cnt].employeeid = Convert.ToInt32(textBox2.Text);
                emp[cnt].salary = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                
                if(cnt==3)
                {
                    button1.Enabled = false;
                   
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("details of 3 employees alredy accepted");


                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Employee Details" + "\n");
            for (int i = 0; i < 3; i++)
            {
                sb.Append("----------------------------------------\n");
                sb.Append("Employee Id:" + emp[i].employeeid + "\n");
                sb.Append("Employee Name:" + emp[i].employeename + "\n");
                sb.Append("Salary:" + emp[i].salary + "\n");
                sb.Append("----------------------------------------\n");
            }
            label4.Text = sb.ToString();


           double high = emp[0].salary;
            int foundat = 0;
            for(int i=1;i<3;i++)
            {
                if (high < emp[i].salary)
                {
                    high = emp[i].salary;
                    foundat = i;
                }
            }


        }
    }
}
