using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        string operand = null;
        double FPart = 0;
        double SPart = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bttn = (Button)sender;
            textBox1.Text +=bttn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FPart = Convert.ToDouble(textBox1.Text);
            operand = "+";
            textBox1.Text = "";
        }

        private void buttonEqualTo_Click(object sender, EventArgs e)
        {
            SPart = Convert.ToDouble(textBox1.Text);

            switch(operand)
            {
                case "+":            
                    textBox1.Text = (FPart + SPart).ToString();
                    break;

                case "-":
                    textBox1.Text = (FPart - SPart).ToString();
                    break;

                case "*":
                    textBox1.Text = (FPart * SPart).ToString();
                    break;

                case "/":
                    textBox1.Text = (FPart / SPart).ToString();
                    break;

                default:
                    break;
            }

           

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            FPart = Convert.ToDouble(textBox1.Text);
            operand = "*";
            textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FPart = Convert.ToDouble(textBox1.Text);
            operand = "-";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FPart = Convert.ToDouble(textBox1.Text);
            operand = "/";
            textBox1.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(-1 * q);
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

            }

           // if (textBox1.Text == "0")
           // {
               // textBox1.Text = "";

            //}
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
      
            textBox1.Text = "";

            string f, s;

            f = Convert.ToString(FPart);
            s = Convert.ToString(SPart);

            f = "";
            s = "";
        }
    }
}
