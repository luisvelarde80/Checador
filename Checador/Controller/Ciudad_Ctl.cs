using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;

namespace Checador.Controller
{
    public class Ciudad_Ctl
    {

        Ciudad_Cls objCiudad = new Ciudad_Cls();

        public List<Ciudad_Mdl> listaCiudades()
        {

            return objCiudad.listaCiudades();

        }

        public List<Ciudad_Mdl> listaCiudades(string idEstado)
        {

            return objCiudad.listaCiudades(idEstado);

        }

    }
}
