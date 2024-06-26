﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTTT3DSExt
{
    public partial class ModelDumper : Form
    {
        public ModelDumper(int files)
        {
            InitializeComponent();
            label2.Text = files.ToString();
            progressBar1.Maximum = files;
            dialog();
            this.Focus();
        }

        async void dialog() => await Task.Run(() => this.ShowDialog());

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
            CTTT3DSModule.process += 2;
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
    }
}
