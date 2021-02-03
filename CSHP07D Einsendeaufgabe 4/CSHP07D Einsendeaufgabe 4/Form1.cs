using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP07D_Einsendeaufgabe_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            label1.Top = 10;

           do
            {
                label1.Top+=30;
                Thread.Sleep(500);
                counter++;
            } while (counter < 10);
            
        }
    }
}
