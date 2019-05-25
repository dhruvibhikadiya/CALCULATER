using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{

    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }
        float num, ans;
        double result,no;
        int count;
        public void disable()
        {
            textBox1.Enabled = false;
            button20.Enabled=true;
            button19.Enabled = false;
            button13.Enabled = false;
            button3.Enabled = false;
            button12.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = false;
            button10.Enabled = false;
            button9.Enabled = false;
            button8.Enabled = false;
            button7.Enabled = false;
            button6.Enabled = false;
            button11.Enabled = false;
            button5.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button21.Enabled = false;

        }


        public void enable()
        {
            textBox1.Enabled = true;
            button20.Enabled = false;
            button19.Enabled = true;
            button13.Enabled = true;
            button3.Enabled = true;
            button12.Enabled = true;
            button2.Enabled = true;
            button4.Enabled = true;
            button1.Enabled = true;
            button10.Enabled = true;
            button9.Enabled = true;
            button8.Enabled = true;
            button7.Enabled = true;
            button6.Enabled = true;
            button11.Enabled = true;
            button5.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button21.Enabled = true;





        }
        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)

        {
            
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 1;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.Text = textBox1.Text + 1;
                    textBox1.ForeColor = Color.Black;

                }
            

        }

        private void button12_Click(object sender, EventArgs e)
        {    
                    textBox1.Text = textBox1.Text + ".";
                    textBox1.ForeColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 0;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.Text = textBox1.Text + 0;
                    textBox1.ForeColor = Color.Black;
                }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 2;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.Text = textBox1.Text + 2;
                    textBox1.ForeColor = Color.Black;
                }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 3;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.Text = textBox1.Text + 3;
                    textBox1.ForeColor = Color.Black;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 4;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.Text = textBox1.Text + 4;
                    textBox1.ForeColor = Color.Black;

                }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + 5;
                    textBox1.ForeColor = Color.Black;
                }
                else
                {
                    textBox1.Text = textBox1.Text + 5;
                    textBox1.ForeColor = Color.Black;
                }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 6;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 7;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
                textBox1.ForeColor = Color.Black;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 8;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + 9;
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text+textBox1.Text+"=";
            compute();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 5;
            label1.Text = num.ToString() + "%";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            textBox1.Text = textBox1.Text + 0;
            enable();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
            disable();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            no = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 9;
            label1.Text = "root" + no.ToString();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            label1.Text = "sqrt" + num.ToString();
            count = 6;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 7;
            label1.Text = "qube" + num.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 8;
            label1.Text = "1/" + num.ToString();
        }

        public void compute()
        {
            switch(count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 6:
                    ans = num * num;
                    textBox1.Text = ans.ToString();
                    break;
                case 7:
                    ans = num * num * num;
                    textBox1.Text = ans.ToString();
                    break;
                case 8:
                    ans = 1 / num;
                    textBox1.Text = ans.ToString();
                    break;
                case 9:
                  
                    result = Math.Sqrt(no);
                    textBox1.Text = result.ToString();
                    break;
                default:
                    break;


            }
        }
    }
}
