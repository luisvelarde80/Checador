using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Checador.Model;

namespace Checador.Model.Clases
{
    public class Banco_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Banco_Mdl> ListaBancos()
        {

            List<Banco_Mdl> listabancos = new List<Banco_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql = "";

                strSql = "SELECT ";
                strSql += "id_banco, ";
                strSql += "clave, ";
                strSql += "banco ";
                strSql += "FROM ";
                strSql += "cat_banco";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Banco_Mdl objBanco = new Banco_Mdl();

                    objBanco.id_banco = Convert.ToInt32(rdrObj[0].ToString());
                    objBanco.clave = rdrObj[1].ToString();
                    objBanco.banco = rdrObj[2].ToString();

                    listabancos.Add(objBanco);

                }

                rdrObj.Close();

            }

            cnObj.Close();

            return listabancos;

        }

    }
}
