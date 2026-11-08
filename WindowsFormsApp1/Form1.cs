using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.Items.Add("item 1");
            comboBox2.Items.Add("item 2");
            comboBox2.Items.Add("item 3");
            comboBox2.Items.Add("item 4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "button 3 was opened ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "button 4 was opened ";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "radio button 4 was opened "; 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "radio button 5 was opened ";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label6.Text = "radio button 6 was opened ";

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "check box 3 was opened ";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "check box 4 was opened ";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox2.SelectedItem.ToString() + "Selected";

        }
    }
}
