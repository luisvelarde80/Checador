using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
   
    public class Ciudad_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Ciudad_Mdl> listaCiudades()
        {

            List<Ciudad_Mdl> listaciudades = new List<Ciudad_Mdl>();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                strSql = "SELECT ";
                strSql += "id_ciudad, ";
                strSql += "id_estado, ";
                strSql += "clave, ";
                strSql += "ciudad ";
                strSql += "FROM ";
                strSql += "ciudad";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Ciudad_Mdl objCiudad = new Ciudad_Mdl();

                    objCiudad.id_ciudad = Convert.ToInt32(rdrObj[0].ToString());
                    objCiudad.id_estado = rdrObj[1].ToString();
                    objCiudad.clave = rdrObj[2].ToString();
                    objCiudad.ciudad = rdrObj[3].ToString();

                    listaciudades.Add(objCiudad);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaciudades;

        }

        public List<Ciudad_Mdl> listaCiudades(string idEstado)
        {

            List<Ciudad_Mdl> listaciudades = new List<Ciudad_Mdl>();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                strSql = "SELECT ";
                strSql += "id_ciudad, ";
                strSql += "id_estado, ";
                strSql += "clave, ";
                strSql += "ciudad ";
                strSql += "FROM ";
                strSql += "ciudad ";
                strSql += "WHERE ";
                strSql += "id_estado = '" + idEstado + "'";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Ciudad_Mdl objCiudad = new Ciudad_Mdl();

                    objCiudad.id_ciudad = Convert.ToInt32(rdrObj[0].ToString());
                    objCiudad.id_estado = rdrObj[1].ToString();
                    objCiudad.clave = rdrObj[2].ToString();
                    objCiudad.ciudad = rdrObj[3].ToString();

                    listaciudades.Add(objCiudad);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaciudades;

        }

    }

}
