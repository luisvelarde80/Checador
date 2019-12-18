using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;

namespace Checador.Controller
{
    public class Direccion_Ctl
    {

        Direccion_Cls objDireccion = new Direccion_Cls();

        public List<Direccion_Mdl> DireccionEmpleado(int idEmp)
        {

            return objDireccion.DireccionEmpleado(idEmp);

        }

    }

}
