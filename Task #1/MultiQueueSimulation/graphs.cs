﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class graphs : Form
    {
        public graphs()
        {
            InitializeComponent();
        }

        private void graphs_Load(object sender, EventArgs e)
        {

        }

        private void graphs_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

     
    }
}
