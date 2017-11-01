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

namespace latin_lab
{
    public partial class frmPacientes : Form
    {
        
        public frmPacientes()
        {
            InitializeComponent();
            CargarDistritos();
        }
        public void CargarDistritos() {
            using (ClinicaDBEntities context = new ClinicaDBEntities())
            {
                var distritos = from dis in context.Distritos select dis.nombreDistrito;
                AutoCompleteStringCollection source = new AutoCompleteStringCollection();
                source.AddRange(distritos.ToArray());
                TXTDISTRITO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TXTDISTRITO.AutoCompleteSource = AutoCompleteSource.CustomSource;
                TXTDISTRITO.AutoCompleteCustomSource = source;
                TXTLUGARNAC.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                TXTLUGARNAC.AutoCompleteSource = AutoCompleteSource.CustomSource;
                TXTLUGARNAC.AutoCompleteCustomSource = source;
            }
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
        public void CargarDistritos(AutoCompleteStringCollection src) {
            //TXTDISTRITO.AutoCompleteCustomSource = src;
            //TXTDISTRITO.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //TXTDISTRITO.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }       
        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            LimpiarErrores();
            AlternarMayuscula();
            if (Errores()) {
                MessageBox.Show("ok");
            }
        }
        public void AlternarMayuscula() {
            TXTPATERNO.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTPATERNO.Text);
            TXTMATERNO.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTMATERNO.Text);
            TXTFRSTNOMBRE.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTFRSTNOMBRE.Text);
            TXTSCNDNOMBRE.Text = new CultureInfo("en-US").TextInfo.ToTitleCase(TXTSCNDNOMBRE.Text);
            TXTDIRECCION.Text=new CultureInfo("en-US").TextInfo.ToTitleCase(TXTDIRECCION.Text);
        }
        private void TXTDISTRITO_TextChanged(object sender, EventArgs e)
        {
            TXTIDDISTRITO.Text = "";
            using (ClinicaDBEntities context = new ClinicaDBEntities()) {
                var id = from dis in context.Distritos where dis.nombreDistrito == TXTDISTRITO.Text select dis;
                List<Distritos> objDistrito = id.ToList();
                foreach (Distritos d in objDistrito) {
                    TXTIDDISTRITO.Text = d.idDistrito.ToString();
                }
            }
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
            TXTIDLUGARNAC.Text = "";
            using (ClinicaDBEntities context = new ClinicaDBEntities())
            {
                var id = from dis in context.Distritos where dis.nombreDistrito == TXTLUGARNAC.Text select dis;
                List<Distritos> objDistrito = id.ToList();
                foreach (Distritos d in objDistrito)
                {
                    TXTIDLUGARNAC.Text = d.idDistrito.ToString();
                }
            }
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
        public void LimpiarErrores() {
            PACIENTESERRORES.SetError(TXTPATERNO, null);
            PACIENTESERRORES.SetError(TXTMATERNO, null);
            PACIENTESERRORES.SetError(TXTFRSTNOMBRE, null);
            PACIENTESERRORES.SetError(CBSEXO, null);
        }
        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            BTNCANCELAR.Enabled = true;
            BTNACTUALIZAR.Enabled = false;
            BTNGUARDAR.Enabled = true;
            BTNIMPRIMIR.Enabled = false;
            TextBox[] txt = new TextBox[] {
                TXTPATERNO,TXTMATERNO,TXTFRSTNOMBRE,TXTSCNDNOMBRE,TXTLUGARNAC,
                TXTDOCID,TXTDIRECCION,TXTNRO,TXTINTERIOR,TXTMZA,TXTLOTE,
                TXTLOCALIDAD,TXTDISTRITO,TXTTELEFONO,TXTMOVIL,TXTTRABAJO
           };
            foreach (TextBox t in txt) {
                t.Enabled = true;
                t.ReadOnly = false;
            }
            DTNACIMIENTO.Enabled = true;
            CBSEXO.Enabled = true;
            CBTIPODOC.Enabled = true;
            CBVETERINARIA.Enabled = true;
            CBDISCAPACITADO.Enabled = true;
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
                TXTPATERNO,TXTMATERNO,TXTFRSTNOMBRE,TXTSCNDNOMBRE,TXTLUGARNAC,
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
    }

}
