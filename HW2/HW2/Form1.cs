using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String te1;
           te1 = Convert.ToString(textBox1.Text);
            textBox3.Text = Convert.ToString(te1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String te2;
            te2 = Convert.ToString(textBox2.Text);
            textBox3.Text = Convert.ToString(te2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = Text;
        }
    }
}
