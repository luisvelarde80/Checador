using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checador.Model
{
    public class Empleado_Mdl
    {

        public int id_empleado { get; set; }

        public string clave { get; set; }

        public string a_paterno { get; set; }

        public string a_materno { get; set; }

        public string nombre { get; set; }

        public string rfc { get; set; }

        public string curp { get; set; }

        public string nss { get; set; }

        public string fecha_nac { get; set; }

        public string alta { get; set; }

        public string baja { get; set; }

        public int estatus { get; set; }

    }


}
