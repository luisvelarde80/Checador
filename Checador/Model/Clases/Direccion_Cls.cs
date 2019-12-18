using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Checador.Model;

namespace Checador.Model.Clases
{
    public class Direccion_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Direccion_Mdl> DireccionEmpleado(int idEmp)
        {

            List<Direccion_Mdl> direccionempleado = new List<Direccion_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql = "";

                strSql = "SELECT ";
                strSql += "id_direccion, ";
                strSql += "id_empleado, ";
                strSql += "calle, ";
                strSql += "num_ext, ";
                strSql += "num_int, ";
                strSql += "colonia, ";
                strSql += "cod_postal, ";
                strSql += "id_pais, ";
                strSql += "id_estado, ";
                strSql += "id_ciudad, ";
                strSql += "telefono, ";
                strSql += "correo, ";
                strSql += "celular ";
                strSql += "FROM ";
                strSql += "direccion ";
                strSql += "WHERE ";
                strSql += "id_empleado = " + idEmp + "";

                cmdObj.CommandText = strSql;

                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Direccion_Mdl objDireccion = new Direccion_Mdl();

                    objDireccion.id_direccion = Convert.ToInt32(rdrObj[0].ToString());
                    objDireccion.id_empleado = Convert.ToInt32(rdrObj[1].ToString());
                    objDireccion.calle = rdrObj[2].ToString();
                    objDireccion.num_ext = rdrObj[3].ToString();
                    objDireccion.num_int = rdrObj[4].ToString();
                    objDireccion.colonia = rdrObj[5].ToString();
                    objDireccion.cod_postal = rdrObj[6].ToString();
                    objDireccion.id_pais = Convert.ToInt32(rdrObj[7].ToString());
                    objDireccion.id_estado = Convert.ToInt32(rdrObj[8].ToString());
                    objDireccion.id_ciudad = Convert.ToInt32(rdrObj[9].ToString());
                    objDireccion.telefono = rdrObj[10].ToString();
                    objDireccion.correo = rdrObj[11].ToString();
                    objDireccion.celular = rdrObj[12].ToString();

                    direccionempleado.Add(objDireccion);

                }

                rdrObj.Close();
               
            }

            cnObj.Close();

            return direccionempleado;

        }

    }

}
