using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using piskvorkz.Klient;

namespace piskvorkz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            Socket.SendContent(textBox12.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Socket.SendContent(textBox1.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Socket.SendContent(textBox1.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Socket.SendContent(textBox1.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Socket.SendContent(textBox1.Text);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

            Socket.SendContent(textBox1.Text);
        }
    }
}