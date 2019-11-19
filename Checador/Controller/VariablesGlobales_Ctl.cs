using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;

namespace Checador.Controller
{
    public class VariablesGlobales_Ctl
    {

        private static int IdSucursal = 0;

        public static void setIdSucursal(int _idSuc)
        {

            IdSucursal = _idSuc;    

        }

        public static  int getIdSucursal()
        {

            return IdSucursal;

        }

    }

}
