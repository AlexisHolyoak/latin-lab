using latin_lab.Entities;
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

        //rellenar los datos del paciente en frmPaciente
        private void DGVWPACIENTES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) 
            {
                DataGridViewRow row = this.DGVWPACIENTES.Rows[e.RowIndex];
                int idPaciente = (int)row.Cells[0].Value;
                
                ClinicaDBEntities db = new ClinicaDBEntities();
                var data = (from pa in db.Pacientes
                            join pe in db.Personas on pa.idPersona equals pe.idPersona
                            select new
                            {
                                pa.numeroHistoria,
                                pa.estado,
                                pe.aPaterno,
                                pe.aMaterno,
                                pe.prNombre,
                                pe.sgNombre,
                                pe.fechaNacimiento,
                                pe.sexo,
                                pe.Distritos.idDistrito,
                                pe.Distritos.nombre,
                                pe.tipoDocumento,
                                pe.numDocumento,
                                pe.discapacitado,
                                pe.direccion,
                                pe.numDireccion,
                                pe.intDireccion,
                                pe.mzaDireccion,
                                pe.lteDireccion,
                                pe.tipoLocalidad,
                                pe.nombreLocalidad,
                                pe.telefono,
                                pe.celular,
                                pe.trabajo,
                                pa.tipoFinanciador,
                                pa.veterinaria,
                                pa.observacion
                            }).Single();
                frmPacientes.TXTHISTORIA.Text = data.numeroHistoria;
                if (data.estado == 1) frmPacientes.TXTESTADO.Text = "ACTIVO";
                else frmPacientes.TXTESTADO.Text = "INACTIVO";
                frmPacientes.TXTPATERNO.Text = data.aPaterno;
                frmPacientes.TXTMATERNO.Text = data.aMaterno;
                frmPacientes.TXTFRSTNOMBRE.Text = data.prNombre;
                frmPacientes.TXTSCNDNOMBRE.Text = data.sgNombre;
                frmPacientes.DTNACIMIENTO.Text = data.fechaNacimiento.ToString();
                frmPacientes.CBSEXO.Text = data.sexo;
                frmPacientes.CBTIPODOC.Text = data.tipoDocumento;
                frmPacientes.TXTDOCID.Text = data.numDocumento;
                if (data.discapacitado == true) frmPacientes.CBDISCAPACITADO.Checked = true;
                frmPacientes.TXTDIRECCION.Text = data.direccion;
                frmPacientes.TXTNRO.Text = data.numDireccion;
                frmPacientes.TXTINTERIOR.Text = data.intDireccion;
                frmPacientes.TXTMZA.Text = data.mzaDireccion;
                frmPacientes.TXTLOTE.Text = data.lteDireccion;
                frmPacientes.CBTIPOLOCALIDAD.Text = data.tipoLocalidad;
                frmPacientes.TXTLOCALIDAD.Text = data.nombreLocalidad;
                frmPacientes.TXTIDDISTRITO.Text = data.idDistrito.ToString();
                frmPacientes.TXTDISTRITO.Text = data.nombre;
                frmPacientes.TXTTELEFONO.Text = data.telefono;
                frmPacientes.TXTMOVIL.Text = data.celular;
                frmPacientes.TXTTRABAJO.Text = data.trabajo;
                frmPacientes.CBTIPOFINANCIADOR.Text = data.tipoFinanciador;
                frmPacientes.RTOBSERVACIONES.Text = data.observacion;
                if (data.veterinaria == true) frmPacientes.CBVETERINARIA.Checked = true;
                frmPacientes.BTNACTUALIZAR.Enabled = true;
                frmPacientes.BTNIMPRIMIR.Enabled = true;
                this.Close();
                this.Dispose();
            }
        }

        private void TXTBUSCAR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClinicaDBEntities context = new ClinicaDBEntities();
                // aqui se debe buscar pacientes
                var data = (from pa in context.Pacientes
                            join pe in context.Personas on pa.idPersona equals pe.idPersona
                            where ((pe.aPaterno + " " + pe.aMaterno).StartsWith(TXTBUSCAR.Text))
                            select new { pa.idPaciente,pe.aPaterno, pe.aMaterno, pe.prNombre, pe.sgNombre }).ToList();
                //var data = context.Pacientes
                //    .Join(context.Personas, pa => pa.idPersona, pe => pe.idPersona, (pa, pe) => new { pa, pe })
                //    .Where(x => (x.pe.aPaterno + " " + x.pe.aMaterno).StartsWith(TXTBUSCAR.Text))
                //    .Select(x => new { x.pa.idPaciente,x.pe.aPaterno, x.pe.aMaterno, x.pe.prNombre, x.pe.sgNombre }).ToList();
                DGVWPACIENTES.DataSource = data;
                DGVWPACIENTES.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
