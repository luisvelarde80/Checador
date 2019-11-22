namespace Checador
{
    partial class frmMdi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMdi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiControlAsistencia = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSucursales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaisEstadoCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPais = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiControlAsistencia,
            this.tsmiCatalogo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiControlAsistencia
            // 
            this.tsmiControlAsistencia.Name = "tsmiControlAsistencia";
            this.tsmiControlAsistencia.Size = new System.Drawing.Size(131, 20);
            this.tsmiControlAsistencia.Text = "Control de Asistencia";
            // 
            // tsmiCatalogo
            // 
            this.tsmiCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSucursales,
            this.tsmiDepartamentos,
            this.tsmiPuestos,
            this.tsmiUsuarios,
            this.tsmiPaisEstadoCiudad});
            this.tsmiCatalogo.Name = "tsmiCatalogo";
            this.tsmiCatalogo.Size = new System.Drawing.Size(67, 20);
            this.tsmiCatalogo.Text = "Catalogo";
            // 
            // tsmiSucursales
            // 
            this.tsmiSucursales.Name = "tsmiSucursales";
            this.tsmiSucursales.Size = new System.Drawing.Size(180, 22);
            this.tsmiSucursales.Text = "Sucursales";
            this.tsmiSucursales.Click += new System.EventHandler(this.tsmiSucursales_Click);
            // 
            // tsmiDepartamentos
            // 
            this.tsmiDepartamentos.Name = "tsmiDepartamentos";
            this.tsmiDepartamentos.Size = new System.Drawing.Size(180, 22);
            this.tsmiDepartamentos.Text = "Departamentos";
            this.tsmiDepartamentos.Click += new System.EventHandler(this.tsmiDepartamentos_Click);
            // 
            // tsmiPuestos
            // 
            this.tsmiPuestos.Name = "tsmiPuestos";
            this.tsmiPuestos.Size = new System.Drawing.Size(180, 22);
            this.tsmiPuestos.Text = "Puestos";
            this.tsmiPuestos.Click += new System.EventHandler(this.tsmiPuestos_Click);
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmiUsuarios.Text = "Usuarios";
            this.tsmiUsuarios.Click += new System.EventHandler(this.tsmiUsuarios_Click);
            // 
            // tsmiPaisEstadoCiudad
            // 
            this.tsmiPaisEstadoCiudad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPais,
            this.tsmiEstado,
            this.tsmiCiudad});
            this.tsmiPaisEstadoCiudad.Name = "tsmiPaisEstadoCiudad";
            this.tsmiPaisEstadoCiudad.Size = new System.Drawing.Size(180, 22);
            this.tsmiPaisEstadoCiudad.Text = "Pais/Estado/Ciudad";
            // 
            // tsmiPais
            // 
            this.tsmiPais.Name = "tsmiPais";
            this.tsmiPais.Size = new System.Drawing.Size(180, 22);
            this.tsmiPais.Text = "Pais";
            this.tsmiPais.Click += new System.EventHandler(this.tsmiPais_Click);
            // 
            // tsmiEstado
            // 
            this.tsmiEstado.Name = "tsmiEstado";
            this.tsmiEstado.Size = new System.Drawing.Size(180, 22);
            this.tsmiEstado.Text = "Estado";
            this.tsmiEstado.Click += new System.EventHandler(this.tsmiEstado_Click);
            // 
            // tsmiCiudad
            // 
            this.tsmiCiudad.Name = "tsmiCiudad";
            this.tsmiCiudad.Size = new System.Drawing.Size(180, 22);
            this.tsmiCiudad.Text = "Ciudad";
            this.tsmiCiudad.Click += new System.EventHandler(this.tsmiCiudad_Click);
            // 
            // frmMdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Asistencia";
            this.Load += new System.EventHandler(this.frmMdi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiControlAsistencia;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatalogo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSucursales;
        private System.Windows.Forms.ToolStripMenuItem tsmiDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaisEstadoCiudad;
        private System.Windows.Forms.ToolStripMenuItem tsmiPais;
        private System.Windows.Forms.ToolStripMenuItem tsmiEstado;
        private System.Windows.Forms.ToolStripMenuItem tsmiCiudad;
        private System.Windows.Forms.ToolStripMenuItem tsmiPuestos;
    }
}

