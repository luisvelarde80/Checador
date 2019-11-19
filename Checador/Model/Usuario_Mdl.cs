using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checador.Model
{
    public class Usuario_Mdl
    {

        public string id_usuario { get; set; }

        public string nombre { get; set; }

        public string password { get; set; }

        public int id_rol { get; set; }

        public string correo { get; set; }

        public string telefono { get; set; }

        public string extencion { get; set; }

        public string alta { get; set; }

        public string baja { get; set; }

        public int estatus { get; set; }

        public int reset_pass { get; set; }

    }

}
