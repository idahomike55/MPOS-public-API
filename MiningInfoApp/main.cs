﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiningInfoApp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void publicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newMDIChild = new Form1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void getuserstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getuserstatus newMDIChild = new getuserstatus();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
