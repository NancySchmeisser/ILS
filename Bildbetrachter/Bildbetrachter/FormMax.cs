using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class FormMax : Form
    {
        public FormMax()
        {
            InitializeComponent();
        }

        public void BildLaden(string bildname)
        {
            pictureBoxFormMax.Load(bildname);
        }

        private void pictureBoxFormMax_Click(object sender, EventArgs e)
        {

        }
    }
}
