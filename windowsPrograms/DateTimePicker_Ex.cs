using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimePicker_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
            MessageBox.Show("dob:" + age);
           
            String yr = age.Substring(5);
            int year = dateTimePicker1.Value.Year;
            MessageBox.Show("Dob year:" + yr);
            int cyr = DateTime.Now.Year;
            MessageBox.Show("Current year:" + cyr);
            int diff = cyr - Convert.ToInt32(yr);
            MessageBox.Show("Your Age is :" + diff);
        }
    }
}
