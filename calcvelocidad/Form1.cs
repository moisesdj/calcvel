using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calcvelocidad
{
    public partial class Form1 : Form
    {
        double t;
        double t2;
        double t3;
        double v;
        double v2;
        double p;
        double p2;
        double ret;
        double rev;
        double rep;
        double tt2;
        double tt;
        double rtt;
        double rvt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            t = double.Parse(campot.Text);
            t2 = double.Parse(campot2.Text);
            v = double.Parse(campov.Text);
            v2 = double.Parse(campov2.Text);
            p = double.Parse(campop.Text);
            p2 = double.Parse(campop2.Text);
            
            t3 = (t2*t);
            rev = (v - t3);
            resultadov.Text = rev.ToString();
            
            
             tt2 = (t2/t);
             tt = Math.Pow(t,t);
            rtt = (tt2*tt);
            rvt = (rev*t);
            rep = (p-rtt-rvt);
            resultadop.Text = rep.ToString();
            
        }

        private void campot_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
        graficacalc obj_graficar = new graficacalc();
        private void timer1_Tick(object sender, EventArgs e)
        {
            obj_graficar.p_x_set(int.Parse("0"));
            obj_graficar.grafico(chart1);

        }
    }
}
