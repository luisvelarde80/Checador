using Checador.Model;
using Checador.Model.Clases;
using System.Collections.Generic;

namespace Checador.Controller
{

    public class Departamento_Ctl
    {

        Departamento_Cls objDepartamento = new Departamento_Cls();

        public List<Departamento_Mdl> ListaDepartamentos(int idSuc)
        {

            return objDepartamento.ListaDepartamentos(idSuc);

        }

        public List<Departamento_Mdl> DeptoSeleccionado(int idSuc, int idDepto)
        {

            return objDepartamento.DeptoSeleccionado(idSuc, idDepto);

        }

        public int NuevoDepartamento(int idSuc, string Depto)
        {

            return objDepartamento.NuevoDepartamento(idSuc, Depto);

        }

        public int EditaDepartamento(int idDepto, string Depto)
        {

            return objDepartamento.EditaDepartamento(idDepto, Depto);

        }

    }

}
