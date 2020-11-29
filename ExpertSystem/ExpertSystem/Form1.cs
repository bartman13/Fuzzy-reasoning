using System;
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
 
        User us;
        Instrukcja ins;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void rozpocznijJakoEkspertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            

        }

        private void rozpocznijJakoUżytkwownikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            us = new User();
            us.Show();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ins = new Instrukcja();
            ins.Show();
        }
    }
}
