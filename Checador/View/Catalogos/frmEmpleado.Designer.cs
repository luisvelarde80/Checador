namespace Checador.View.Catalogos
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpDatosEmp = new System.Windows.Forms.TabPage();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.dtpAlta = new System.Windows.Forms.DateTimePicker();
            this.lblAlta = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblNss = new System.Windows.Forms.Label();
            this.txtNss = new System.Windows.Forms.TextBox();
            this.lblCurp = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.lblRfc = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblAmaterno = new System.Windows.Forms.Label();
            this.lblApaterno = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.tpDireccion = new System.Windows.Forms.TabPage();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.lblNumInt = new System.Windows.Forms.Label();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.lblNumExt = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.tpDatosRh = new System.Windows.Forms.TabPage();
            this.cmbTipoSalario = new System.Windows.Forms.ComboBox();
            this.lblTipoSalario = new System.Windows.Forms.Label();
            this.cmbContrato = new System.Windows.Forms.ComboBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.cmbMetPago = new System.Windows.Forms.ComboBox();
            this.lblMetPago = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cmbDepto = new System.Windows.Forms.ComboBox();
            this.lblDepto = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cmbJornada = new System.Windows.Forms.ComboBox();
            this.lblJornada = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpDatosEmp.SuspendLayout();
            this.tpDireccion.SuspendLayout();
            this.tpDatosRh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenu.BackgroundImage")));
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(498, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.ForeColor = System.Drawing.Color.White;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpDatosEmp);
            this.tabControl1.Controls.Add(this.tpDireccion);
            this.tabControl1.Controls.Add(this.tpDatosRh);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 239);
            this.tabControl1.TabIndex = 1;
            // 
            // tpDatosEmp
            // 
            this.tpDatosEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDatosEmp.Controls.Add(this.chbActivo);
            this.tpDatosEmp.Controls.Add(this.dtpAlta);
            this.tpDatosEmp.Controls.Add(this.lblAlta);
            this.tpDatosEmp.Controls.Add(this.dtpFechaNac);
            this.tpDatosEmp.Controls.Add(this.lblFechaNac);
            this.tpDatosEmp.Controls.Add(this.lblNss);
            this.tpDatosEmp.Controls.Add(this.txtNss);
            this.tpDatosEmp.Controls.Add(this.lblCurp);
            this.tpDatosEmp.Controls.Add(this.txtCurp);
            this.tpDatosEmp.Controls.Add(this.lblRfc);
            this.tpDatosEmp.Controls.Add(this.txtRfc);
            this.tpDatosEmp.Controls.Add(this.lblNombre);
            this.tpDatosEmp.Controls.Add(this.txtNombre);
            this.tpDatosEmp.Controls.Add(this.txtAmaterno);
            this.tpDatosEmp.Controls.Add(this.txtApaterno);
            this.tpDatosEmp.Controls.Add(this.txtClave);
            this.tpDatosEmp.Controls.Add(this.lblAmaterno);
            this.tpDatosEmp.Controls.Add(this.lblApaterno);
            this.tpDatosEmp.Controls.Add(this.lblClave);
            this.tpDatosEmp.Location = new System.Drawing.Point(4, 22);
            this.tpDatosEmp.Name = "tpDatosEmp";
            this.tpDatosEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosEmp.Size = new System.Drawing.Size(490, 213);
            this.tpDatosEmp.TabIndex = 0;
            this.tpDatosEmp.Text = "Datos del Empleado";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(393, 184);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 20;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // dtpAlta
            // 
            this.dtpAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAlta.Location = new System.Drawing.Point(304, 148);
            this.dtpAlta.Name = "dtpAlta";
            this.dtpAlta.Size = new System.Drawing.Size(147, 20);
            this.dtpAlta.TabIndex = 19;
            // 
            // lblAlta
            // 
            this.lblAlta.AutoSize = true;
            this.lblAlta.Location = new System.Drawing.Point(241, 154);
            this.lblAlta.Name = "lblAlta";
            this.lblAlta.Size = new System.Drawing.Size(28, 13);
            this.lblAlta.TabIndex = 18;
            this.lblAlta.Text = "Alta:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(71, 148);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaNac.TabIndex = 17;
            this.dtpFechaNac.Value = new System.DateTime(2019, 12, 6, 9, 13, 37, 0);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(8, 154);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(63, 13);
            this.lblFechaNac.TabIndex = 16;
            this.lblFechaNac.Text = "Fecha Nac.";
            // 
            // lblNss
            // 
            this.lblNss.AutoSize = true;
            this.lblNss.Location = new System.Drawing.Point(241, 123);
            this.lblNss.Name = "lblNss";
            this.lblNss.Size = new System.Drawing.Size(32, 13);
            this.lblNss.TabIndex = 14;
            this.lblNss.Text = "NSS:";
            // 
            // txtNss
            // 
            this.txtNss.Location = new System.Drawing.Point(304, 116);
            this.txtNss.Name = "txtNss";
            this.txtNss.Size = new System.Drawing.Size(147, 20);
            this.txtNss.TabIndex = 13;
            // 
            // lblCurp
            // 
            this.lblCurp.AutoSize = true;
            this.lblCurp.Location = new System.Drawing.Point(8, 127);
            this.lblCurp.Name = "lblCurp";
            this.lblCurp.Size = new System.Drawing.Size(40, 13);
            this.lblCurp.TabIndex = 12;
            this.lblCurp.Text = "CURP:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(71, 120);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(147, 20);
            this.txtCurp.TabIndex = 11;
            // 
            // lblRfc
            // 
            this.lblRfc.AutoSize = true;
            this.lblRfc.Location = new System.Drawing.Point(241, 91);
            this.lblRfc.Name = "lblRfc";
            this.lblRfc.Size = new System.Drawing.Size(31, 13);
            this.lblRfc.TabIndex = 10;
            this.lblRfc.Text = "RFC:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(304, 84);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(147, 20);
            this.txtRfc.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Location = new System.Drawing.Point(306, 56);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(147, 20);
            this.txtAmaterno.TabIndex = 5;
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(71, 56);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(147, 20);
            this.txtApaterno.TabIndex = 4;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(118, 21);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(64, 20);
            this.txtClave.TabIndex = 3;
            // 
            // lblAmaterno
            // 
            this.lblAmaterno.AutoSize = true;
            this.lblAmaterno.Location = new System.Drawing.Point(241, 59);
            this.lblAmaterno.Name = "lblAmaterno";
            this.lblAmaterno.Size = new System.Drawing.Size(62, 13);
            this.lblAmaterno.TabIndex = 2;
            this.lblAmaterno.Text = "A. Materno:";
            // 
            // lblApaterno
            // 
            this.lblApaterno.AutoSize = true;
            this.lblApaterno.Location = new System.Drawing.Point(8, 59);
            this.lblApaterno.Name = "lblApaterno";
            this.lblApaterno.Size = new System.Drawing.Size(60, 13);
            this.lblApaterno.TabIndex = 1;
            this.lblApaterno.Text = "A. Paterno:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(8, 24);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(104, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave del Empleado:";
            // 
            // tpDireccion
            // 
            this.tpDireccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDireccion.Controls.Add(this.txtCelular);
            this.tpDireccion.Controls.Add(this.lblCelular);
            this.tpDireccion.Controls.Add(this.txtCorreo);
            this.tpDireccion.Controls.Add(this.lblCorreo);
            this.tpDireccion.Controls.Add(this.txtTelefono);
            this.tpDireccion.Controls.Add(this.lblTelefono);
            this.tpDireccion.Controls.Add(this.cmbCiudad);
            this.tpDireccion.Controls.Add(this.lblCiudad);
            this.tpDireccion.Controls.Add(this.cmbEstado);
            this.tpDireccion.Controls.Add(this.lblEstado);
            this.tpDireccion.Controls.Add(this.cmbPais);
            this.tpDireccion.Controls.Add(this.lblPais);
            this.tpDireccion.Controls.Add(this.txtCodPostal);
            this.tpDireccion.Controls.Add(this.lblCodPostal);
            this.tpDireccion.Controls.Add(this.txtColonia);
            this.tpDireccion.Controls.Add(this.lblColonia);
            this.tpDireccion.Controls.Add(this.txtNumInt);
            this.tpDireccion.Controls.Add(this.lblNumInt);
            this.tpDireccion.Controls.Add(this.txtNumExt);
            this.tpDireccion.Controls.Add(this.lblNumExt);
            this.tpDireccion.Controls.Add(this.txtCalle);
            this.tpDireccion.Controls.Add(this.lblCalle);
            this.tpDireccion.Location = new System.Drawing.Point(4, 22);
            this.tpDireccion.Name = "tpDireccion";
            this.tpDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tpDireccion.Size = new System.Drawing.Size(490, 213);
            this.tpDireccion.TabIndex = 1;
            this.tpDireccion.Text = "Dirección";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(281, 155);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(150, 20);
            this.txtCelular.TabIndex = 21;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(230, 158);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 20;
            this.lblCelular.Text = "Celular:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(59, 155);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(150, 20);
            this.txtCorreo.TabIndex = 19;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(8, 158);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 18;
            this.lblCorreo.Text = "Correo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(281, 122);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 20);
            this.txtTelefono.TabIndex = 17;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(230, 125);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(59, 122);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(150, 21);
            this.cmbCiudad.TabIndex = 15;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(8, 125);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 14;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(281, 87);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(150, 21);
            this.cmbEstado.TabIndex = 13;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(230, 90);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(59, 87);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(150, 21);
            this.cmbPais.TabIndex = 11;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(8, 90);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 10;
            this.lblPais.Text = "Pais:";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(282, 53);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(83, 20);
            this.txtCodPostal.TabIndex = 9;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(215, 56);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(64, 13);
            this.lblCodPostal.TabIndex = 8;
            this.lblCodPostal.Text = "Cod. Postal:";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(59, 53);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(150, 20);
            this.txtColonia.TabIndex = 7;
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(8, 56);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(45, 13);
            this.lblColonia.TabIndex = 6;
            this.lblColonia.Text = "Colonia:";
            // 
            // txtNumInt
            // 
            this.txtNumInt.Location = new System.Drawing.Point(389, 19);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(78, 20);
            this.txtNumInt.TabIndex = 5;
            // 
            // lblNumInt
            // 
            this.lblNumInt.AutoSize = true;
            this.lblNumInt.Location = new System.Drawing.Point(344, 22);
            this.lblNumInt.Name = "lblNumInt";
            this.lblNumInt.Size = new System.Drawing.Size(42, 13);
            this.lblNumInt.TabIndex = 4;
            this.lblNumInt.Text = "No. Int.";
            // 
            // txtNumExt
            // 
            this.txtNumExt.Location = new System.Drawing.Point(260, 19);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(78, 20);
            this.txtNumExt.TabIndex = 3;
            // 
            // lblNumExt
            // 
            this.lblNumExt.AutoSize = true;
            this.lblNumExt.Location = new System.Drawing.Point(215, 22);
            this.lblNumExt.Name = "lblNumExt";
            this.lblNumExt.Size = new System.Drawing.Size(45, 13);
            this.lblNumExt.TabIndex = 2;
            this.lblNumExt.Text = "No. Ext.";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(59, 19);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(150, 20);
            this.txtCalle.TabIndex = 1;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(8, 22);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 0;
            this.lblCalle.Text = "Calle:";
            // 
            // tpDatosRh
            // 
            this.tpDatosRh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tpDatosRh.Controls.Add(this.cmbTipoSalario);
            this.tpDatosRh.Controls.Add(this.lblTipoSalario);
            this.tpDatosRh.Controls.Add(this.cmbContrato);
            this.tpDatosRh.Controls.Add(this.lblContrato);
            this.tpDatosRh.Controls.Add(this.cmbMetPago);
            this.tpDatosRh.Controls.Add(this.lblMetPago);
            this.tpDatosRh.Controls.Add(this.txtSalario);
            this.tpDatosRh.Controls.Add(this.lblSalario);
            this.tpDatosRh.Controls.Add(this.cmbPuesto);
            this.tpDatosRh.Controls.Add(this.lblPuesto);
            this.tpDatosRh.Controls.Add(this.cmbDepto);
            this.tpDatosRh.Controls.Add(this.lblDepto);
            this.tpDatosRh.Controls.Add(this.cmbSucursal);
            this.tpDatosRh.Controls.Add(this.lblSucursal);
            this.tpDatosRh.Controls.Add(this.cmbJornada);
            this.tpDatosRh.Controls.Add(this.lblJornada);
            this.tpDatosRh.Controls.Add(this.txtCuenta);
            this.tpDatosRh.Controls.Add(this.lblCuenta);
            this.tpDatosRh.Controls.Add(this.cmbBanco);
            this.tpDatosRh.Controls.Add(this.lblBanco);
            this.tpDatosRh.Location = new System.Drawing.Point(4, 22);
            this.tpDatosRh.Name = "tpDatosRh";
            this.tpDatosRh.Size = new System.Drawing.Size(490, 213);
            this.tpDatosRh.TabIndex = 2;
            this.tpDatosRh.Text = "RH";
            // 
            // cmbTipoSalario
            // 
            this.cmbTipoSalario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoSalario.FormattingEnabled = true;
            this.cmbTipoSalario.Location = new System.Drawing.Point(368, 165);
            this.cmbTipoSalario.Name = "cmbTipoSalario";
            this.cmbTipoSalario.Size = new System.Drawing.Size(111, 21);
            this.cmbTipoSalario.TabIndex = 19;
            // 
            // lblTipoSalario
            // 
            this.lblTipoSalario.AutoSize = true;
            this.lblTipoSalario.Location = new System.Drawing.Point(296, 168);
            this.lblTipoSalario.Name = "lblTipoSalario";
            this.lblTipoSalario.Size = new System.Drawing.Size(66, 13);
            this.lblTipoSalario.TabIndex = 18;
            this.lblTipoSalario.Text = "Tipo Salario:";
            // 
            // cmbContrato
            // 
            this.cmbContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContrato.FormattingEnabled = true;
            this.cmbContrato.Location = new System.Drawing.Point(59, 165);
            this.cmbContrato.Name = "cmbContrato";
            this.cmbContrato.Size = new System.Drawing.Size(231, 21);
            this.cmbContrato.TabIndex = 17;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(12, 168);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(50, 13);
            this.lblContrato.TabIndex = 16;
            this.lblContrato.Text = "Contrato:";
            // 
            // cmbMetPago
            // 
            this.cmbMetPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetPago.FormattingEnabled = true;
            this.cmbMetPago.Location = new System.Drawing.Point(305, 132);
            this.cmbMetPago.Name = "cmbMetPago";
            this.cmbMetPago.Size = new System.Drawing.Size(175, 21);
            this.cmbMetPago.TabIndex = 15;
            // 
            // lblMetPago
            // 
            this.lblMetPago.AutoSize = true;
            this.lblMetPago.Location = new System.Drawing.Point(240, 135);
            this.lblMetPago.Name = "lblMetPago";
            this.lblMetPago.Size = new System.Drawing.Size(59, 13);
            this.lblMetPago.TabIndex = 14;
            this.lblMetPago.Text = "Met. Pago:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(90, 132);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(144, 20);
            this.txtSalario.TabIndex = 13;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 134);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(72, 13);
            this.lblSalario.TabIndex = 12;
            this.lblSalario.Text = "Salario Diario:";
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Location = new System.Drawing.Point(305, 95);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(175, 21);
            this.cmbPuesto.TabIndex = 11;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(240, 98);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 10;
            this.lblPuesto.Text = "Puesto:";
            // 
            // cmbDepto
            // 
            this.cmbDepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepto.FormattingEnabled = true;
            this.cmbDepto.Location = new System.Drawing.Point(59, 95);
            this.cmbDepto.Name = "cmbDepto";
            this.cmbDepto.Size = new System.Drawing.Size(175, 21);
            this.cmbDepto.TabIndex = 9;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(12, 98);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(39, 13);
            this.lblDepto.TabIndex = 8;
            this.lblDepto.Text = "Depto:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(305, 60);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(175, 21);
            this.cmbSucursal.TabIndex = 7;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(240, 63);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 6;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // cmbJornada
            // 
            this.cmbJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJornada.FormattingEnabled = true;
            this.cmbJornada.Location = new System.Drawing.Point(59, 60);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(175, 21);
            this.cmbJornada.TabIndex = 5;
            // 
            // lblJornada
            // 
            this.lblJornada.AutoSize = true;
            this.lblJornada.Location = new System.Drawing.Point(12, 63);
            this.lblJornada.Name = "lblJornada";
            this.lblJornada.Size = new System.Drawing.Size(48, 13);
            this.lblJornada.TabIndex = 4;
            this.lblJornada.Text = "Jornada:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(305, 25);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(175, 20);
            this.txtCuenta.TabIndex = 3;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(240, 27);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(44, 13);
            this.lblCuenta.TabIndex = 2;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // cmbBanco
            // 
            this.cmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(59, 24);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(175, 21);
            this.cmbBanco.TabIndex = 1;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(12, 27);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 0;
            this.lblBanco.Text = "Banco:";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 269);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpDatosEmp.ResumeLayout(false);
            this.tpDatosEmp.PerformLayout();
            this.tpDireccion.ResumeLayout(false);
            this.tpDireccion.PerformLayout();
            this.tpDatosRh.ResumeLayout(false);
            this.tpDatosRh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpDatosEmp;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.DateTimePicker dtpAlta;
        private System.Windows.Forms.Label lblAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblNss;
        private System.Windows.Forms.TextBox txtNss;
        private System.Windows.Forms.Label lblCurp;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label lblRfc;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblAmaterno;
        private System.Windows.Forms.Label lblApaterno;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TabPage tpDireccion;
        private System.Windows.Forms.TabPage tpDatosRh;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label lblNumInt;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.Label lblNumExt;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.ComboBox cmbTipoSalario;
        private System.Windows.Forms.Label lblTipoSalario;
        private System.Windows.Forms.ComboBox cmbContrato;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.ComboBox cmbMetPago;
        private System.Windows.Forms.Label lblMetPago;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cmbDepto;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cmbJornada;
        private System.Windows.Forms.Label lblJornada;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label lblBanco;
    }
}