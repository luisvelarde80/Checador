using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Checador.Model;

namespace Checador.Model.Clases
{
    public class Jornada_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Jornada_Mdl> ListaJornada()
        {

            List<Jornada_Mdl> listajornada = new List<Jornada_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql = "";

                strSql = "SELECT ";
                strSql += "id_jornada, ";
                strSql += "clave, ";
                strSql += "jornada ";
                strSql += "FROM ";
                strSql += "cat_jornada";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Jornada_Mdl objJornada = new Jornada_Mdl();

                    objJornada.id_jornada = Convert.ToInt32(rdrObj[0].ToString());
                    objJornada.clave = rdrObj[1].ToString();
                    objJornada.jornada = rdrObj[2].ToString();

                    listajornada.Add(objJornada);

                }

                rdrObj.Close();

            }

            cnObj.Close();

            return listajornada;

        }

    }

}
