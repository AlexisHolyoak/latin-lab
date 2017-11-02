using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace latin_lab
{
    public partial class frmTarifario : Form
    {
        public frmTarifario()
        {
            InitializeComponent();
        }

        private void BTNCLASE_Click(object sender, EventArgs e)
        {
            new frmClaseServicio().ShowDialog();
        }

        private void BTNUNIDADMED_Click(object sender, EventArgs e)
        {
            new frmUnidadMedida().ShowDialog();
        }
    }
}
