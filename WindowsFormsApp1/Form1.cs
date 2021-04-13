using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += button0.Text;
        }



        //private void buttonPlus_Click(object sender, EventArgs e)
        //{
        //    _prev = textBox1.Text;
        //    textBox1.Text = "";
        //    _act = "+";
        //}
        private void buttonMinus_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {

        }



        //private void buttonResult_Click(object sender, EventArgs e)
        //{
        //    string tmp = textBox1.Text;
        //    switch(_act)
        //    {
        //        case "+":
        //            textBox1.Text = ""+(Convert.ToInt32(_prev) + Convert.ToInt32(_prev));
        //            break;
        //        case "-":
        //            textBox1.Text = ""+(Convert.ToInt32(_prev) - Convert.ToInt32(_prev));
        //            break;
        //        case "*":
        //            textBox1.Text = ""+(Convert.ToInt32(_prev) * Convert.ToInt32(_prev));
        //            break;
        //        case "/":
        //            textBox1.Text = ""+(Convert.ToInt32(_prev) / Convert.ToInt32(_prev));
        //            break;
        //    }
        //    textBox1.Text = "" + (Convert.ToInt32(_prev) + Convert.ToInt32(_prev));
        //}

      
    }
}
