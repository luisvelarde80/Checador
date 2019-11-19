using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class Estado_Ctl
    {

        Estado_Cls objEstados = new Estado_Cls();

        public List<Estado_Mdl> listaEstados()
        {

            return objEstados.listaEstados();

        }

        public List<Estado_Mdl> listaEstados(string idEstado)
        {

            return objEstados.listaEstados(idEstado);

        }


    }

}
