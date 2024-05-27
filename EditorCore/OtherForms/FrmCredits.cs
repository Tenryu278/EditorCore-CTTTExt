﻿using EditorCore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditorCore
{
    public partial class FrmCredits : Form
    {
        public FrmCredits(IGameModule module, ExtensionManifest[] extensions)
        {
            InitializeComponent();
			textBox1.Text = $"Loaded extensions:\r\nGame module : {module.ModuleName}\r\n";
			foreach (var ext in extensions)
			{
				textBox1.Text += $"\r\n{ext.ModuleName} by {ext.Author}\r\n";
				if (ext.ExtraText != null)
					textBox1.Text += $"{ext.ExtraText}\r\n";

			}
		}

        private void FrmCredits_Load(object sender, EventArgs e)
        {
            label4.Text = "V. " + Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/exelix11/EditorCore");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
