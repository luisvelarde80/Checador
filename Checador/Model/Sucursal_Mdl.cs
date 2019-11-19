using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checador.Model
{
    public class Sucursal_Mdl
    {

        public int id_sucursal { get; set; }

        public int id_empresa { get; set; }

        public string sucursal { get; set; }

        public string calle { get; set; }

        public string num_ext { get; set; }

        public string num_int { get; set; }

        public string colonia { get; set; }

        public string codigo_pos { get; set; }

        public string pais { get; set; }

        public string estado { get; set; }

        public int ciudad { get; set; }

        public string telefono { get; set; }

        public string extencion { get; set; }

        public string correo { get; set; }

        public string responsable { get; set; }

        public int estatus { get; set; }

    }

}
