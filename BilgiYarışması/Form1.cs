using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //VeriTabansız Bilgi Yarışması
        int soruno = 0;
        int dogru = 0;
        int yanlıs = 0;
        int süre = 20;

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 20;
            label10.Text = süre.ToString();
                

            button5.Text = "İLERİ";
            soruno++;
            label2.Text = soruno.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

            if (soruno == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılında doğdu ?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1884";
                label4.Text = "1881";
            }

            if(soruno == 2)
            {
                richTextBox1.Text = "Türkiye kaç coğrafi bölgeye ayrılır?";
                button1.Text = "7";
                button2.Text = "4";
                button3.Text = "21";
                button4.Text = "32";
                label4.Text = "7";
            }
            if(soruno == 3)
            {
                richTextBox1.Text = "Türkiyen'nin en büyük yüzölçümüne sahip olan ili hangisidir? ";
                button1.Text = "istanbul";
                button2.Text = "ankara";
                button3.Text = "konya";
                button4.Text = "erzurum";
                label4.Text = "konya";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button1.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                yanlıs++;
                label7.Text = yanlıs.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button2.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();
            }
            else
            {
                yanlıs++;
                label7.Text = yanlıs.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button3.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();

            }
            else
            {
                yanlıs++;
                label7.Text = yanlıs.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label3.Text = button4.Text;
            if (label3.Text == label4.Text)
            {
                dogru++;
                label6.Text = dogru.ToString();

            }
            else
            {
                yanlıs++;
                label7.Text = yanlıs.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(label10.Text);
            süre = süre - 1;
            label10.Text = süre.ToString();
            if (süre == 0)
            {
                timer1.Enabled = false;
                yanlıs++;
                label7.Text = yanlıs.ToString();
                    
            }
        }
    }
}
