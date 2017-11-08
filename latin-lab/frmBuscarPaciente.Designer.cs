namespace latin_lab
{
    partial class frmBuscarPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVWPACIENTES = new System.Windows.Forms.DataGridView();
            this.TXTBUSCAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWPACIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVWPACIENTES
            // 
            this.DGVWPACIENTES.AllowUserToAddRows = false;
            this.DGVWPACIENTES.AllowUserToDeleteRows = false;
            this.DGVWPACIENTES.AllowUserToResizeRows = false;
            this.DGVWPACIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVWPACIENTES.Location = new System.Drawing.Point(12, 69);
            this.DGVWPACIENTES.Name = "DGVWPACIENTES";
            this.DGVWPACIENTES.ReadOnly = true;
            this.DGVWPACIENTES.Size = new System.Drawing.Size(444, 175);
            this.DGVWPACIENTES.TabIndex = 0;
            this.DGVWPACIENTES.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVWPACIENTES_CellDoubleClick);
            // 
            // TXTBUSCAR
            // 
            this.TXTBUSCAR.Location = new System.Drawing.Point(214, 30);
            this.TXTBUSCAR.Name = "TXTBUSCAR";
            this.TXTBUSCAR.Size = new System.Drawing.Size(152, 20);
            this.TXTBUSCAR.TabIndex = 1;
            this.TXTBUSCAR.TextChanged += new System.EventHandler(this.TXTBUSCAR_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese apellido:";
            // 
            // frmBuscarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBUSCAR);
            this.Controls.Add(this.DGVWPACIENTES);
            this.Name = "frmBuscarPaciente";
            this.Text = "frmBuscarPaciente";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DGVWPACIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVWPACIENTES;
        private System.Windows.Forms.TextBox TXTBUSCAR;
        private System.Windows.Forms.Label label1;
    }
}