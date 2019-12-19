using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Checador.Model;

namespace Checador.Model.Clases
{
    public class Tipo_Salario_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Tipo_Salario_Mdl> ListarTipoSalario()
        {

            List<Tipo_Salario_Mdl> listartiposalario = new List<Tipo_Salario_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql = "";

                strSql = "SELECT ";
                strSql += "id_tipo_salario, ";
                strSql += "clave, ";
                strSql += "tipo_salario ";
                strSql += "FROM ";
                strSql += "cat_tipo_salario";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Tipo_Salario_Mdl objTipoSalario = new Tipo_Salario_Mdl();

                    objTipoSalario.id_tipo_salario = Convert.ToInt32(rdrObj[0].ToString());
                    objTipoSalario.clave = rdrObj[1].ToString();
                    objTipoSalario.tipo_salario = rdrObj[2].ToString();

                    listartiposalario.Add(objTipoSalario);

                }

                rdrObj.Close();

            }

            cnObj.Close();

            return listartiposalario;

        }

    }

}
