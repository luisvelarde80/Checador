using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checador.Model;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Checador.Model.Clases
{
    public class Estado_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Estado_Mdl> listaEstados()
        {

            List<Estado_Mdl> listaestados = new List<Estado_Mdl>();    
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
                    objEstado.estado = rdrObj[2].ToString();

                    listaestados.Add(objEstado);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaestados;

        }

        public List<Estado_Mdl> listaEstados(int idPais)
        {

            List<Estado_Mdl> listaestados = new List<Estado_Mdl>();
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
                strSql += "estado ";
                strSql += "FROM ";
                strSql += "estado ";
                strSql += "WHERE ";
                strSql += "id_pais = '" + idPais + "'";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Estado_Mdl objEstado = new Estado_Mdl();

                    objEstado.id_estado = rdrObj[0].ToString();
                    objEstado.id_pais = rdrObj[1].ToString();
                    objEstado.estado = rdrObj[2].ToString();

                    listaestados.Add(objEstado);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaestados;

        }

        public List<Estado_Mdl> EstadoSeleccionado(int idPais, int idEstado)
        {

            List<Estado_Mdl> listaestados = new List<Estado_Mdl>();
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
                strSql += "estado ";
                strSql += "FROM ";
                strSql += "estado ";
                strSql += "WHERE ";
                strSql += "id_pais = '" + idPais + "' AND ";
                strSql += "id_estado = " + idEstado + "";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Estado_Mdl objEstado = new Estado_Mdl();

                    objEstado.id_estado = rdrObj[0].ToString();
                    objEstado.id_pais = rdrObj[1].ToString();
                    objEstado.estado = rdrObj[2].ToString();

                    listaestados.Add(objEstado);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaestados;

        }

        public Boolean NuevoEstado(DataTable dtEstado)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach(DataRow dRow in dtEstado.Rows)
                {

                    strSql = "INSERT ";
                    strSql += "INTO ";
                    strSql += "estado ";
                    strSql += "(id_pais, ";
                    strSql += "estado) ";
                    strSql += "VALUES ";
                    strSql += "(" + dRow["id_pais"] + ", ";
                    strSql += "'" + dRow["estado"] + "')";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        MessageBox.Show("Datos Guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Valor = true;

                    }catch(MySqlException ex)
                    {

                        MessageBox.Show("Error al Guardar los Datos " + Environment.NewLine + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valor = false;

                    }

                }

                cnObj.Close();

            }

            return Valor;

        }

        public Boolean EditaEstado(DataTable dtEstado)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach (DataRow dRow in dtEstado.Rows)
                {

                    strSql = "UPDATE ";
                    strSql += "estado ";
                    strSql += "SET ";
                    strSql += "id_pais = " + dRow["id_pais"] + ", ";
                    strSql += "estado = '" + dRow["estado"] + "' ";
                    strSql += "WHERE ";
                    strSql += "id_estado = "+ dRow["id_estado"] +"";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Valor = true;

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al Actualizar los Datos " + Environment.NewLine + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valor = false;

                    }

                }

                cnObj.Close();

            }

            return Valor;
        }
            
    }

}
