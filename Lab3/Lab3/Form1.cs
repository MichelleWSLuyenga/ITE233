using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexSearch = listBox1.FindStringExact(textBox1.Text, -1);
            if (indexSearch == -1)
            {
                listBox1.Items.Add(textBox1.Text);
                richTextBox1.Text += ("Item '" + textBox1.Text + "' is on the list as item number " + (listBox1.Items.Count.ToString()) + "\n");
            }
            else if (indexSearch != -1 && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                richTextBox1.Text += ("Item '" + textBox1.Text + "' has been added to the list " + "\n");
            }
            else
            {
                richTextBox1.Text += ("Please insert text to add \n");
            }
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > 0)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex - 1, listBox1.Text);
                listBox1.SelectedIndex = (listBox1.SelectedIndex - 2);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex + 2);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1 && listBox1.SelectedIndex < listBox1.SelectedItems.Count)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex + 2, listBox1.Text);
                listBox1.SelectedIndex = (listBox1.SelectedIndex + 2);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex - 2);
            }
        }

        private void button1_KeyPress_2(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 8)
            {
                button4_Click(sender, e);
            }
        }
    }
}
