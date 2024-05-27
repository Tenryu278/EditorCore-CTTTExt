using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptainToadRebirthExt
{
    public partial class AddObject : Form
    {
        
        public string A = "";
        public string B = "";
        
        public AddObject()
        {
            InitializeComponent();
        }

        public bool PostName()
        {
            if (A != "" && B != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            A = textBox1.Text;
            B = textBox2.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
