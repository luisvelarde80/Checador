using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
    public class Estado_Cls
    {

        public List<Estado_Mdl> listaEstados()
        {

            List<Estado_Mdl> listaestados = new List<Estado_Mdl>();
            Conexion_Cls objConexion = new Conexion_Cls();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;
                strSql = "SELECT ";
                strSql += "id_estado, ";
                strSql += "id_pais, ";
                strSql += "clave, ";
                strSql += "estado ";
                strSql += "FROM ";
                strSql += "estado";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Estado_Mdl objEstado = new Estado_Mdl();

                    objEstado.id_estado = rdrObj[0].ToString();
                    objEstado.id_pais = rdrObj[1].ToString();
                    objEstado.clave = rdrObj[2].ToString();
                    objEstado.estado = rdrObj[3].ToString();

                    listaestados.Add(objEstado);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaestados;

        }

        public List<Estado_Mdl> listaEstados(string idEstado)
        {

            List<Estado_Mdl> listaestados = new List<Estado_Mdl>();
            Conexion_Cls objConexion = new Conexion_Cls();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;
                strSql = "SELECT ";
                strSql += "id_estado, ";
                strSql += "id_pais, ";
                strSql += "clave, ";
                strSql += "estado ";
                strSql += "FROM ";
                strSql += "estado ";
                strSql += "WHERE ";
                strSql += "id_pais = '" + idEstado + "'";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Estado_Mdl objEstado = new Estado_Mdl();

                    objEstado.id_estado = rdrObj[0].ToString();
                    objEstado.id_pais = rdrObj[1].ToString();
                    objEstado.clave = rdrObj[2].ToString();
                    objEstado.estado = rdrObj[3].ToString();

                    listaestados.Add(objEstado);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaestados;

        }

    }

}
