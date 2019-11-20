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

namespace Checador.View.Catalogos
{
    public partial class frmUsuario : Form
    {

        private int idUsu;
        Usuario_Ctl objUsuarios = new Usuario_Ctl();

        #region "Constructor"

        public frmUsuario()
        {

            InitializeComponent();
            idUsu = 0;

        }

        public frmUsuario(int _idUsu)
        {

            InitializeComponent();
            idUsu = _idUsu;

        }

        #endregion

        #region "Formulario"

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            if (idUsu > 0)
            {

                ObtieneUsuario();

            }

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if (idUsu > 0)
            {
                Editar();

            }
            else
            {
                Nuevo();

            }

        }

        #endregion

        #region "Funciones"

        private void ObtieneUsuario()
        {

            BindingSource dbUsuarios = new BindingSource();
            dbUsuarios.DataSource = objUsuarios.UsuarioSeleccionado(idUsu);

            txtNombre.DataBindings.Add("Text", dbUsuarios, "nombre", true);
            txtPassword.DataBindings.Add("Text", dbUsuarios, "password", true);
            txtRepetir.DataBindings.Add("Text", dbUsuarios, "password", true);
            txtCorreo.DataBindings.Add("Text", dbUsuarios, "correo", true);
            txtTelefono.DataBindings.Add("Text", dbUsuarios, "telefono", true);
            txtExtencion.DataBindings.Add("Text", dbUsuarios, "extencion", true);
            chbEstatus.DataBindings.Add("Checked", dbUsuarios, "estatus");
            chbReset.DataBindings.Add("Checked", dbUsuarios, "reset_pass");

        }

        private void Nuevo()
        {

            DataTable dtUsuario = new DataTable();

            dtUsuario.Columns.Add("id_usuario");
            dtUsuario.Columns.Add("nombre");
            dtUsuario.Columns.Add("password");
            dtUsuario.Columns.Add("id_rol");
            dtUsuario.Columns.Add("correo");
            dtUsuario.Columns.Add("telefono");
            dtUsuario.Columns.Add("extencion");
            dtUsuario.Columns.Add("alta");
            dtUsuario.Columns.Add("baja");
            dtUsuario.Columns.Add("estatus");
            dtUsuario.Columns.Add("reset_pass");

            DataRow dRow = dtUsuario.NewRow();

            dRow["id_usuario"] = idUsu;
            dRow["nombre"] = txtNombre.Text;
            dRow["password"] = txtPassword.Text;
            dRow["id_rol"] = 1;
            dRow["correo"] = txtCorreo.Text;
            dRow["telefono"] = txtTelefono.Text;
            dRow["extencion"] = txtExtencion.Text;
            dRow["alta"] = DateTime.Now.ToString("yyyyMMdd");
            dRow["baja"] = DateTime.Now.ToString("yyyyMMdd");

            if (chbEstatus.CheckState == CheckState.Checked)
            {
                dRow["estatus"] = 1;
            }
            else
            {
                dRow["estatus"] = 0;
            }

            if (chbReset.CheckState == CheckState.Checked)
            {
                dRow["reset_pass"] = 1;
            }
            else
            {
                dRow["reset_pass"] = 0;
            }

            dtUsuario.Rows.Add(dRow);

            Usuario_Ctl objUsuario = new Usuario_Ctl();

            if (objUsuario.NuevoUsuario(dtUsuario) == true)
            {

                this.Close();

            }

        }

        private void Editar()
        {

            DataTable dtUsuario = new DataTable();

            dtUsuario.Columns.Add("id_usuario");
            dtUsuario.Columns.Add("nombre");
            dtUsuario.Columns.Add("password");
            dtUsuario.Columns.Add("id_rol");
            dtUsuario.Columns.Add("correo");
            dtUsuario.Columns.Add("telefono");
            dtUsuario.Columns.Add("extencion");
            dtUsuario.Columns.Add("alta");
            dtUsuario.Columns.Add("baja");
            dtUsuario.Columns.Add("estatus");
            dtUsuario.Columns.Add("reset_pass");

            DataRow dRow = dtUsuario.NewRow();

            dRow["id_usuario"] = idUsu;
            dRow["nombre"] = txtNombre.Text;
            dRow["password"] = txtPassword.Text;
            dRow["id_rol"] = 1;
            dRow["correo"] = txtCorreo.Text;
            dRow["telefono"] = txtTelefono.Text;
            dRow["extencion"] = txtExtencion.Text;
            dRow["alta"] = DateTime.Now.ToString("yyyyMMdd");
            dRow["baja"] = DateTime.Now.ToString("yyyyMMdd");

            if (chbEstatus.CheckState == CheckState.Checked)
            {
                dRow["estatus"] = 1;
            }
            else
            {
                dRow["estatus"] = 0;
            }

            if (chbReset.CheckState == CheckState.Checked)
            {
                dRow["reset_pass"] = 1;
            }
            else
            {
                dRow["reset_pass"] = 0;
            }

            dtUsuario.Rows.Add(dRow);

            Usuario_Ctl objUsuario = new Usuario_Ctl();

            if (objUsuario.EditaUsuario(dtUsuario) == true)
            {

                this.Close();

            }

        }

        #endregion

    }

}
