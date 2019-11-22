using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;
using System.Data;

namespace Checador.Controller
{
    public class Ciudad_Ctl
    {

        Ciudad_Cls objCiudad = new Ciudad_Cls();

        public List<Ciudad_Mdl> listaCiudades()
        {

            return objCiudad.listaCiudades();

        }

        public List<Ciudad_Mdl> listaCiudades(int idEstado)
        {

            return objCiudad.listaCiudades(idEstado);

        }

        public List<Ciudad_Mdl> CiudadSeleccionada(int idEstado, int idCiudad)
        {

            return objCiudad.CiudadSeleccionada(idEstado, idCiudad);

        }

        public Boolean NuevaCiudad(DataTable dtCiudad)
        {

            return objCiudad.NuevaCiudad(dtCiudad);

        }

        public Boolean EditaCiudad(DataTable dtCiudad)
        {

            return objCiudad.EditaCiudad(dtCiudad);

        }

    }

}
