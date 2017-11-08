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
    public partial class frmBuscarPaciente : Form
    {
        frmPacientes frmPacientes;
        public frmBuscarPaciente(frmPacientes frmPacientes)
        {
            InitializeComponent();
            AlistarComponentes();
            this.frmPacientes = frmPacientes;
        }
        public void AlistarComponentes()
        {
            DGVWPACIENTES.RowHeadersVisible = false;
        }
        private void DGVWPACIENTES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //rellenar los datos del paciente en frmPaciente
            frmPacientes.TXTHISTORIA.Text = "pan con pollo";
            this.Close();
            this.Dispose();
        }

        private void TXTBUSCAR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClinicaDBEntities context = new ClinicaDBEntities();
                // aqui se debe buscar pacientes
                var data = context.Departamentos.ToList();
                DGVWPACIENTES.DataSource = data;
                DGVWPACIENTES.Columns["idDepartamento"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
