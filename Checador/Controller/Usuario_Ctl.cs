using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class Usuario_Ctl
    {

        Usuario_Cls objUsuario = new Usuario_Cls();

        public List<Usuario_Mdl> listaUsuario()
        {

            return objUsuario.listaUsuario();
        
        }

        public List<Usuario_Mdl> UsuarioSeleccionado(int idUsu)
        {

            return objUsuario.UsuarioSeleccionado(idUsu);

        }

        public Boolean NuevoUsuario(DataTable dtUsuario)
        {

            return objUsuario.NuevoUsuario(dtUsuario);

        }

        public Boolean EditaUsuario(DataTable dtUsuario)
        {

            return objUsuario.EditaUsuario(dtUsuario);

        }

    }

}
