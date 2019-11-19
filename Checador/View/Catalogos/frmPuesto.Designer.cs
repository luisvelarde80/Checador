namespace Checador.View.Catalogos
{
    partial class frmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuesto));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
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
            this.tsMenu.Size = new System.Drawing.Size(293, 25);
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
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(36, 52);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(43, 13);
            this.lblPuesto.TabIndex = 1;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(89, 49);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(169, 20);
            this.txtPuesto.TabIndex = 2;
            // 
            // frmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 97);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.tsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puesto";
            this.Load += new System.EventHandler(this.frmPuesto_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txtPuesto;
    }
}