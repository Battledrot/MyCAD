using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCAD
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            // myForm1.Despose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Form6 myForm6 = new Form6();
            myForm6.Show();
        }

        int i;
        double Number, Memory;

        private void button9_Click(object sender, EventArgs e)
        {
            double number2, number3;
            if (i==1)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number + number2;
                textBox1.Text=number3.ToString();
            }

            if (i==2)
            {
                number2=Convert.ToDouble(textBox1.Text);
                number3 = Number - number2;
                textBox1.Text=number3.ToString();
            }

            if (i==3)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number * number2;
                textBox1.Text=number3.ToString();
            }

            if (i == 4)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number / number2;
                textBox1.Text = number3.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            i = 2;
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            i = 3;
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            i=4;
            Number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double number2;
            Number = Convert.ToDouble(textBox1.Text);
            number2=1/Number;
            textBox1.Text = number2.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double number2,number3;
            if (i== 1)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number * (1 + number2 / 100);
                textBox1.Text=number3.ToString();
            }

            if (i == 2)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number * (1 - number2 / 100);
                textBox1.Text = number3.ToString();
            }

            if (i == 3)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number * number2 / 100;
                textBox1.Text = number3.ToString();
            }

            if (i == 4)
            {
                number2 = Convert.ToDouble(textBox1.Text);
                number3 = Number / number2 * 100;
                textBox1.Text = number3.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Memory.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Memory=Convert.ToDouble(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number2, number3;
            number2=Convert.ToDouble(textBox1.Text);
            number3 = number2 + Memory;
            textBox1.Text= number3.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form7 myForm7=new Form7();
            myForm7.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            i = 1;
            Number=Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }
    }

}
