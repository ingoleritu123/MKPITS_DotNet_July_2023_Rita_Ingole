using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomerDetails_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int quantity = Convert.ToInt32(textBox2.Text);
            int Rate = Convert.ToInt32(textBox3.Text);
            sb.Append("Customer Name:" + textBox1.Text+"\n");
            sb.Append("Mobile_No:" + maskedTextBox1.Text+"\n");
            sb.Append("Product Name:" + comboBox1.Text+"\n");
            sb.Append("Product Model:" + comboBox2.Text+"\n");
            sb.Append("Prodduct Rate:" + textBox3.Text+"\n");
            sb.Append("Product Quantity:" + textBox2.Text+"\n");


            int result = quantity * Rate;
            sb.Append("Total:"+result);
            label7.Text = sb.ToString();

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";

            switch(comboBox1.Text)
            {
                case "Bed":
                    comboBox2.Items.Add("Wooden Bed");
                    comboBox2.Items.Add("Iron Bed");
                    comboBox2.Items.Add("Small Wooden");
                    comboBox2.Items.Add("Small Iron");
                    comboBox2.Items.Add("Large Wooden");
                    comboBox2.Items.Add("Large Iron");
                    break;
                case "Sofa":
                    comboBox2.Items.Add("3 Sitter Sofa");
                    comboBox2.Items.Add("6 Sitter Sofa");
                    break;
                case "Chairs":
                    comboBox2.Items.Add("Iron Chairs");
                    comboBox2.Items.Add("Wooden Chairs");
                    break;
                case "Washing Machine":
                    comboBox2.Items.Add("Washing Machine 8kg");
                    comboBox2.Items.Add("Washing Machine 5kg");
                    comboBox2.Items.Add("Washing Machine 10kg");
                    break;
                case "Dinning Table":
                    comboBox2.Items.Add("Dinning 4Chairs");
                    comboBox2.Items.Add("Dinning 8Chairs");
                    comboBox2.Items.Add("Dinning 12Chairs");
                    break;
                case "Mixer":
                    comboBox2.Items.Add("Mixer With 2 jar");
                    comboBox2.Items.Add("Mixer With 4 jar");
                    comboBox2.Items.Add("Mixer With 6 jar");
                    break;
                case "Refrigerator":
                    comboBox2.Items.Add("Refrigerator SingleDoor");
                    comboBox2.Items.Add("Refrigerator DoubleDoor");
                    break;




            }
        }
    }
}
