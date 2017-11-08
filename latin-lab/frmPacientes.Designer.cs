namespace latin_lab
{
    partial class frmPacientes
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
            this.components = new System.ComponentModel.Container();
            this.TXTHISTORIA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBUBICACIONARCHIVO = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXTLUGARNAC = new System.Windows.Forms.TextBox();
            this.TXTIDLUGARNAC = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TXTEDADDD = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TXTEDADMM = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TXTDOCID = new System.Windows.Forms.TextBox();
            this.CBDISCAPACITADO = new System.Windows.Forms.CheckBox();
            this.CBTIPODOC = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CBSEXO = new System.Windows.Forms.ComboBox();
            this.TXTEDAD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTMATERNO = new System.Windows.Forms.TextBox();
            this.TXTSCNDNOMBRE = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTNUNIDADMED = new System.Windows.Forms.Button();
            this.TXTIDDISTRITO = new System.Windows.Forms.TextBox();
            this.TXTTRABAJO = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.TXTMOVIL = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TXTTELEFONO = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TXTDISTRITO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TXTLOCALIDAD = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TXTLOTE = new System.Windows.Forms.TextBox();
            this.TXTMZA = new System.Windows.Forms.TextBox();
            this.TXTINTERIOR = new System.Windows.Forms.TextBox();
            this.TXTNRO = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TXTDIRECCION = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CBTIPOFINANCIADOR = new System.Windows.Forms.ComboBox();
            this.TXTFRSTNOMBRE = new System.Windows.Forms.TextBox();
            this.PACIENTESERRORES = new System.Windows.Forms.ErrorProvider(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.RTOBSERVACIONES = new System.Windows.Forms.RichTextBox();
            this.BTNNOATENCION = new System.Windows.Forms.Button();
            this.TXTPATERNO = new System.Windows.Forms.TextBox();
            this.CBVETERINARIA = new System.Windows.Forms.CheckBox();
            this.BTNSALIR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNIMPRIMIR = new System.Windows.Forms.Button();
            this.BTNACTUALIZAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PACIENTESERRORES)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTHISTORIA
            // 
            this.TXTHISTORIA.Location = new System.Drawing.Point(75, 5);
            this.TXTHISTORIA.Margin = new System.Windows.Forms.Padding(2);
            this.TXTHISTORIA.Name = "TXTHISTORIA";
            this.TXTHISTORIA.Size = new System.Drawing.Size(107, 20);
            this.TXTHISTORIA.TabIndex = 0;
            this.TXTHISTORIA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HISTORIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ESTADO DEL REGISTRO";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(602, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "NOMBRES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "UBICACION EN EL ARCHIVO";
            // 
            // CBUBICACIONARCHIVO
            // 
            this.CBUBICACIONARCHIVO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUBICACIONARCHIVO.FormattingEnabled = true;
            this.CBUBICACIONARCHIVO.Location = new System.Drawing.Point(619, 86);
            this.CBUBICACIONARCHIVO.Margin = new System.Windows.Forms.Padding(2);
            this.CBUBICACIONARCHIVO.Name = "CBUBICACIONARCHIVO";
            this.CBUBICACIONARCHIVO.Size = new System.Drawing.Size(120, 21);
            this.CBUBICACIONARCHIVO.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TXTLUGARNAC);
            this.panel1.Controls.Add(this.TXTIDLUGARNAC);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.TXTEDADDD);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.TXTEDADMM);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.TXTDOCID);
            this.panel1.Controls.Add(this.CBDISCAPACITADO);
            this.panel1.Controls.Add(this.CBTIPODOC);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CBSEXO);
            this.panel1.Controls.Add(this.TXTEDAD);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.DTNACIMIENTO);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(9, 121);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 108);
            this.panel1.TabIndex = 9;
            // 
            // TXTLUGARNAC
            // 
            this.TXTLUGARNAC.Location = new System.Drawing.Point(206, 53);
            this.TXTLUGARNAC.Margin = new System.Windows.Forms.Padding(2);
            this.TXTLUGARNAC.Name = "TXTLUGARNAC";
            this.TXTLUGARNAC.ReadOnly = true;
            this.TXTLUGARNAC.Size = new System.Drawing.Size(216, 20);
            this.TXTLUGARNAC.TabIndex = 9;
            this.TXTLUGARNAC.TextChanged += new System.EventHandler(this.TXTLUGARNAC_TextChanged);
            // 
            // TXTIDLUGARNAC
            // 
            this.TXTIDLUGARNAC.Location = new System.Drawing.Point(142, 53);
            this.TXTIDLUGARNAC.Margin = new System.Windows.Forms.Padding(2);
            this.TXTIDLUGARNAC.Name = "TXTIDLUGARNAC";
            this.TXTIDLUGARNAC.ReadOnly = true;
            this.TXTIDLUGARNAC.Size = new System.Drawing.Size(60, 20);
            this.TXTIDLUGARNAC.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(434, 6);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 13);
            this.label25.TabIndex = 27;
            this.label25.Text = "dd";
            // 
            // TXTEDADDD
            // 
            this.TXTEDADDD.Location = new System.Drawing.Point(404, 5);
            this.TXTEDADDD.Margin = new System.Windows.Forms.Padding(2);
            this.TXTEDADDD.Name = "TXTEDADDD";
            this.TXTEDADDD.ReadOnly = true;
            this.TXTEDADDD.Size = new System.Drawing.Size(29, 20);
            this.TXTEDADDD.TabIndex = 26;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(378, 6);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 13);
            this.label24.TabIndex = 25;
            this.label24.Text = "mm";
            // 
            // TXTEDADMM
            // 
            this.TXTEDADMM.Location = new System.Drawing.Point(349, 5);
            this.TXTEDADMM.Margin = new System.Windows.Forms.Padding(2);
            this.TXTEDADMM.Name = "TXTEDADMM";
            this.TXTEDADMM.ReadOnly = true;
            this.TXTEDADMM.Size = new System.Drawing.Size(29, 20);
            this.TXTEDADMM.TabIndex = 24;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(328, 7);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(19, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "aa";
            // 
            // TXTDOCID
            // 
            this.TXTDOCID.Location = new System.Drawing.Point(218, 76);
            this.TXTDOCID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDOCID.Name = "TXTDOCID";
            this.TXTDOCID.ReadOnly = true;
            this.TXTDOCID.Size = new System.Drawing.Size(164, 20);
            this.TXTDOCID.TabIndex = 10;
            this.TXTDOCID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // CBDISCAPACITADO
            // 
            this.CBDISCAPACITADO.AutoSize = true;
            this.CBDISCAPACITADO.Enabled = false;
            this.CBDISCAPACITADO.Location = new System.Drawing.Point(616, 81);
            this.CBDISCAPACITADO.Margin = new System.Windows.Forms.Padding(2);
            this.CBDISCAPACITADO.Name = "CBDISCAPACITADO";
            this.CBDISCAPACITADO.Size = new System.Drawing.Size(112, 17);
            this.CBDISCAPACITADO.TabIndex = 9;
            this.CBDISCAPACITADO.Text = "DISCAPACITADO";
            this.CBDISCAPACITADO.UseVisualStyleBackColor = true;
            // 
            // CBTIPODOC
            // 
            this.CBTIPODOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTIPODOC.DropDownWidth = 250;
            this.CBTIPODOC.FormattingEnabled = true;
            this.CBTIPODOC.Items.AddRange(new object[] {
            "REGISTRO UNICO DE CONTRIBUYENTE",
            "DOCUMENTO NACIONAL DE IDENTIDAD",
            "CARNET DE EXTRANJERIA",
            "PASAPORTE",
            "CEDULA DIPLOMATICA DE IDENTIDAD"});
            this.CBTIPODOC.Location = new System.Drawing.Point(142, 76);
            this.CBTIPODOC.Margin = new System.Windows.Forms.Padding(2);
            this.CBTIPODOC.Name = "CBTIPODOC";
            this.CBTIPODOC.Size = new System.Drawing.Size(60, 21);
            this.CBTIPODOC.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "DOC. ID. PAC.";
            // 
            // CBSEXO
            // 
            this.CBSEXO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSEXO.FormattingEnabled = true;
            this.CBSEXO.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.CBSEXO.Location = new System.Drawing.Point(142, 28);
            this.CBSEXO.Margin = new System.Windows.Forms.Padding(2);
            this.CBSEXO.Name = "CBSEXO";
            this.CBSEXO.Size = new System.Drawing.Size(114, 21);
            this.CBSEXO.TabIndex = 8;
            // 
            // TXTEDAD
            // 
            this.TXTEDAD.Location = new System.Drawing.Point(299, 5);
            this.TXTEDAD.Margin = new System.Windows.Forms.Padding(2);
            this.TXTEDAD.Name = "TXTEDAD";
            this.TXTEDAD.ReadOnly = true;
            this.TXTEDAD.Size = new System.Drawing.Size(29, 20);
            this.TXTEDAD.TabIndex = 5;
            this.TXTEDAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "EDAD";
            // 
            // DTNACIMIENTO
            // 
            this.DTNACIMIENTO.Enabled = false;
            this.DTNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNACIMIENTO.Location = new System.Drawing.Point(142, 5);
            this.DTNACIMIENTO.Margin = new System.Windows.Forms.Padding(2);
            this.DTNACIMIENTO.Name = "DTNACIMIENTO";
            this.DTNACIMIENTO.Size = new System.Drawing.Size(114, 20);
            this.DTNACIMIENTO.TabIndex = 7;
            this.DTNACIMIENTO.ValueChanged += new System.EventHandler(this.DTNACIMIENTO_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "LUGAR NAC.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "SEXO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "FECHA DE NACIMIENTO";
            // 
            // TXTMATERNO
            // 
            this.TXTMATERNO.Location = new System.Drawing.Point(302, 57);
            this.TXTMATERNO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMATERNO.Name = "TXTMATERNO";
            this.TXTMATERNO.ReadOnly = true;
            this.TXTMATERNO.Size = new System.Drawing.Size(130, 20);
            this.TXTMATERNO.TabIndex = 3;
            this.TXTMATERNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // TXTSCNDNOMBRE
            // 
            this.TXTSCNDNOMBRE.Location = new System.Drawing.Point(302, 86);
            this.TXTSCNDNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.TXTSCNDNOMBRE.Name = "TXTSCNDNOMBRE";
            this.TXTSCNDNOMBRE.ReadOnly = true;
            this.TXTSCNDNOMBRE.Size = new System.Drawing.Size(130, 20);
            this.TXTSCNDNOMBRE.TabIndex = 5;
            this.TXTSCNDNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.TXTHISTORIA);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Location = new System.Drawing.Point(9, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 45);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::latin_lab.Properties.Resources.Zoom_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(186, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.BTNUNIDADMED);
            this.panel3.Controls.Add(this.TXTIDDISTRITO);
            this.panel3.Controls.Add(this.TXTTRABAJO);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.TXTMOVIL);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.TXTTELEFONO);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.TXTDISTRITO);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.TXTLOCALIDAD);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.TXTLOTE);
            this.panel3.Controls.Add(this.TXTMZA);
            this.panel3.Controls.Add(this.TXTINTERIOR);
            this.panel3.Controls.Add(this.TXTNRO);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.TXTDIRECCION);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(9, 235);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 98);
            this.panel3.TabIndex = 15;
            // 
            // BTNUNIDADMED
            // 
            this.BTNUNIDADMED.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUNIDADMED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTNUNIDADMED.Location = new System.Drawing.Point(400, 72);
            this.BTNUNIDADMED.Margin = new System.Windows.Forms.Padding(2);
            this.BTNUNIDADMED.Name = "BTNUNIDADMED";
            this.BTNUNIDADMED.Size = new System.Drawing.Size(21, 19);
            this.BTNUNIDADMED.TabIndex = 22;
            this.BTNUNIDADMED.Text = "+";
            this.BTNUNIDADMED.UseVisualStyleBackColor = true;
            this.BTNUNIDADMED.Click += new System.EventHandler(this.BTNUNIDADMED_Click);
            // 
            // TXTIDDISTRITO
            // 
            this.TXTIDDISTRITO.Location = new System.Drawing.Point(142, 71);
            this.TXTIDDISTRITO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTIDDISTRITO.Name = "TXTIDDISTRITO";
            this.TXTIDDISTRITO.ReadOnly = true;
            this.TXTIDDISTRITO.Size = new System.Drawing.Size(60, 20);
            this.TXTIDDISTRITO.TabIndex = 21;
            // 
            // TXTTRABAJO
            // 
            this.TXTTRABAJO.Location = new System.Drawing.Point(602, 51);
            this.TXTTRABAJO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTRABAJO.Name = "TXTTRABAJO";
            this.TXTTRABAJO.ReadOnly = true;
            this.TXTTRABAJO.Size = new System.Drawing.Size(104, 20);
            this.TXTTRABAJO.TabIndex = 20;
            this.TXTTRABAJO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(543, 53);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "TRABAJO";
            // 
            // TXTMOVIL
            // 
            this.TXTMOVIL.Location = new System.Drawing.Point(602, 30);
            this.TXTMOVIL.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMOVIL.Name = "TXTMOVIL";
            this.TXTMOVIL.ReadOnly = true;
            this.TXTMOVIL.Size = new System.Drawing.Size(104, 20);
            this.TXTMOVIL.TabIndex = 19;
            this.TXTMOVIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(560, 32);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "MOVIL";
            // 
            // TXTTELEFONO
            // 
            this.TXTTELEFONO.Location = new System.Drawing.Point(602, 9);
            this.TXTTELEFONO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTTELEFONO.Name = "TXTTELEFONO";
            this.TXTTELEFONO.ReadOnly = true;
            this.TXTTELEFONO.Size = new System.Drawing.Size(104, 20);
            this.TXTTELEFONO.TabIndex = 18;
            this.TXTTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(510, 11);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "TELEFONO FIJO";
            // 
            // TXTDISTRITO
            // 
            this.TXTDISTRITO.Location = new System.Drawing.Point(206, 71);
            this.TXTDISTRITO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDISTRITO.Name = "TXTDISTRITO";
            this.TXTDISTRITO.ReadOnly = true;
            this.TXTDISTRITO.Size = new System.Drawing.Size(190, 20);
            this.TXTDISTRITO.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(72, 75);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "DISTRITO";
            // 
            // TXTLOCALIDAD
            // 
            this.TXTLOCALIDAD.Enabled = false;
            this.TXTLOCALIDAD.Location = new System.Drawing.Point(237, 49);
            this.TXTLOCALIDAD.Margin = new System.Windows.Forms.Padding(2);
            this.TXTLOCALIDAD.Name = "TXTLOCALIDAD";
            this.TXTLOCALIDAD.ReadOnly = true;
            this.TXTLOCALIDAD.Size = new System.Drawing.Size(185, 20);
            this.TXTLOCALIDAD.TabIndex = 16;
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(142, 48);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(92, 21);
            this.comboBox4.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 53);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "LOCALIDAD";
            // 
            // TXTLOTE
            // 
            this.TXTLOTE.Location = new System.Drawing.Point(388, 28);
            this.TXTLOTE.Margin = new System.Windows.Forms.Padding(2);
            this.TXTLOTE.Name = "TXTLOTE";
            this.TXTLOTE.ReadOnly = true;
            this.TXTLOTE.Size = new System.Drawing.Size(34, 20);
            this.TXTLOTE.TabIndex = 15;
            this.TXTLOTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TXTMZA
            // 
            this.TXTMZA.Location = new System.Drawing.Point(304, 28);
            this.TXTMZA.Margin = new System.Windows.Forms.Padding(2);
            this.TXTMZA.Name = "TXTMZA";
            this.TXTMZA.ReadOnly = true;
            this.TXTMZA.Size = new System.Drawing.Size(34, 20);
            this.TXTMZA.TabIndex = 14;
            this.TXTMZA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TXTINTERIOR
            // 
            this.TXTINTERIOR.Location = new System.Drawing.Point(237, 28);
            this.TXTINTERIOR.Margin = new System.Windows.Forms.Padding(2);
            this.TXTINTERIOR.Name = "TXTINTERIOR";
            this.TXTINTERIOR.ReadOnly = true;
            this.TXTINTERIOR.Size = new System.Drawing.Size(34, 20);
            this.TXTINTERIOR.TabIndex = 13;
            this.TXTINTERIOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // TXTNRO
            // 
            this.TXTNRO.Location = new System.Drawing.Point(142, 27);
            this.TXTNRO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNRO.Name = "TXTNRO";
            this.TXTNRO.ReadOnly = true;
            this.TXTNRO.Size = new System.Drawing.Size(34, 20);
            this.TXTNRO.TabIndex = 12;
            this.TXTNRO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(346, 30);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "LOTE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(274, 30);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "MZA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "INTERIOR";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "NRO";
            // 
            // TXTDIRECCION
            // 
            this.TXTDIRECCION.Location = new System.Drawing.Point(142, 6);
            this.TXTDIRECCION.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDIRECCION.Name = "TXTDIRECCION";
            this.TXTDIRECCION.ReadOnly = true;
            this.TXTDIRECCION.Size = new System.Drawing.Size(280, 20);
            this.TXTDIRECCION.TabIndex = 11;
            this.TXTDIRECCION.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(64, 11);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "DIRECCION";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(17, 344);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(126, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "TIPO DE FINANCIADOR";
            // 
            // CBTIPOFINANCIADOR
            // 
            this.CBTIPOFINANCIADOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTIPOFINANCIADOR.FormattingEnabled = true;
            this.CBTIPOFINANCIADOR.Location = new System.Drawing.Point(152, 338);
            this.CBTIPOFINANCIADOR.Margin = new System.Windows.Forms.Padding(2);
            this.CBTIPOFINANCIADOR.Name = "CBTIPOFINANCIADOR";
            this.CBTIPOFINANCIADOR.Size = new System.Drawing.Size(193, 21);
            this.CBTIPOFINANCIADOR.TabIndex = 21;
            // 
            // TXTFRSTNOMBRE
            // 
            this.TXTFRSTNOMBRE.Location = new System.Drawing.Point(152, 86);
            this.TXTFRSTNOMBRE.Margin = new System.Windows.Forms.Padding(2);
            this.TXTFRSTNOMBRE.Name = "TXTFRSTNOMBRE";
            this.TXTFRSTNOMBRE.ReadOnly = true;
            this.TXTFRSTNOMBRE.Size = new System.Drawing.Size(146, 20);
            this.TXTFRSTNOMBRE.TabIndex = 4;
            this.TXTFRSTNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloLetras);
            // 
            // PACIENTESERRORES
            // 
            this.PACIENTESERRORES.ContainerControl = this;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(42, 418);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 20;
            this.label22.Text = "OBSERVACIONES";
            // 
            // RTOBSERVACIONES
            // 
            this.RTOBSERVACIONES.Location = new System.Drawing.Point(152, 382);
            this.RTOBSERVACIONES.Margin = new System.Windows.Forms.Padding(2);
            this.RTOBSERVACIONES.Name = "RTOBSERVACIONES";
            this.RTOBSERVACIONES.ReadOnly = true;
            this.RTOBSERVACIONES.Size = new System.Drawing.Size(269, 51);
            this.RTOBSERVACIONES.TabIndex = 22;
            this.RTOBSERVACIONES.Text = "";
            // 
            // BTNNOATENCION
            // 
            this.BTNNOATENCION.Location = new System.Drawing.Point(443, 410);
            this.BTNNOATENCION.Margin = new System.Windows.Forms.Padding(2);
            this.BTNNOATENCION.Name = "BTNNOATENCION";
            this.BTNNOATENCION.Size = new System.Drawing.Size(183, 22);
            this.BTNNOATENCION.TabIndex = 22;
            this.BTNNOATENCION.Text = "OCURRENCIA DE NO ATENCION";
            this.BTNNOATENCION.UseVisualStyleBackColor = true;
            // 
            // TXTPATERNO
            // 
            this.TXTPATERNO.Location = new System.Drawing.Point(152, 57);
            this.TXTPATERNO.Margin = new System.Windows.Forms.Padding(2);
            this.TXTPATERNO.Name = "TXTPATERNO";
            this.TXTPATERNO.ReadOnly = true;
            this.TXTPATERNO.Size = new System.Drawing.Size(146, 20);
            this.TXTPATERNO.TabIndex = 2;
            // 
            // CBVETERINARIA
            // 
            this.CBVETERINARIA.AutoSize = true;
            this.CBVETERINARIA.Enabled = false;
            this.CBVETERINARIA.Location = new System.Drawing.Point(640, 343);
            this.CBVETERINARIA.Margin = new System.Windows.Forms.Padding(2);
            this.CBVETERINARIA.Name = "CBVETERINARIA";
            this.CBVETERINARIA.Size = new System.Drawing.Size(98, 17);
            this.CBVETERINARIA.TabIndex = 28;
            this.CBVETERINARIA.Text = "VETERINARIA";
            this.CBVETERINARIA.UseVisualStyleBackColor = true;
            // 
            // BTNSALIR
            // 
            this.BTNSALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSALIR.Image = global::latin_lab.Properties.Resources.ic_exit_to_app_black_24dp_1x;
            this.BTNSALIR.Location = new System.Drawing.Point(634, 454);
            this.BTNSALIR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSALIR.Name = "BTNSALIR";
            this.BTNSALIR.Size = new System.Drawing.Size(96, 41);
            this.BTNSALIR.TabIndex = 29;
            this.BTNSALIR.Text = "SALIR";
            this.BTNSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNSALIR.UseVisualStyleBackColor = true;
            this.BTNSALIR.Click += new System.EventHandler(this.BTNSALIR_Click);
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.Enabled = false;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.Image = global::latin_lab.Properties.Resources.Close_2_icon;
            this.BTNCANCELAR.Location = new System.Drawing.Point(518, 454);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(112, 41);
            this.BTNCANCELAR.TabIndex = 26;
            this.BTNCANCELAR.Text = "CANCELAR";
            this.BTNCANCELAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNCANCELAR.UseVisualStyleBackColor = true;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // BTNIMPRIMIR
            // 
            this.BTNIMPRIMIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIMPRIMIR.Image = global::latin_lab.Properties.Resources.print_icon;
            this.BTNIMPRIMIR.Location = new System.Drawing.Point(400, 454);
            this.BTNIMPRIMIR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNIMPRIMIR.Name = "BTNIMPRIMIR";
            this.BTNIMPRIMIR.Size = new System.Drawing.Size(111, 41);
            this.BTNIMPRIMIR.TabIndex = 25;
            this.BTNIMPRIMIR.Text = "IMPRIMIR";
            this.BTNIMPRIMIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNIMPRIMIR.UseVisualStyleBackColor = true;
            // 
            // BTNACTUALIZAR
            // 
            this.BTNACTUALIZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNACTUALIZAR.Image = global::latin_lab.Properties.Resources.Actions_document_edit_icon;
            this.BTNACTUALIZAR.Location = new System.Drawing.Point(269, 454);
            this.BTNACTUALIZAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACTUALIZAR.Name = "BTNACTUALIZAR";
            this.BTNACTUALIZAR.Size = new System.Drawing.Size(127, 41);
            this.BTNACTUALIZAR.TabIndex = 24;
            this.BTNACTUALIZAR.Text = "ACTUALIZAR";
            this.BTNACTUALIZAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTNACTUALIZAR.Click += new System.EventHandler(this.BTNACTUALIZAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Enabled = false;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Image = global::latin_lab.Properties.Resources.Save_icon1;
            this.BTNGUARDAR.Location = new System.Drawing.Point(146, 454);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(119, 41);
            this.BTNGUARDAR.TabIndex = 23;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 505);
            this.Controls.Add(this.BTNSALIR);
            this.Controls.Add(this.CBVETERINARIA);
            this.Controls.Add(this.TXTPATERNO);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNIMPRIMIR);
            this.Controls.Add(this.BTNACTUALIZAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNNOATENCION);
            this.Controls.Add(this.RTOBSERVACIONES);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.TXTFRSTNOMBRE);
            this.Controls.Add(this.CBTIPOFINANCIADOR);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TXTSCNDNOMBRE);
            this.Controls.Add(this.TXTMATERNO);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CBUBICACIONARCHIVO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmPacientes";
            this.Text = "PACIENTES";
            this.TopMost = true;
            this.Resize += new System.EventHandler(this.frmPacientes_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PACIENTESERRORES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBUBICACIONARCHIVO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ErrorProvider PACIENTESERRORES;
        private System.Windows.Forms.Button BTNNOATENCION;
        private System.Windows.Forms.RichTextBox RTOBSERVACIONES;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNIMPRIMIR;
        private System.Windows.Forms.Button BTNACTUALIZAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button BTNSALIR;
        private System.Windows.Forms.Button BTNUNIDADMED;
        public System.Windows.Forms.TextBox TXTIDDISTRITO;
        public System.Windows.Forms.TextBox TXTDISTRITO;
        public System.Windows.Forms.TextBox TXTHISTORIA;
        public System.Windows.Forms.TextBox TXTMATERNO;
        public System.Windows.Forms.TextBox TXTSCNDNOMBRE;
        public System.Windows.Forms.CheckBox CBDISCAPACITADO;
        public System.Windows.Forms.ComboBox CBTIPODOC;
        public System.Windows.Forms.ComboBox CBSEXO;
        public System.Windows.Forms.TextBox TXTEDAD;
        public System.Windows.Forms.DateTimePicker DTNACIMIENTO;
        public System.Windows.Forms.TextBox TXTDOCID;
        public System.Windows.Forms.TextBox TXTLOTE;
        public System.Windows.Forms.TextBox TXTMZA;
        public System.Windows.Forms.TextBox TXTINTERIOR;
        public System.Windows.Forms.TextBox TXTNRO;
        public System.Windows.Forms.TextBox TXTDIRECCION;
        public System.Windows.Forms.TextBox TXTLOCALIDAD;
        public System.Windows.Forms.ComboBox comboBox4;
        public System.Windows.Forms.TextBox TXTTRABAJO;
        public System.Windows.Forms.TextBox TXTMOVIL;
        public System.Windows.Forms.TextBox TXTTELEFONO;
        public System.Windows.Forms.ComboBox CBTIPOFINANCIADOR;
        public System.Windows.Forms.TextBox TXTFRSTNOMBRE;
        public System.Windows.Forms.TextBox TXTEDADDD;
        public System.Windows.Forms.TextBox TXTEDADMM;
        public System.Windows.Forms.TextBox TXTLUGARNAC;
        public System.Windows.Forms.TextBox TXTIDLUGARNAC;
        public System.Windows.Forms.TextBox TXTPATERNO;
        public System.Windows.Forms.CheckBox CBVETERINARIA;
    }
}