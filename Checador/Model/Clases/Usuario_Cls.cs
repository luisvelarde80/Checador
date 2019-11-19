using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
    public class Usuario_Cls
    {

        public List<Usuario_Mdl> listaUsuario()
        {

            List<Usuario_Mdl> listausuario = new List<Usuario_Mdl>();

            Conexion_Cls objConexion = new Conexion_Cls();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_usuario, ";
                strSql += "nombre, ";
                strSql += "password, ";
                strSql += "id_rol, ";
                strSql += "correo, ";
                strSql += "telefono, ";
                strSql += "extencion, ";
                strSql += "alta, ";
                strSql += "baja, ";
                strSql += "estatus, ";
                strSql += "reset_pass ";
                strSql += "FROM ";
                strSql += "usuario ";
                strSql += "WHERE ";
                strSql += "estatus = 1";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();
                while (rdrObj.Read())
                {

                    Usuario_Mdl objUsuario = new Usuario_Mdl();

                    objUsuario.id_usuario = rdrObj[0].ToString();
                    objUsuario.nombre = rdrObj[1].ToString();
                    objUsuario.password = rdrObj[2].ToString();
                    objUsuario.id_rol = Convert.ToInt32(rdrObj[3].ToString());
                    objUsuario.correo = rdrObj[4].ToString();
                    objUsuario.telefono = rdrObj[5].ToString();
                    objUsuario.extencion = rdrObj[6].ToString();
                    objUsuario.alta = Convert.ToDateTime(rdrObj[7]).ToString("yyyyMMdd");
                    objUsuario.baja = Convert.ToDateTime(rdrObj[8]).ToString("yyyyMMdd");
                    objUsuario.estatus = Convert.ToInt32(rdrObj[9].ToString());
                    objUsuario.reset_pass = Convert.ToInt32(rdrObj[10].ToString());

                    listausuario.Add(objUsuario);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listausuario;

        }

    }

}
