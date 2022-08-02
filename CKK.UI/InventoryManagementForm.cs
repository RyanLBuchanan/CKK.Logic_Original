﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;

namespace CKK.UI
{
    public partial class InventoryManagementForm : Form
    {
        private IStore Store;

        public InventoryManagementForm()
        {
            Store = new IStore();
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchByIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void idProductHeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void ryangineerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change LinkColor after it has been clicked
            ryangineerLinkLabel.LinkVisited = true;

            // Visit webpage 
            System.Diagnostics.Process.Start("https://www.ryangineer.com/");
        }

        private void topEditProductPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
