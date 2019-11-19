namespace Checador.View
{
    partial class frmSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSucursal));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txtSucursal = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNumExt = new System.Windows.Forms.TextBox();
            this.lblNumExt = new System.Windows.Forms.Label();
            this.txtNumInt = new System.Windows.Forms.TextBox();
            this.lblNumInt = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.lblColonia = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.chbEstatus = new System.Windows.Forms.CheckBox();
            this.txtExtencion = new System.Windows.Forms.TextBox();
            this.lblExtencion = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsMenu.BackgroundImage")));
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(437, 25);
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
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(12, 48);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 1;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // txtSucursal
            // 
            this.txtSucursal.Location = new System.Drawing.Point(63, 45);
            this.txtSucursal.Name = "txtSucursal";
            this.txtSucursal.Size = new System.Drawing.Size(163, 20);
            this.txtSucursal.TabIndex = 2;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(268, 45);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(104, 20);
            this.txtCalle.TabIndex = 8;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(231, 48);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 7;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNumExt
            // 
            this.txtNumExt.Location = new System.Drawing.Point(64, 74);
            this.txtNumExt.Name = "txtNumExt";
            this.txtNumExt.Size = new System.Drawing.Size(51, 20);
            this.txtNumExt.TabIndex = 10;
            // 
            // lblNumExt
            // 
            this.lblNumExt.AutoSize = true;
            this.lblNumExt.Location = new System.Drawing.Point(13, 77);
            this.lblNumExt.Name = "lblNumExt";
            this.lblNumExt.Size = new System.Drawing.Size(45, 13);
            this.lblNumExt.TabIndex = 9;
            this.lblNumExt.Text = "No. Ext.";
            // 
            // txtNumInt
            // 
            this.txtNumInt.Location = new System.Drawing.Point(188, 74);
            this.txtNumInt.Name = "txtNumInt";
            this.txtNumInt.Size = new System.Drawing.Size(51, 20);
            this.txtNumInt.TabIndex = 12;
            // 
            // lblNumInt
            // 
            this.lblNumInt.AutoSize = true;
            this.lblNumInt.Location = new System.Drawing.Point(137, 77);
            this.lblNumInt.Name = "lblNumInt";
            this.lblNumInt.Size = new System.Drawing.Size(42, 13);
            this.lblNumInt.TabIndex = 11;
            this.lblNumInt.Text = "No. Int.";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(309, 74);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(104, 20);
            this.txtColonia.TabIndex = 14;
            // 
            // lblColonia
            // 
            this.lblColonia.AutoSize = true;
            this.lblColonia.Location = new System.Drawing.Point(258, 77);
            this.lblColonia.Name = "lblColonia";
            this.lblColonia.Size = new System.Drawing.Size(45, 13);
            this.lblColonia.TabIndex = 13;
            this.lblColonia.Text = "Colonia:";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(13, 106);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 15;
            this.lblPais.Text = "Pais:";
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(49, 103);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(145, 21);
            this.cmbPais.TabIndex = 16;
            this.cmbPais.SelectedIndexChanged += new System.EventHandler(this.cmbPais_SelectedIndexChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(264, 103);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(145, 21);
            this.cmbEstado.TabIndex = 18;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(221, 106);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(58, 136);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(181, 21);
            this.cmbCiudad.TabIndex = 20;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(13, 139);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 19;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(291, 136);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(67, 20);
            this.txtCodPostal.TabIndex = 22;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(258, 139);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblCodPostal.TabIndex = 21;
            this.lblCodPostal.Text = "C.P.";
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(91, 166);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(147, 20);
            this.txtResponsable.TabIndex = 24;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(13, 169);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 23;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(296, 166);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(97, 20);
            this.txtTelefono.TabIndex = 26;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(244, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(185, 200);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(208, 20);
            this.txtCorreo.TabIndex = 28;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(141, 203);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 27;
            this.lblCorreo.Text = "E-mail:";
            // 
            // chbEstatus
            // 
            this.chbEstatus.AutoSize = true;
            this.chbEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbEstatus.Location = new System.Drawing.Point(347, 226);
            this.chbEstatus.Name = "chbEstatus";
            this.chbEstatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbEstatus.Size = new System.Drawing.Size(62, 17);
            this.chbEstatus.TabIndex = 29;
            this.chbEstatus.Text = "Activo";
            this.chbEstatus.UseVisualStyleBackColor = true;
            // 
            // txtExtencion
            // 
            this.txtExtencion.Location = new System.Drawing.Point(44, 200);
            this.txtExtencion.Name = "txtExtencion";
            this.txtExtencion.Size = new System.Drawing.Size(71, 20);
            this.txtExtencion.TabIndex = 31;
            // 
            // lblExtencion
            // 
            this.lblExtencion.AutoSize = true;
            this.lblExtencion.Location = new System.Drawing.Point(13, 203);
            this.lblExtencion.Name = "lblExtencion";
            this.lblExtencion.Size = new System.Drawing.Size(25, 13);
            this.lblExtencion.TabIndex = 30;
            this.lblExtencion.Text = "Ext.";
            // 
            // frmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 249);
            this.Controls.Add(this.txtExtencion);
            this.Controls.Add(this.lblExtencion);
            this.Controls.Add(this.chbEstatus);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.txtCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.cmbCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtColonia);
            this.Controls.Add(this.lblColonia);
            this.Controls.Add(this.txtNumInt);
            this.Controls.Add(this.lblNumInt);
            this.Controls.Add(this.txtNumExt);
            this.Controls.Add(this.lblNumExt);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.frmSucursal_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtSucursal;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumExt;
        private System.Windows.Forms.Label lblNumExt;
        private System.Windows.Forms.TextBox txtNumInt;
        private System.Windows.Forms.Label lblNumInt;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label lblColonia;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.CheckBox chbEstatus;
        private System.Windows.Forms.TextBox txtExtencion;
        private System.Windows.Forms.Label lblExtencion;
    }
}