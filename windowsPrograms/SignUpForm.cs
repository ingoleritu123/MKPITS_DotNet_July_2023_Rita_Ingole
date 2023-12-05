using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinupForm
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
            //username & Password

            StringBuilder sb = new StringBuilder();
            sb.Append("UserName" + textBox1.Text+"\n");
            sb.Append("Password" + textBox2.Text+"\n");

            //gender
            string gender = null;
            if(radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            sb.Append("Gender:" + gender+"\n");


            /* if(checkBox1.Checked)
             {
                 sb.Append("Course  Joined"+checkBox1.Text+"\n");
             }
             else if(checkBox2.Checked)
             {
                 sb.Append("Course joined" + checkBox2.Text + "\n");
             }

             sb.Append("City" + comboBox1.Text + "\n");*/

            //Course****

            string course = null;
            if(checkBox1.Checked)
            {
                course = checkBox1.Text;
            }
            if(checkBox2.Checked)
            {
                course = course+" "+checkBox2.Text;
            }


            //Code For Display


            sb.Append("Course" + course + "\n");
            sb.Append("Country" + comboBox1.Text + "\n");
            sb.Append("City" + comboBox2.Text + "\n");

            //DOB

            MessageBox.Show(dateTimePicker1.Text);
            label10.Text = dateTimePicker1.Text;
            sb.Append("DOB:" + dateTimePicker1.Text + "\n");

            label9.Text =sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";

            switch(comboBox1.Text)
            {
                case "USA":
                    comboBox2.Items.Add("california");
                    comboBox2.Items.Add("canada");
                    break;
                case "India":
                    comboBox2.Items.Add("nagpur");
                    comboBox2.Items.Add("vardha");
                    break;

            }

            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
