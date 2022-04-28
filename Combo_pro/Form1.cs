using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Combo_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt;
            txt=this.textBox1.Text;
            if (txt=="")
            {
                MessageBox.Show("You must input a name");
                return;  // exits programme out of the subroutine without adding(below)
            }
            this.comboBox1.Items.Add(txt);
            this.itm_label3.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 selectedIndex;
            selectedIndex = comboBox1.SelectedIndex;
            this.comboBox1.Items.RemoveAt(selectedIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index_dlabel2.Text = this.comboBox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.itm_label3.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 fi;
           fi= this.comboBox2.FindStringExact(SearchTextbox.Text);
           this.Text = fi.ToString();
           
            if (fi==-1)
            {
                MessageBox.Show("Not-Found-Exact name only");
            }
            else
            {
                this.comboBox2.SelectedIndex = fi;
            }
        }
    }
}
