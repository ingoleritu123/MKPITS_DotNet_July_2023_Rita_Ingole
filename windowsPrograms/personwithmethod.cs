using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personwithmethod
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
            Person per = new Person();
            per.Name = textBox1.Text;
            per.age = Convert.ToInt32(textBox1.Text);
            per.Address = textBox3.Text;


            StringBuilder sb = new StringBuilder();

            sb.Append("Name of Person:"+per.Name);
            sb.Append("Age :"+per.Age);
            sb.Append("Address:"+per.Address);
            label4.Text = sb.ToString();



        }
    }
}
