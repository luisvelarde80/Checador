using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class Metodo_Pago_Ctl
    {

        Metodo_Pago_Cls objMetodoPago = new Metodo_Pago_Cls();

        public List<Metodo_Pago_Mdl> ListarMetodoPago()
        {

            return objMetodoPago.ListarMetodoPago();

        }

    }

}
