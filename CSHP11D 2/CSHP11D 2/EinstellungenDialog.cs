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
    public partial class EinstellungenDialog : Form
    {
        public EinstellungenDialog()
        {
            InitializeComponent();
        }

     

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
