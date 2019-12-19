using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    class Contrato_Ctl
    {

        Contrato_Cls objContrato = new Contrato_Cls();

        public List<Contrato_Mdl> ListarContrato()
        {

            return objContrato.ListarContrato();

        }

    }

}
