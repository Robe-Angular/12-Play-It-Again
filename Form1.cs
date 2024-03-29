﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_Play_It_Again
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }

        private void toogleEnabled_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private void startTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Console.WriteLine("Enabled: " + timer1.Enabled);
        }

        private void stopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Console.WriteLine("Enabled: " + timer1.Enabled);
        }
    }
}
