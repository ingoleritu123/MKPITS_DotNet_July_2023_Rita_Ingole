﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accept3submarksinarry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] marks = new int[3];
        int total = 0;
        float per;
        int cnt = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cnt<3)

            {
                marks[cnt] = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox1.Focus();
                if(cnt==3)
                {
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                    MessageBox.Show("you have allredy entered 3 Subject marks");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<marks.Length;i++)
            {
                total = total + marks[i];
            }
            label2.Text = "Total Marks=" + total;
            per = (total / 300.0f) * 100.0f;
            label3.Text = "Percentage=" + per;
        }
        



        
    }
}
