using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using latin_lab.Util;
using System.Globalization;
using latin_lab.Entities;

namespace latin_lab
{
    public partial class frmPacientes : Form
    {
        
        public frmPacientes()
        {
            InitializeComponent();
        }

        public void habilitarComponentes1()
        {
            BTNCANCELAR.Enabled = true;
            BTNGUARDAR.Enabled = true;
            BTNIMPRIMIR.Enabled = false;
            BTNNUEVOREG.Enabled = false;
            TextBox[] txt = new TextBox[] {
                TXTPATERNO,TXTMATERNO,TXTFRSTNOMBRE,TXTSCNDNOMBRE,
                TXTDOCID,TXTDIRECCION,TXTNRO,TXTINTERIOR,TXTMZA,TXTLOTE,
                TXTLOCALIDAD,TXTTELEFONO,TXTMOVIL,TXTTRABAJO
            };
            foreach (TextBox t in txt)
            {
                t.Enabled = true;
                t.ReadOnly = false;
            }
            DTNACIMIENTO.Enabled = true;
            CBTIPOFINANCIADOR.Enabled = true;
            RTOBSERVACIONES.Enabled = true;
            CBSEXO.Enabled = true;
            CBTIPODOC.Enabled = true;
            CBVETERINARIA.Enabled = true;
            CBDISCAPACITADO.Enabled = true;
        }
        public void habilitarComponentes2()
        {
            BTNCANCELAR.Enabled = false;
            BTNGUARDAR.Enabled = false;
            BTNNUEVOREG.Enabled = true;
            TextBox[] txt = new TextBox[] {
                TXTPATERNO,TXTMATERNO,TXTFRSTNOMBRE,TXTSCNDNOMBRE,
                TXTDOCID,TXTDIRECCION,TXTNRO,TXTINTERIOR,TXTMZA,TXTLOTE,
                TXTLOCALIDAD,TXTTELEFONO,TXTMOVIL,TXTTRABAJO
            };
            foreach (TextBox t in txt)
            {
                t.Enabled = false;
                t.ReadOnly = true;
            }
            DTNACIMIENTO.Enabled = false;
            CBTIPOFINANCIADOR.Enabled = false;
            RTOBSERVACIONES.Enabled = false;
            CBSEXO.Enabled = false;
            CBTIPODOC.Enabled = false;
            CBVETERINARIA.Enabled = false;
            CBDISCAPACITADO.Enabled = false;
        }
        public void limpiarComponentes()
        {
            TextBox[] txt = new TextBox[] {
                TXTPATERNO,TXTMATERNO,TXTFRSTNOMBRE,TXTSCNDNOMBRE,
                TXTDOCID,TXTDIRECCION,TXTNRO,TXTINTERIOR,TXTMZA,TXTLOTE,
                TXTLOCALIDAD,TXTTELEFONO,TXTMOVIL,TXTTRABAJO
            };
            foreach (TextBox t in txt)
            {
                t.Text = "";
            }
            RTOBSERVACIONES.Text = "";
            CBSEXO.SelectedIndex = -1;
            CBTIPODOC.SelectedIndex = -1;
            CBTIPOFINANCIADOR.SelectedIndex = -1;
            CBVETERINARIA.Checked = false;
            CBDISCAPACITADO.Checked = false;
        }
        //KEYLISTENER QUE VERIFICA EL INGRESO DE NUMEROS
        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsUpper(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Convert.ToInt32(e.KeyChar) == 22)
            {
                e.Handled = true;
            }
        }
        //KEYLISTENER QUE VERIFICA EL INGRESO DE LETRAS
        private void SoloLetras(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }      
        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            LimpiarErrores();
            AlternarMayuscula();

            
            

            if (Errores()) {
                MessageBox.Show("ok"); ClinicaDBEntities db = new ClinicaDBEntities();
                Personas personas = new Personas();
                personas.aPaterno = TXTPATERNO.Text;
                personas.aMaterno = TXTMATERNO.Text;
                personas.prNombre = TXTFRSTNOMBRE.Text;
                personas.sgNombre = TXTSCNDNOMBRE.Text;
                personas.fechaNacimiento = DateTime.Parse(DTNACIMIENTO.Text);
                personas.sexo = CBSEXO.Text;
                personas.tipoDocumento = CBTIPODOC.Text;
                personas.numDocumento = TXTDOCID.Text;
                if (CBDISCAPACITADO.Checked) personas.discapacitado = true;
                else personas.discapacitado = false;
                personas.direccion = TXTDIRECCION.Text;
                personas.numDireccion = TXTNRO.Text;
                personas.intDireccion = TXTINTERIOR.Text;
                personas.lteDireccion = TXTLOTE.Text;
                personas.tipoLocalidad = CBTIPOLOCALIDAD.Text;
                personas.nombreLocalidad = TXTLOCALIDAD.Text;
                personas.idDistrito = Convert.ToInt32(TXTIDDISTRITO.Text);
                personas.estado = 1;
                db.Personas.Add(personas);
                db.SaveChanges();
                var id = (from pe in db.Personas orderby pe.idPersona descending select new { pe.idPersona }).Single();
                Pacientes pacientes = new Pacientes();
                pacientes.idPersona = id.idPersona;
                pacientes.tipoFinanciador = CBTIPOFINANCIADOR.Text;
                if (CBVETERINARIA.Checked) pacientes.veterinaria = true;
                else pacientes.veterinaria = false;
                pacientes.observacion = RTOBSERVACIONES.Text;
                pacientes.estado = 1;
                pacientes.nombreUsuario = "nombre del wei";
                pacientes.fechaCreacion = DateTime.Now;
                db.Pacientes.Add(pacientes);
                db.SaveChanges();
                MessageBox.Show("¿Desea imprimir el registro?");



                habilitarComponentes2();
                limpiarComponentes();
            }
            
        }
        public void AlternarMayuscula() {
            TXTPATERNO.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTPATERNO.Text);
            TXTMATERNO.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTMATERNO.Text);
            TXTFRSTNOMBRE.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTFRSTNOMBRE.Text);
            TXTSCNDNOMBRE.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTSCNDNOMBRE.Text);
            TXTDIRECCION.Text=new CultureInfo("en-US").TextInfo.ToTitleCase(TXTDIRECCION.Text);
        }
        
        private void DTNACIMIENTO_ValueChanged(object sender, EventArgs e)
        {
            TXTEDAD.Text   = "";
            TXTEDADMM.Text = "";
            TXTEDADDD.Text = "";
            if (DTNACIMIENTO.Value < DateTime.Today)
            {
                DateTime bday = DTNACIMIENTO.Value;
                DateTime cday = DateTime.Today;
                Age age = new Age(bday, cday);
                TXTEDAD.Text = age.Years.ToString();
                TXTEDADMM.Text = age.Months.ToString();
                TXTEDADDD.Text = age.Days.ToString();
            }
            else
            {
                TXTEDAD.Text = "";
                TXTEDADMM.Text = "";
                TXTEDADDD.Text = "";
                DTNACIMIENTO.Value = DateTime.Today;
            }
                    
        }
        private void TXTLUGARNAC_TextChanged(object sender, EventArgs e)
        {
            //TXTIDLUGARNAC.Text = "";
            //using (ClinicaDBEntities context = new ClinicaDBEntities())
            //{
            //    var id = from dis in context.Distritos where dis.nombre == TXTLUGARNAC.Text select dis;
            //    List<Distritos> objDistrito = id.ToList();
            //    foreach (Distritos d in objDistrito)
            //    {
            //        TXTIDLUGARNAC.Text = d.idDistrito.ToString();
            //    }
            //}
        }
        public bool Errores() {
            bool ok = true;
            if (TXTPATERNO.Text.Trim() == "") {
                PACIENTESERRORES.SetError(TXTPATERNO, "Ingresa el apellido paterno");
                ok = false;
            }
            if (TXTMATERNO.Text.Trim() == "") {
                PACIENTESERRORES.SetError(TXTMATERNO, "Ingresa el apellido materno");
                ok = false;
            }
            if (TXTFRSTNOMBRE.Text.Trim() == "") {
                PACIENTESERRORES.SetError(TXTFRSTNOMBRE, "Ingresa el nombre");
            }
            if (CBSEXO.SelectedIndex <= -1) {
                PACIENTESERRORES.SetError(CBSEXO, "Seleccione el sexo");
            }
            return ok;
        }
        public bool LimpiarErrores() {
            PACIENTESERRORES.SetError(TXTPATERNO, null);
            PACIENTESERRORES.SetError(TXTMATERNO, null);
            PACIENTESERRORES.SetError(TXTFRSTNOMBRE, null);
            PACIENTESERRORES.SetError(CBSEXO, null);
            return true;
        }
        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            LimpiarErrores();
            // TODO: MANEJAR QUE LOS DATOS DEL PACIENTE RETORNEN A SU ESTADO NORMAL
            BTNCANCELAR.Enabled = false;
            BTNACTUALIZAR.Enabled = true;
            BTNGUARDAR.Enabled = false;
            BTNIMPRIMIR.Enabled = true;
            TextBox[] txt = new TextBox[] {
                TXTPATERNO,TXTMATERNO,TXTFRSTNOMBRE,TXTSCNDNOMBRE,
                TXTDOCID,TXTDIRECCION,TXTNRO,TXTINTERIOR,TXTMZA,TXTLOTE,
                TXTLOCALIDAD,TXTDISTRITO,TXTTELEFONO,TXTMOVIL,TXTTRABAJO
            };
            foreach (TextBox t in txt)
            {
                t.Enabled = false;
                t.ReadOnly = true;
            }
            DTNACIMIENTO.Enabled = false;
            CBSEXO.Enabled = false;
            CBTIPODOC.Enabled = false;
            CBVETERINARIA.Enabled = false;
            CBDISCAPACITADO.Enabled = false;
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BTNUNIDADMED_Click(object sender, EventArgs e)
        {
            new frmBuscarDistrito(this).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmBuscarPaciente(this).ShowDialog();
        }

        private void frmPacientes_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //meneo aqui
                
            }
        }

        private void BTNNUEVOREG_Click(object sender, EventArgs e)
        {
            habilitarComponentes1();
            limpiarComponentes();
        }
    }

}
