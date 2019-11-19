using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
    public class Pais_Cls
    {

        public List<Pais_Mdl> listaPaises()
        {

            List<Pais_Mdl> listapaises = new List<Pais_Mdl>();
            Conexion_Cls objConexion = new Conexion_Cls();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_pais, ";
                strSql += "clave, ";
                strSql += "pais ";
                strSql += "FROM ";
                strSql += "pais";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Pais_Mdl objPais = new Pais_Mdl();

                    objPais.id_pais = rdrObj[0].ToString();
                    objPais.clave = rdrObj[1].ToString();
                    objPais.pais = rdrObj[2].ToString();

                    listapaises.Add(objPais);

                }

                rdrObj.Close();
                cnObj.Close();
                
            }

            return listapaises;
            
        }
         
        public void NuevoPais(DataTable dtPais)
        {

        }

    }

}
