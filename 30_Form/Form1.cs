using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30_Form
{
    public partial class Form1 : Form
    {
        string FormTitle = "Hesap Makinam_v1";
        public Form1()
        {
            InitializeComponent();
        }

        private void LogWrite(string str)
        {
            txt_log.Text = str + "\r\n"+ txt_log.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogWrite("Clicked");
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            LogWrite("Enter");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            LogWrite("Leave");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = $"{e.X}:{e.Y}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pnl_log.Visible = checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = pnl_log.Visible;
            lbl_Opacity.Text = (this.Opacity * 100).ToString();
            trackBar1.Value = (int)(this.Opacity*100);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; //Button objesini unbox ediyoruz.
            string digit = button.Text;
            LogWrite(digit+ " dugmensine basıldı");
            txt_screen.Text += digit;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            LogWrite(numericUpDown1.Value.ToString()+ " yeni değeri");
        }

        private void btn_addvalue_Click(object sender, EventArgs e)
        {
            string bulkDigits = numericUpDown1.Value.ToString();
            LogWrite(bulkDigits + " Eklendi");
            txt_screen .Text += bulkDigits;
        }

        private void ch_TopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = ch_TopMost.Checked;
            if(ch_TopMost.Checked)
            {
                this.Text = FormTitle + " [en üstte]";
            }
            else
            {
                this.Text = FormTitle;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lbl_Opacity.Text = "%" + trackBar1.Value.ToString();
            var op = (double)trackBar1.Value / 100;
            LogWrite(op.ToString()+ " Opacity");
            this.Opacity = (double)trackBar1.Value / 100;
        }

        private void btn_Clock_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LogWrite("Saat Açık");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Clock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void add_Click(object sender, EventArgs e)
        {
            txt_initialnum.Text = txt_screen.Text;
            Button button = (Button)sender; //Button objesini unbox ediyoruz.
            string op = button.Text;
            txt_operator.Text = op;
            txt_screen.Text = "";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int result;
            switch (txt_operator.Text)
            {
                case "+":
                    result = Convert.ToInt16(txt_initialnum.Text) + Convert.ToInt16(txt_screen.Text);
                    LogWrite(result.ToString());
                    txt_initialnum.Text = txt_initialnum.Text + " "+ txt_operator.Text +" " + txt_screen.Text;

                    txt_screen.Text = Convert.ToString(result);
                    txt_operator.Text = "=";
                    break;

                case "-":
                    result = Convert.ToInt16(txt_initialnum.Text) - Convert.ToInt16(txt_screen.Text);
                    LogWrite(result.ToString());
                    txt_initialnum.Text = txt_initialnum.Text + " " + txt_operator.Text + " " + txt_screen.Text;

                    txt_screen.Text = Convert.ToString(result);
                    txt_operator.Text = "=";
                    break;

                case "*":
                    result = Convert.ToInt16(txt_initialnum.Text) * Convert.ToInt16(txt_screen.Text);
                    LogWrite(result.ToString());
                    txt_initialnum.Text = txt_initialnum.Text + " " + txt_operator.Text + " " + txt_screen.Text;

                    txt_screen.Text = Convert.ToString(result);
                    txt_operator.Text = "=";
                    break;

                case "/":
                    result = Convert.ToInt16(txt_initialnum.Text) / Convert.ToInt16(txt_screen.Text);
                    LogWrite(result.ToString());
                    txt_initialnum.Text = txt_initialnum.Text + " " + txt_operator.Text + " " + txt_screen.Text;

                    txt_screen.Text = Convert.ToString(result);
                    txt_operator.Text = "=";
                    break;

            }
                
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            txt_screen.Text = "";
            txt_operator.Text = "";
            txt_initialnum.Text = "";
            txt_log.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            int del = txt_screen.Text.Length - 1;
            txt_screen.Text = txt_screen.Text.Substring(0, del);
        }
    }
}
