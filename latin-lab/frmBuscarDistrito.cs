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
    public partial class frmBuscarDistrito : Form
    {
        frmPacientes frmPacientes;
        public frmBuscarDistrito(frmPacientes frmPacientes)
        {
            InitializeComponent();
            AlistarComponentes();
            this.frmPacientes = frmPacientes;
        }
        public void AlistarComponentes()
        {
            DGVWDISTRITOS.RowHeadersVisible = false;
        }

        private void TXTBUSCAR_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                ClinicaDBEntities context = new ClinicaDBEntities();
                var data = context.Distritos.Where(x=>x.nombreDistrito.StartsWith(TXTBUSCAR.Text))
                    .Select(x => new { x.idDistrito,x.nombreDistrito }).ToList();
                DGVWDISTRITOS.DataSource = data;
                DGVWDISTRITOS.Columns[0].Visible = false;
                DGVWDISTRITOS.Columns[1].HeaderText = "NOMBRE DE DISTRITO";
                DGVWDISTRITOS.Columns[1].Width = 220;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVWDISTRITOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGVWDISTRITOS.Rows[e.RowIndex];
            frmPacientes.TXTIDDISTRITO.Text = row.Cells[0].Value.ToString();
            frmPacientes.TXTDISTRITO.Text = row.Cells[1].Value.ToString();
            this.Close();
            this.Dispose();
        }
    }
}
