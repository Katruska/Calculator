using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CurrentState = state.nonstate;
        }

        #region variables
        string buff;//some operanions +-*/
        state CurrentState;//state
        enum state
        {
            substraction,
            addiction,
            multiplication,
            divide,
            nonstate
        }
        #endregion

        //запрет на ввод букв(только цифры и знаки)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back)
                {
                    if (e.KeyChar == (char)Keys.Back)
                    {

                    }
                    else
                        if (textBox1.Text.Contains(",") || textBox1.Text.Contains("."))
                        {
                            e.Handled = true;
                        }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
       
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentState == state.divide)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(buff) / buff2).ToString();
                }
                if (CurrentState == state.multiplication)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(buff) * buff2).ToString();
                }
                if (CurrentState == state.substraction)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(buff) - buff2).ToString();
                }
                if (CurrentState == state.addiction)
                {
                    CurrentState = state.nonstate;
                    double buff2 = double.Parse(textBox1.Text);
                    textBox1.Text = (double.Parse(buff) + buff2).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Try input incorrect data");
            }
        }

        #region operanions
        //умножение
        private void mul_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.multiplication;
                buff = textBox1.Text;
                textBox1.Text = "*";
            }

        }
        //вычитание
        private void sub_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.substraction;
                buff = textBox1.Text;
                textBox1.Text = "-";
            }
        }
        //деление
        private void div_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.divide;
                buff = textBox1.Text;
                textBox1.Text = "/";
            }
        }
       //сложение
        private void add_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.addiction;
                buff = textBox1.Text;
                textBox1.Text = "+";
            }
        }
        //+/-
        private void PlusMinus_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (double.Parse(textBox1.Text) * (-1)).ToString();
            }
            catch (Exception) { }
        }
        //корень
        private void sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                {
                    textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                }

            }
            catch (Exception) { }
        }
        //cos
        private void cos_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Cos(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception) { }
        }
        //sin
        private void sin_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Sin(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception) { }
        }
        //tg
        private void tg_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Tan(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception) { }
        }
        //exp
        private void exp_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Exp(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception) { }
        }
        //log
        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Log(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception) { }
        }
        //ln
        private void ln_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Log10(double.Parse(textBox1.Text)).ToString();
            }
            catch (Exception) { }
        }
        //pi
        private void pi_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.PI.ToString();
            }
            catch (Exception) { }
        }
        //x^2
        private void sqr_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text),2).ToString();
            }
            catch (Exception) { }
        }
        //1/x
        private void del_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = (1/(double.Parse(textBox1.Text))).ToString();
            }
            catch (Exception) { }
        }
        
        #region clean
        //C
        private void c_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            CurrentState = state.nonstate;
            buff = "";
          
        }
        //CE
       private void ce_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
        //←
        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            catch (Exception) { }
        }

        #region numbers
        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
       
        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }
        #endregion

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.Show();
        }
        #endregion
        #endregion
    }
}
