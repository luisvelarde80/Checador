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
    public class Sucursal_Ctl
    {

        public List<Sucursal_Mdl> listaSucursal()
        {

            Sucursal_Cls objSucursales = new Sucursal_Cls();
            return objSucursales.listaSucursal();

        }

        public List<Sucursal_Mdl> sucursalSeleccionada(int id)
        {

            Sucursal_Cls objSucursal = new Sucursal_Cls();
            return objSucursal.sucursalSeleccionada(id);

        }

        public Boolean AgregaSucursal(DataTable sucursal)
        {

            Sucursal_Cls objSucursal = new Sucursal_Cls();
            return objSucursal.AgregaSucursal(sucursal);

        }

        public Boolean EditaSucursal(DataTable sucursal)
        {

            Sucursal_Cls objSucursal = new Sucursal_Cls();
            return objSucursal.EditaSucursal(sucursal);

        }

    }

}
