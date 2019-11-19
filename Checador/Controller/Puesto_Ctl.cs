using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;

namespace Checador.Controller
{
    public class Puesto_Ctl
    {

        Puesto_Cls objPuestos = new Puesto_Cls();

        public List<Puesto_Mdl> ListarPuestos()
        {

            return objPuestos.ListarPuestos();

        }

        public List<Puesto_Mdl> PuestoSeleccionado(int idPuesto)
        {

            return objPuestos.PuestoSeleccionado(idPuesto);

        }

        public int NuevoPuesto(string puesto)
        {

            return objPuestos.NuevoPuesto(puesto);

        }

        public int EditaPuesto(int idPuesto, string puesto)
        {

            return objPuestos.EditaPuesto(idPuesto, puesto);

        }

    }

}
