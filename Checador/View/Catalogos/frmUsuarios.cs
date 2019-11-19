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

namespace Checador.View.Catalogos
{
    public partial class frmUsuarios : Form
    {

        Usuario_Ctl objUsuario = new Usuario_Ctl();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            CargaUsuarios();

        }

        private void Configura()
        {

            fgUsuarios.Cols.Count = 6;
            fgUsuarios.Rows.Count = 1;

            fgUsuarios.Cols[0].Caption = "Id";
            fgUsuarios.Cols[0].Visible = false;
            fgUsuarios.Cols[1].Caption = "Usuario";
            fgUsuarios.Cols[2].Caption = "Correo";
            fgUsuarios.Cols[3].Caption = "Teléfono";
            fgUsuarios.Cols[4].Caption = "Extención";
            fgUsuarios.Cols[5].Caption = "Estatus";

            fgUsuarios.AutoSizeCols();

        }

        private void CargaUsuarios()
        {

            Configura();

            List<Usuario_Mdl> ListaUsuarios = new List<Usuario_Mdl>();

            ListaUsuarios = objUsuario.listaUsuario();
            
            foreach(var usuario in ListaUsuarios)
            {

                fgUsuarios.AddItem("");

                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 0, usuario.id_usuario);
                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 1, usuario.nombre);
                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 2, usuario.correo);
                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 3, usuario.telefono);
                fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 4, usuario.extencion);

                if(usuario.estatus == 1)
                {
                    fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 5, "Activo");
                }
                else
                {
                    fgUsuarios.SetData(fgUsuarios.Rows.Count - 1, 5, "Inactivo");
                }
            
            }

            fgUsuarios.AutoSizeCols();

        }

    }

}
