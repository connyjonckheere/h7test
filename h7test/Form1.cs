﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h7test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eerste bericht in VS");
            MessageBox.Show("Tweede bericht");
            MessageBox.Show("derde bericht vanuit github");
            MessageBox.Show("wijziging 29 mei");
            //wijziging in github om dan een pull te kunnen doen in Visual Studio
        }
    }
}
