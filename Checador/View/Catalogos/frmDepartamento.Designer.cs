namespace Checador.View.Catalogos
{
    partial class frmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamento));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblDepto = new System.Windows.Forms.Label();
            this.txtDepto = new System.Windows.Forms.TextBox();
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
            this.tsMenu.Size = new System.Drawing.Size(277, 25);
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
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(22, 51);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(77, 13);
            this.lblDepto.TabIndex = 1;
            this.lblDepto.Text = "Departamento:";
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(105, 48);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(137, 20);
            this.txtDepto.TabIndex = 2;
            // 
            // frmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 93);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.lblDepto);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.frmDepartamento_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.TextBox txtDepto;
    }
}