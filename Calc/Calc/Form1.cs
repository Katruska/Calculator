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

        

        #region арифметические действия(нажатия на кнопки)
       //умножение
        private void mul_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.multiplication;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();//focus on textbox1 and clear it
            }

        }
        //вычитание
        private void sub_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.substraction;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();//focus on textbox1 and clear it
            }
        }
        //деление
        private void div_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.divide;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();//focus on textbox1 and clear it
            }
        }
       //сложение
        private void add_Click(object sender, EventArgs e)
        {
            if (CurrentState == state.nonstate)
            {
                CurrentState = state.addiction;
                buff = textBox1.Text;
                textBox1.Text = "";
                textBox1.Focus();//focus on textbox1 and clear it
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

       


        #region numbers
        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox1.Focus();
        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            textBox1.Focus();
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            textBox1.Focus();
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            textBox1.Focus();
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            textBox1.Focus();
        }

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            textBox1.Focus();
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            textBox1.Focus();
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            textBox1.Focus();
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            textBox1.Focus();
        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            textBox1.Focus();
        }
       
        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            textBox1.Focus();
        }


        #endregion

        




        #endregion



    }
}
