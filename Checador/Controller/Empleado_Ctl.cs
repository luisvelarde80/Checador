using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;

namespace Checador.Controller
{
    public class Empleado_Ctl
    {

        Empleado_Cls objEmpleado = new Empleado_Cls();

        public List<Empleado_Mdl> ListaEmpleados(int _estatus)
        {

            return objEmpleado.ListaEmpleados(_estatus);
        
        }

        public List<Empleado_Mdl> EmpleadoSeleccionado(int idEmpleado)
        {

            return objEmpleado.EmpleadoSeleccionado(idEmpleado);

        }

        public Boolean NuevoEmpleado(DataTable dtEmpleado, DataTable dtDireccion, DataTable dtRh)
        {

            return NuevoEmpleado(dtEmpleado, dtDireccion, dtRh);

        }

    }

}
