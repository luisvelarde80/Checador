using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model.Clases;
using Checador.Model;

namespace Checador.Controller
{

    public class Jornada_Ctl
    {

        Jornada_Cls objJornada = new Jornada_Cls();

        public List<Jornada_Mdl> ListaJornada()
        {

            return objJornada.ListaJornada();

        }

    }

}
