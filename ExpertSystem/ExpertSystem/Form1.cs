﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form1 : Form
    {
        Ekspert ex;
        public Form1()
        {
            InitializeComponent();
            ex = new Ekspert();
        }

        private void rozpocznijJakoEkspertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ex.Show();

        }
    }
}
