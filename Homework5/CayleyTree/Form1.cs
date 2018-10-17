using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = this.CreateGraphics();
            
            drawCayleyTree(8,200,200,50, Convert.ToDouble(textBox1.Text));
        }
        private Graphics graphics;
        double th1 = 10 * Math.PI / 180;
        double th2 = 5 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        double k = 2;

        //画树，th是角度，由用户选择
        public void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            double x1=0,x2=0,y1=0,y2=0;
            if (n == 0)
                return;
           
            x1 = x0 + leng * Math.Cos(th);
            y1 = y0 + leng * Math.Abs(Math.Sin(th));
            x2 = x0 - leng * k * Math.Cos(th);
            y2 = y0 + leng * k * Math.Abs(Math.Sin(th));
            
            drawLine(x0, y0, x1, y1);
            drawLine(x0, y0, x2, y2);
            drawCayleyTree(n - 1, x1, y1, per1 * leng,th-th1);
            drawCayleyTree(n - 1, x2, y2, per2 *leng,th-th2);
        }
        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }
    
private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
