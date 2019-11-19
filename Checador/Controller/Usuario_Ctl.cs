using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class Usuario_Ctl
    {

        public List<Usuario_Mdl> listaUsuario()
        {

            Usuario_Cls objUsuario = new Usuario_Cls();
            return objUsuario.listaUsuario();
        
        }

    }

}
