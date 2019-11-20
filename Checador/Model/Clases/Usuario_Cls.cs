using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador.Model;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
    public class Usuario_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Usuario_Mdl> listaUsuario()
        {

            List<Usuario_Mdl> listausuario = new List<Usuario_Mdl>();
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

        public List<Usuario_Mdl> UsuarioSeleccionado(int idUsu)
        {

            List<Usuario_Mdl> listausuario = new List<Usuario_Mdl>();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
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
                strSql += "id_usuario = " + idUsu + " AND ";
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

        public Boolean NuevoUsuario(DataTable dtUsuario)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach(DataRow dRow in dtUsuario.Rows)
                {

                    strSql = "INSERT ";
                    strSql += "INTO ";
                    strSql += "usuario ";
                    strSql += "(nombre, ";
                    strSql += "password, ";
                    strSql += "id_rol, ";
                    strSql += "correo, ";
                    strSql += "telefono, ";
                    strSql += "extencion, ";
                    strSql += "alta, ";
                    strSql += "baja, ";
                    strSql += "estatus, ";
                    strSql += "reset_pass) ";
                    strSql += "VALUES ";
                    strSql += "'"+ dRow["nombre"] + "' , ";
                    strSql += "'" + dRow["password"] + "', ";
                    strSql += ""+ dRow["id_rol"] + ", ";
                    strSql += "'"+ dRow["correo"] + "', ";
                    strSql += "'"+ dRow["telefono"] + "', ";
                    strSql += "'"+ dRow["extencion"] + "', ";
                    strSql += "'"+ dRow["alta"] + "', ";
                    strSql += "'"+ dRow["baja"] + "', ";
                    strSql += "" + dRow["estatus"] + ", ";
                    strSql += "" + dRow["reset_pass"] + ")";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        Valor = true;
                        MessageBox.Show("Datos Guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }catch(MySqlException ex)
                    {

                        MessageBox.Show("Error al Guardar los Datos, " + Environment.NewLine + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Valor = false;

                    }

                }

            }

            cnObj.Close();
            return Valor;

        }

        public Boolean EditaUsuario(DataTable dtUsuario)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach (DataRow dRow in dtUsuario.Rows)
                {

                    strSql = "UPDATE ";
                    strSql += "usuario ";
                    strSql += "SET ";
                    strSql += "nombre = '" + dRow["nombre"] + "', ";
                    strSql += "password = '" + dRow["password"] + "', ";
                    strSql += "id_rol = " + dRow["id_rol"] + ", ";
                    strSql += "correo = '" + dRow["correo"] + "', ";
                    strSql += "telefono = '" + dRow["telefono"] + "', ";
                    strSql += "extencion = '" + dRow["extencion"] + "', ";
                    strSql += "baja = '" + dRow["baja"] + "', ";
                    strSql += "estatus = " + dRow["estatus"] + ", ";
                    strSql += "reset_pass = " + dRow["reset_pass"] + " ";
                    strSql += "WHERE ";
                    strSql += "id_usuario = " + dRow["id_usuario"] + "";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        Valor = true;
                        MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al Guardar los Datos, " + Environment.NewLine + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Valor = false;

                    }

                }

            }

            cnObj.Close();
            return Valor;

        }

    }

}
