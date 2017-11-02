namespace latin_lab
{
    partial class frmClaseServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNACEPTAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 22);
            this.textBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(477, 128);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "CANTIDAD DE REGISTROS";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(40, 265);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(163, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "INCLUIR ANULADOS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Image = global::latin_lab.Properties.Resources.ic_exit_to_app_black_24dp_1x;
            this.BTNSALIR.Location = new System.Drawing.Point(406, 285);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(128, 50);
            this.BTNSALIR.TabIndex = 40;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNSALIR.UseVisualStyleBackColor = true;
            // 
            // BTNACEPTAR
            // 
            this.BTNACEPTAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACEPTAR.Image = global::latin_lab.Properties.Resources.ic_done_black_24dp_1x;
            this.BTNACEPTAR.Location = new System.Drawing.Point(231, 285);
            this.BTNACEPTAR.Name = "BTNACEPTAR";
            this.BTNACEPTAR.Size = new System.Drawing.Size(169, 50);
            this.BTNACEPTAR.TabIndex = 39;
            this.BTNACEPTAR.Text = "ACEPTAR";
            this.BTNACEPTAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNACEPTAR.UseVisualStyleBackColor = true;
            // 
            // frmClaseServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 347);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.BTNACEPTAR);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClaseServicio";
            this.Text = "CLASE DEL SERVICIO";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BTNACEPTAR;
        private System.Windows.Forms.Button BTNSALIR;
    }
}