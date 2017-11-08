namespace latin_lab
{
    partial class frmBuscarDistrito
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
            this.DGVWDISTRITOS = new System.Windows.Forms.DataGridView();
            this.TXTBUSCAR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVWDISTRITOS)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVWDISTRITOS
            // 
            this.DGVWDISTRITOS.AllowUserToAddRows = false;
            this.DGVWDISTRITOS.AllowUserToDeleteRows = false;
            this.DGVWDISTRITOS.AllowUserToResizeRows = false;
            this.DGVWDISTRITOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVWDISTRITOS.Location = new System.Drawing.Point(12, 55);
            this.DGVWDISTRITOS.Name = "DGVWDISTRITOS";
            this.DGVWDISTRITOS.ReadOnly = true;
            this.DGVWDISTRITOS.Size = new System.Drawing.Size(240, 150);
            this.DGVWDISTRITOS.TabIndex = 0;
            this.DGVWDISTRITOS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVWDISTRITOS_CellDoubleClick);
            // 
            // TXTBUSCAR
            // 
            this.TXTBUSCAR.Location = new System.Drawing.Point(133, 20);
            this.TXTBUSCAR.Name = "TXTBUSCAR";
            this.TXTBUSCAR.Size = new System.Drawing.Size(100, 20);
            this.TXTBUSCAR.TabIndex = 1;
            this.TXTBUSCAR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTBUSCAR_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de distrito:";
            // 
            // frmDistritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTBUSCAR);
            this.Controls.Add(this.DGVWDISTRITOS);
            this.Name = "frmDistritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDistritos";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DGVWDISTRITOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVWDISTRITOS;
        private System.Windows.Forms.TextBox TXTBUSCAR;
        private System.Windows.Forms.Label label1;
    }
}