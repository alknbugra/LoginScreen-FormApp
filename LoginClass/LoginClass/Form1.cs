using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginClass
{
    public partial class Form1 : Form
    {
        public LoginControl loginControl;

        public Form1()
        {
            InitializeComponent();
            loginControl = new LoginControl();
            loginControl.frm1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                if (textBox2.Text !="")
                {
                    if (textBox1.Text.Length >= 4 && textBox2.Text.Length >= 4)
                    {
                        string turnData = loginControl.control(textBox1.Text,textBox2.Text);
                        MessageBox.Show(turnData,"INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("incorrect entry", "INFO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        textBox2.Clear();
                        textBox1.Clear();
                        textBox1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Password", "INFO", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter User", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Clear();
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
