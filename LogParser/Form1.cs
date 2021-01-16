
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogParser
{
    public partial class Form1 : Form
    {
        private String _res;
        private Parser _p = new Parser();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {         
            _p.setText(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals(""))
            {
                textBox2.Text = "You must insert an input before submiting!";
            }
            else
            {

                this._res = _p.ParseText(_p.gettext());
                this.textBox2.Text = this._res;
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox2.Text.Equals(""))
            {
                Clipboard.SetText(textBox2.Text);
            }
        }
    }
}
