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

namespace CaptainToadRebirthExt
{
    public partial class DumpModels : Form
    {
        public DumpModels()
        {
            InitializeComponent();
            label2.Text = CTTT3DSModule.s.ToString("0000");
            progressBar1.Maximum = CTTT3DSModule.s;
        }

        public void Progressbar1_plus()
        {
            Refresh();
            progressBar1.PerformStep();
            label3.Text = progressBar1.Value.ToString("0000");
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DumpModels_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/gdkchan/Ohana3DS-Rebirth");
        }
    }
}
