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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
           
            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
                            {
                        "Huaura",
                        "Huacho",
                        "Lima"                        
                            });
            CargarDistritos(source);
        }
        public void CargarDistritos(AutoCompleteStringCollection src) {
            TXTDISTRITO.AutoCompleteCustomSource = src;
            TXTDISTRITO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TXTDISTRITO.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            var test = TXTDISTRITO.AutoCompleteCustomSource;
            foreach (String s in test) {
                if (s != TXTDISTRITO.Text) {
                    MessageBox.Show(TXTDISTRITO.Text);
                }
            }
        }
    }

}
