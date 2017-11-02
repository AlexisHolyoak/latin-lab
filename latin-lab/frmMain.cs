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
    public partial class frmMain : Form
    {
        private Label label1;
        private MonthCalendar monthCalendar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private ToolStripMenuItem PACIENTESTOOL;
        private ToolStripMenuItem oRDENESToolStripMenuItem;
        private ToolStripMenuItem EXAMENESTOOL;
        private ToolStripMenuItem pAGOSToolStripMenuItem;
        private ToolStripMenuItem tARJETASToolStripMenuItem;
        private ToolStripMenuItem eTIQUETASToolStripMenuItem;
        private ToolStripMenuItem rESULTADOSToolStripMenuItem;
        private ToolStripMenuItem hISTORIAToolStripMenuItem;
        private ToolStripMenuItem cONFIGURACIONESToolStripMenuItem;
        private ToolStripMenuItem rEGISTROToolStripMenuItem1;
        private ToolStripMenuItem uSUARIOSToolStripMenuItem;
        private ToolStripMenuItem rEGISTROToolStripMenuItem2;
        private ToolStripMenuItem aCTUALIZACIONToolStripMenuItem2;
        private ToolStripMenuItem cONSULTAToolStripMenuItem2;
        private ToolStripMenuItem rEPORTESToolStripMenuItem;
        private Label label2;
        private ToolStripMenuItem bACKUPToolStripMenuItem;
        private ToolStripMenuItem rESTAURACIONESToolStripMenuItem;
        private ToolStripMenuItem sERVIDORToolStripMenuItem;
        private ToolStripMenuItem TARIFARIOTOOL;
        private Label TXTNOMBREUSUARIO;

        public frmMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TXTNOMBREUSUARIO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PACIENTESTOOL = new System.Windows.Forms.ToolStripMenuItem();
            this.oRDENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXAMENESTOOL = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TARIFARIOTOOL = new System.Windows.Forms.ToolStripMenuItem();
            this.tARJETASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eTIQUETASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESULTADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTORIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aCTUALIZACIONToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bACKUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESTAURACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVIDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENID@";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(624, 358);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // TXTNOMBREUSUARIO
            // 
            this.TXTNOMBREUSUARIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TXTNOMBREUSUARIO.AutoSize = true;
            this.TXTNOMBREUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTNOMBREUSUARIO.Location = new System.Drawing.Point(200, 539);
            this.TXTNOMBREUSUARIO.Name = "TXTNOMBREUSUARIO";
            this.TXTNOMBREUSUARIO.Size = new System.Drawing.Size(83, 26);
            this.TXTNOMBREUSUARIO.TabIndex = 2;
            this.TXTNOMBREUSUARIO.Text = "usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.cONFIGURACIONESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 54);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PACIENTESTOOL,
            this.oRDENESToolStripMenuItem,
            this.EXAMENESTOOL,
            this.pAGOSToolStripMenuItem,
            this.tARJETASToolStripMenuItem,
            this.eTIQUETASToolStripMenuItem,
            this.rESULTADOSToolStripMenuItem,
            this.hISTORIAToolStripMenuItem,
            this.uSUARIOSToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mENUToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.mENUToolStripMenuItem.Image = global::latin_lab.Properties.Resources.Start_Menu_Program_Defaults_icon;
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(86, 50);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // PACIENTESTOOL
            // 
            this.PACIENTESTOOL.Image = global::latin_lab.Properties.Resources.Places_user_identity_icon;
            this.PACIENTESTOOL.Name = "PACIENTESTOOL";
            this.PACIENTESTOOL.Size = new System.Drawing.Size(181, 26);
            this.PACIENTESTOOL.Text = "PACIENTES";
            this.PACIENTESTOOL.Click += new System.EventHandler(this.PACIENTESTOOL_Click);
            // 
            // oRDENESToolStripMenuItem
            // 
            this.oRDENESToolStripMenuItem.Image = global::latin_lab.Properties.Resources.Status_mail_task_icon;
            this.oRDENESToolStripMenuItem.Name = "oRDENESToolStripMenuItem";
            this.oRDENESToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.oRDENESToolStripMenuItem.Text = "ORDENES";
            // 
            // EXAMENESTOOL
            // 
            this.EXAMENESTOOL.Image = global::latin_lab.Properties.Resources.Mind_Map_Paper_icon;
            this.EXAMENESTOOL.Name = "EXAMENESTOOL";
            this.EXAMENESTOOL.Size = new System.Drawing.Size(181, 26);
            this.EXAMENESTOOL.Text = "EXAMENES";
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROToolStripMenuItem1,
            this.TARIFARIOTOOL});
            this.pAGOSToolStripMenuItem.Image = global::latin_lab.Properties.Resources.payment_icon;
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            // 
            // rEGISTROToolStripMenuItem1
            // 
            this.rEGISTROToolStripMenuItem1.Name = "rEGISTROToolStripMenuItem1";
            this.rEGISTROToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.rEGISTROToolStripMenuItem1.Text = "REGISTROS";
            // 
            // TARIFARIOTOOL
            // 
            this.TARIFARIOTOOL.Name = "TARIFARIOTOOL";
            this.TARIFARIOTOOL.Size = new System.Drawing.Size(181, 26);
            this.TARIFARIOTOOL.Text = "TARIFARIO";
            this.TARIFARIOTOOL.Click += new System.EventHandler(this.TARIFARIOTOOL_Click);
            // 
            // tARJETASToolStripMenuItem
            // 
            this.tARJETASToolStripMenuItem.Image = global::latin_lab.Properties.Resources.Drives_SD_Card_Metro_icon;
            this.tARJETASToolStripMenuItem.Name = "tARJETASToolStripMenuItem";
            this.tARJETASToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.tARJETASToolStripMenuItem.Text = "TARJETAS";
            // 
            // eTIQUETASToolStripMenuItem
            // 
            this.eTIQUETASToolStripMenuItem.Image = global::latin_lab.Properties.Resources.tag_alt_icon;
            this.eTIQUETASToolStripMenuItem.Name = "eTIQUETASToolStripMenuItem";
            this.eTIQUETASToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.eTIQUETASToolStripMenuItem.Text = "ETIQUETAS";
            // 
            // rESULTADOSToolStripMenuItem
            // 
            this.rESULTADOSToolStripMenuItem.Image = global::latin_lab.Properties.Resources.application_search_result_icon;
            this.rESULTADOSToolStripMenuItem.Name = "rESULTADOSToolStripMenuItem";
            this.rESULTADOSToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rESULTADOSToolStripMenuItem.Text = "RESULTADOS";
            // 
            // hISTORIAToolStripMenuItem
            // 
            this.hISTORIAToolStripMenuItem.Image = global::latin_lab.Properties.Resources.File_History_icon;
            this.hISTORIAToolStripMenuItem.Name = "hISTORIAToolStripMenuItem";
            this.hISTORIAToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hISTORIAToolStripMenuItem.Text = "HISTORIA";
            // 
            // uSUARIOSToolStripMenuItem
            // 
            this.uSUARIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROToolStripMenuItem2,
            this.aCTUALIZACIONToolStripMenuItem2,
            this.cONSULTAToolStripMenuItem2});
            this.uSUARIOSToolStripMenuItem.Image = global::latin_lab.Properties.Resources.User_Group_icon;
            this.uSUARIOSToolStripMenuItem.Name = "uSUARIOSToolStripMenuItem";
            this.uSUARIOSToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.uSUARIOSToolStripMenuItem.Text = "USUARIOS";
            // 
            // rEGISTROToolStripMenuItem2
            // 
            this.rEGISTROToolStripMenuItem2.Name = "rEGISTROToolStripMenuItem2";
            this.rEGISTROToolStripMenuItem2.Size = new System.Drawing.Size(205, 26);
            this.rEGISTROToolStripMenuItem2.Text = "REGISTRO";
            // 
            // aCTUALIZACIONToolStripMenuItem2
            // 
            this.aCTUALIZACIONToolStripMenuItem2.Name = "aCTUALIZACIONToolStripMenuItem2";
            this.aCTUALIZACIONToolStripMenuItem2.Size = new System.Drawing.Size(205, 26);
            this.aCTUALIZACIONToolStripMenuItem2.Text = "ACTUALIZACION";
            // 
            // cONSULTAToolStripMenuItem2
            // 
            this.cONSULTAToolStripMenuItem2.Name = "cONSULTAToolStripMenuItem2";
            this.cONSULTAToolStripMenuItem2.Size = new System.Drawing.Size(205, 26);
            this.cONSULTAToolStripMenuItem2.Text = "CONSULTA";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.Image = global::latin_lab.Properties.Resources.Product_sale_report_icon;
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // cONFIGURACIONESToolStripMenuItem
            // 
            this.cONFIGURACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bACKUPToolStripMenuItem,
            this.rESTAURACIONESToolStripMenuItem,
            this.sERVIDORToolStripMenuItem});
            this.cONFIGURACIONESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.cONFIGURACIONESToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.cONFIGURACIONESToolStripMenuItem.Image = global::latin_lab.Properties.Resources.Settings_L_icon;
            this.cONFIGURACIONESToolStripMenuItem.Name = "cONFIGURACIONESToolStripMenuItem";
            this.cONFIGURACIONESToolStripMenuItem.Size = new System.Drawing.Size(182, 50);
            this.cONFIGURACIONESToolStripMenuItem.Text = "CONFIGURACIONES";
            // 
            // bACKUPToolStripMenuItem
            // 
            this.bACKUPToolStripMenuItem.Image = global::latin_lab.Properties.Resources.ModernXP_54_Folder_Backup_Scheduled_icon;
            this.bACKUPToolStripMenuItem.Name = "bACKUPToolStripMenuItem";
            this.bACKUPToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.bACKUPToolStripMenuItem.Text = "BACKUP";
            // 
            // rESTAURACIONESToolStripMenuItem
            // 
            this.rESTAURACIONESToolStripMenuItem.Image = global::latin_lab.Properties.Resources.Drive_Restore_icon;
            this.rESTAURACIONESToolStripMenuItem.Name = "rESTAURACIONESToolStripMenuItem";
            this.rESTAURACIONESToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.rESTAURACIONESToolStripMenuItem.Text = "RESTAURACIONES";
            // 
            // sERVIDORToolStripMenuItem
            // 
            this.sERVIDORToolStripMenuItem.Image = global::latin_lab.Properties.Resources.cloud_icon;
            this.sERVIDORToolStripMenuItem.Name = "sERVIDORToolStripMenuItem";
            this.sERVIDORToolStripMenuItem.Size = new System.Drawing.Size(214, 26);
            this.sERVIDORToolStripMenuItem.Text = "SERVIDOR";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.sALIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sALIRToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.sALIRToolStripMenuItem.Image = global::latin_lab.Properties.Resources.actions_window_close_icon;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(83, 50);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(767, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "LATIN LAB";
            // 
            // frmMain
            // 
            this.BackgroundImage = global::latin_lab.Properties.Resources.laboratorio1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(932, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTNOMBREUSUARIO);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.Text = "LATIN LAB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void PACIENTESTOOL_Click(object sender, EventArgs e)
        {
            new frmPacientes().Show();
        }

        private void TARIFARIOTOOL_Click(object sender, EventArgs e)
        {
            new frmTarifario().Show();
        }
    }
}
