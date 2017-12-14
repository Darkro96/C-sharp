using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox_radio
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int pont = 0;
        int r1, r2;
        int i = 1;
        int s1, s2;
        public Form1()
        {    
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Feladat();
            i = 0;
            pont = 0;
            label4.Text = "0";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if(progressBar1.Value>=30)
            {
                i++;
                if ((s1 == s2 && radioButton2.Checked) || (s1 > s2 && radioButton3.Checked) || (s1 < s2 && radioButton2.Checked))
                    pont++;
                    
                if (i == 10)
                {
                    timer1.Stop();
                    label4.Text = pont.ToString();
                }
                Feladat();
                label6.Text = (i+1).ToString();
                
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Click_button(object sender, EventArgs e)
        {
           
                
            
        }

        public void Feladat()
        {
            r1 = r.Next(1, 100);
            r2 = r.Next(1, 100);
            s1 = r1 + r2;
            label1.Text = r1.ToString();
            label1.Text += " + ";
            label1.Text += r2.ToString();
            r1 = r.Next(1, 100);
            r2 = r.Next(1, 100);
            s2 = r1 + r2;
            label2.Text = r1.ToString();
            label2.Text += " + ";
            label2.Text += r2.ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
