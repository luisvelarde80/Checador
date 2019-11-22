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
    public class Estado_Ctl
    {

        Estado_Cls objEstados = new Estado_Cls();

        public List<Estado_Mdl> listaEstados()
        {

            return objEstados.listaEstados();

        }

        public List<Estado_Mdl> listaEstados(int idPais)
        {

            return objEstados.listaEstados(idPais);

        }

        public List<Estado_Mdl> EstadoSeleccionado(int idPais, int idEstado)
        {

            return objEstados.EstadoSeleccionado(idPais, idEstado);

        }

        public Boolean NuevoEstado(DataTable dtEstado)
        {

            return objEstados.NuevoEstado(dtEstado);

        }

        public Boolean EditaEstado(DataTable dtEstado)
        {

            return objEstados.EditaEstado(dtEstado);

        }

    }

}
