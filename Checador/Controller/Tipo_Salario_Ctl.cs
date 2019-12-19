using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class Tipo_Salario_Ctl
    {

        Tipo_Salario_Cls objTipoSalario = new Tipo_Salario_Cls();

        public List<Tipo_Salario_Mdl> ListarTipoSalario()
        {

            return objTipoSalario.ListarTipoSalario();

        }

    }

}
