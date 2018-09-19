using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    public partial class Form1 : Form
    {
        int a, b;        string s1, s2;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            s1 = textBox2.Text;            a = Int32.Parse(s1);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            s2 = textBox3.Text;            b = Int32.Parse(s2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = a * b;            textBox4.Text = a + " * " + b + " = " + c;

        }
    }
}
