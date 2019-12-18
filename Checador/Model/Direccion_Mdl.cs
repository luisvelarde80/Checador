using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checador.Model
{
    public class Direccion_Mdl
    {

        public int id_direccion { get; set; }

        public int id_empleado { get; set; }

        public string calle { get; set; }

        public string num_ext { get; set; }

        public string num_int { get; set; }

        public string colonia { get; set; }

        public string cod_postal { get; set; }

        public int id_pais { get; set; }

        public int id_estado { get; set; }
        
        public int id_ciudad { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public string celular { get; set; }

    }

}
