using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302223057
{
    public partial class Form1 : Form
    {
        private String buttonText;
        private String buttonTextTemp;
        private int hasil;
        //int32.Parse()
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonText += "1" ;
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonText += "2";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonText += "3";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonText += "4";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonText += "5";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonText += "6";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonText += "7";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonText += "8";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonText += "9";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonText += "0";
            textBox1.Text = buttonText;
            textBox1.Show();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            buttonTextTemp = textBox1.Text;
            buttonText = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            hasil = Int32.Parse(buttonText) + Int32.Parse(buttonTextTemp);
            buttonTextTemp = hasil.ToString();
            textBox1.Text = buttonTextTemp;
            textBox1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonText = "";
            buttonTextTemp = "";
            textBox1.Text = "";
            textBox1.Show();
        }
    }
}
