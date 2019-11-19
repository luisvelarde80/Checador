using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador.Controller;
using Checador.Model;

namespace Checador.View
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if(txtUsuario.Text.Length > 0 && txtPassword.Text.Length > 0)
            {

                List<Usuario_Mdl> listaUsuario = new List<Usuario_Mdl>();
                Usuario_Ctl objUsuario = new Usuario_Ctl();

                listaUsuario = objUsuario.listaUsuario();

                foreach(var Usuario in listaUsuario)
                {

                    if(txtUsuario.Text.ToUpper() == Usuario.nombre.ToUpper() && txtPassword.Text == Usuario.password)
                    {

                        MessageBox.Show("Bienvenido " + Usuario.nombre + ", " + Environment.NewLine +" al Sistema de Puntualidad", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;

                    }

                }

                MessageBox.Show("Usuario y/o Contraseña Incorrectas, favor de verificar sus datos", "Error en los Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtPassword.Text = "";
                txtUsuario.Focus();

            }

        }

    }

}
