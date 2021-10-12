using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP11D_2
{
    public partial class NameDialog : Form
    {
        public NameDialog()
        {
            InitializeComponent();
        }

        private void NameDialog_Load(object sender, EventArgs e)
        {

        }

        public string LiefereName()
        {
            return textBox1.Text;
        }
    }
}
