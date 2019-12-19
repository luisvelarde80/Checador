using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class Banco_Ctl
    {

        Banco_Cls objBanco = new Banco_Cls();

        public List<Banco_Mdl> ListaBancos()
        {

            return objBanco.ListaBancos();
            
        }

    }

}
