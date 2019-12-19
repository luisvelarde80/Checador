using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Checador.Model;

namespace Checador.Model.Clases
{
    public class Contrato_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Contrato_Mdl> ListarContrato()
        {

            List<Contrato_Mdl> listarcontrato = new List<Contrato_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql = "";

                strSql = "SELECT ";
                strSql += "id_contrato, ";
                strSql += "clave, ";
                strSql += "contrato ";
                strSql += "FROM ";
                strSql += "cat_contrato";

                cmdObj.CommandText = strSql;

                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Contrato_Mdl objContrato = new Contrato_Mdl();

                    objContrato.id_contrato = Convert.ToInt32(rdrObj[0].ToString());
                    objContrato.clave = rdrObj[1].ToString();
                    objContrato.contrato = rdrObj[2].ToString();

                    listarcontrato.Add(objContrato);

                }

                rdrObj.Close();

            }

            cnObj.Close();

            return listarcontrato;

        }

    }

}
