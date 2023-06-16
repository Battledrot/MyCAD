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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Form3 myForm3 = new Form3();
            myForm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myForm3= new Form3();
            myForm3.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Form5 myForm5 = new Form5();
            myForm5.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Form7 myForm7 = new Form7();
            myForm7.Show();
        }
    }
}
