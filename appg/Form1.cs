using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 regsitration = new Form2();
            regsitration.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            string msg = "";
            msg = msg + "Backgroud color Form:" + this.BackColor.ToString() + "\n";
            msg = msg + "Button click:" + label1.Text;
            Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Login your account");
            this.Height = this.Height;
            this.Width = this.Width;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            string msg = "";
            msg = msg + "Backgroud color Form:" + this.BackColor.ToString() + "\n";
            msg = msg + "Button click:" + label2.Text;
            Text = msg;
        }
    }
}
