using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMATS
{
    public partial class Calculator : Form
    {
        double resultValue=0;
        string operationPerformed = "";
        bool isoperationPerformen = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorC cl1 = new CalculatorC();
            cl1.Back();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorC cl = new CalculatorC();
            cl.logout();
            Close();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isoperationPerformen) )
                textBox1.Clear();
            isoperationPerformen = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                button20.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isoperationPerformen = true;
            }else
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isoperationPerformen = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }
            resultValue = double.Parse(textBox1.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
