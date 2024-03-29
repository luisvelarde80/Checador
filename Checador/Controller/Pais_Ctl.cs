﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;
using System.Data;

namespace Checador.Controller
{
    public class Pais_Ctl
    {
        Pais_Cls objPais = new Pais_Cls();

        public List<Pais_Mdl> ListaPaises()
        {

            return objPais.ListaPaises();

        }

        public List<Pais_Mdl> PaisSeleccionado(int idPais)
        {

            return objPais.PaisSeleccionado(idPais);

        }

        public Boolean NuevoPais(DataTable dtPais) 
        {

            return objPais.NuevoPais(dtPais);

        }

        public Boolean EditarPais(DataTable dtPais)
        {

            return objPais.EditarPais(dtPais);

        }

    }

}
