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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            // myForm1.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 myForm4 = new Form4();
            myForm4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double add1, add2, add3;
            add1=Convert.ToDouble(textBox1.Text);
            add2=Convert.ToDouble(textBox8.Text);
            add3 = add1 + add2;
            textBox12.Text=add3.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sub1, sub2, sub3;
            sub1=Convert.ToDouble(textBox2.Text);
            sub2=Convert.ToDouble(textBox7.Text);
            sub3 = sub1 - sub2;
            textBox11.Text=sub3.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double mul1,mul2,mul3;
            mul1=Convert.ToDouble(textBox3.Text);
            mul2=Convert.ToDouble(textBox6.Text);
            mul3 = mul1 * mul2;
            textBox10.Text=mul3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double div1,div2,div3;
            div1=Convert.ToDouble(textBox4.Text);
            div2=Convert.ToDouble(textBox5.Text);
            div3 = div1 - div2;
            textBox9.Text=div3.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 myForm5 = new Form5();
            myForm5.Show();
        }
    }
}
