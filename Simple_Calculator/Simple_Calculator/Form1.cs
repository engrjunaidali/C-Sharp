using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;

            i = Convert.ToInt32(textNumber1.Text);
            j = Convert.ToInt32(textNumber2.Text);
            k = i / j;

            textAnswer.Text = Convert.ToString(k);
         
            
            
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, j, k;

            i = Convert.ToInt32(textNumber1.Text);
            j = Convert.ToInt32(textNumber2.Text);
            k = i * j;

            textAnswer.Text = Convert.ToString(k);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, j, k;

            i = Convert.ToInt32(textNumber1.Text);
            j = Convert.ToInt32(textNumber2.Text);
            k = i + j;

            textAnswer.Text = Convert.ToString(k);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, j, k;

            i = Convert.ToInt32(textNumber1.Text);
            j = Convert.ToInt32(textNumber2.Text);
            k = i - j;

            textAnswer.Text = Convert.ToString(k);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textNumber1.Text = null;
            textNumber2.Text = null;
            textAnswer.Text = null;
        }
    }
}
