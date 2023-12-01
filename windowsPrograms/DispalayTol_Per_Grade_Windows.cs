using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayTol_Per_Grade_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Sub1 = Convert.ToInt32(textBox1.Text);
            int Sub2 = Convert.ToInt32(textBox2.Text);
            int Sub3 = Convert.ToInt32(textBox3.Text);


            int Total = Sub1 + Sub2 + Sub3;
            label6.Text = "Total:" + Total;


            float per = (Total / 300.0f) * 100.0f;
            label4.Text="Percentage:"+per;
            String Grade;
            if (per<=60)
            {
                Grade = "Distingshhion";
            }
            else if(per>60 && per<80)
            {
                Grade = "FirstClass";
            }
            else
            {
                Grade = "SecondClass";
            }
            label5.Text = "Grade:" + Grade;

            

        }
    }
}
