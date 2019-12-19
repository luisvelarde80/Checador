using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Checador.Model;

namespace Checador.Model.Clases
{
   public class Metodo_Pago_Cls
    {

        public List<Metodo_Pago_Mdl> ListarMetodoPago()
        {

            List<Metodo_Pago_Mdl> listarmetodopago = new List<Metodo_Pago_Mdl>();
            Conexion_Cls objConexion = new Conexion_Cls();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql = "";

                strSql = "SELECT ";
                strSql += "id_metodo_pago, ";
                strSql += "clave, ";
                strSql += "metodo_pago ";
                strSql += "FROM ";
                strSql += "cat_metodo_pago";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Metodo_Pago_Mdl objMetodoPago = new Metodo_Pago_Mdl();

                    objMetodoPago.id_metodo_pago = Convert.ToInt32(rdrObj[0].ToString());
                    objMetodoPago.clave = rdrObj[1].ToString();
                    objMetodoPago.metodo_pago = rdrObj[2].ToString();

                    listarmetodopago.Add(objMetodoPago);

                }

                rdrObj.Close();

            }

            cnObj.Close();

            return listarmetodopago;

        }

    }

}
