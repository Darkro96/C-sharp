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
    public partial class Form1 : Form
    {
        Double result = 0;
        bool enter_value = false;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        //Pi
        private void button40_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.141592653589976323";
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 340;
            this.Height = 490;
            textBox1.Width = 286;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 600;
            this.Height = 490;
            textBox1.Width = 556;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 340;
            this.Height = 490;
            textBox1.Width = 286;
        }

        //Buttons
        private void button_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "0")
            
                textBox1.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;
            }
            else
                textBox1.Text = textBox1.Text + num.Text;
            
        }

        //Del
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
        }

        //Del
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        //Backspace
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length -1,1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        //Operators
        private void operators_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            result = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(result) + "       " + operation;
        }

        //Equal
        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "%":
                    textBox1.Text = (result % Double.Parse(textBox1.Text)).ToString();
                    break;
            }

        }

        //Log10
        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
            
        }

        //Sqrt
        private void button38_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        //Sin
        private void button35_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(textBox1.Text);
            sin = Math.Sin(sin);
            textBox1.Text = System.Convert.ToString(sin);
        }

        //Cos
        private void button31_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(textBox1.Text);
            cos = Math.Cos(cos);
            textBox1.Text = System.Convert.ToString(cos);
        }

        //Tan
        private void button27_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(textBox1.Text);
            tan = Math.Tan(tan);
            textBox1.Text = System.Convert.ToString(tan);
        }

        //x^2
        private void button33_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        //x^3
        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        //Bin
        private void button30_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 2);
        }

        //Hex
        private void button26_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 16);
        }

        //Oct
        private void button22_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a, 8);
        }

        //Dec
        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(a);
        }

        //1/x
        private void button29_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(a);
        }

        //Log
        private void button25_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        //About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Máté Nagy", "About");
        }

        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //%
        private void button4_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }
    }
}
