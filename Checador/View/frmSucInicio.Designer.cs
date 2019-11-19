namespace Checador.View
{
    partial class frmSucInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSucInicio));
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(97, 25);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(51, 13);
            this.lblSucursal.TabIndex = 0;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(153, 22);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(163, 21);
            this.cmbSucursal.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(256, 55);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(60, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmSucInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 96);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblSucursal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSucInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Sucursal";
            this.Load += new System.EventHandler(this.frmSucInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}