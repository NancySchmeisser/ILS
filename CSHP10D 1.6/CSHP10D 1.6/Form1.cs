﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP10D_1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(Color.Black);
            e.Graphics.DrawRectangle(stift, ClientRectangle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
