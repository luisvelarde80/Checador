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
   
    public class Ciudad_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Ciudad_Mdl> listaCiudades()
        {

            List<Ciudad_Mdl> listaciudades = new List<Ciudad_Mdl>();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                strSql = "SELECT ";
                strSql += "id_ciudad, ";
                strSql += "id_estado, ";
                strSql += "ciudad ";
                strSql += "FROM ";
                strSql += "ciudad";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Ciudad_Mdl objCiudad = new Ciudad_Mdl();

                    objCiudad.id_ciudad = Convert.ToInt32(rdrObj[0].ToString());
                    objCiudad.id_estado = rdrObj[1].ToString();
                    objCiudad.ciudad = rdrObj[3].ToString();

                    listaciudades.Add(objCiudad);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaciudades;

        }

        public List<Ciudad_Mdl> listaCiudades(string idEstado)
        {

            List<Ciudad_Mdl> listaciudades = new List<Ciudad_Mdl>();
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                strSql = "SELECT ";
                strSql += "id_ciudad, ";
                strSql += "id_estado, ";
                strSql += "ciudad ";
                strSql += "FROM ";
                strSql += "ciudad ";
                strSql += "WHERE ";
                strSql += "id_estado = '" + idEstado + "'";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Ciudad_Mdl objCiudad = new Ciudad_Mdl();

                    objCiudad.id_ciudad = Convert.ToInt32(rdrObj[0].ToString());
                    objCiudad.id_estado = rdrObj[1].ToString();
                    objCiudad.ciudad = rdrObj[3].ToString();

                    listaciudades.Add(objCiudad);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaciudades;

        }

        public Boolean NuevaCiudad(DataTable dtCiudad)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach(DataRow dRow in dtCiudad.Rows)
                {

                    strSql = "INSERT ";
                    strSql += "INTO ";
                    strSql += "ciudad ";
                    strSql += "(id_estado, ";
                    strSql += "ciudad) ";
                    strSql += "VALUES ";
                    strSql += "(" + dRow["id_estado"] + ", ";
                    strSql += "'" + dRow["ciudad"] + "')";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        MessageBox.Show("Datos Guardados","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Valor = true;
                    }
                    catch(MySqlException ex)
                    {

                        MessageBox.Show("Error al  Guardar los Datos " + Environment.NewLine + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valor = false;

                    }

                }

                cnObj.Close();
            }
           
            return Valor;

        }

        public Boolean EditaCiudad(DataTable dtCiudad)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach (DataRow dRow in dtCiudad.Rows)
                {

                    strSql = "UPDATE ";
                    strSql += "ciudad ";
                    strSql += "SET ";
                    strSql += "id_estado = " + dRow["id_estado"] + ", ";
                    strSql += "ciudad = '" + dRow["ciudad"] + "' ";
                    strSql += "WHERE ";
                    strSql += "id_ciudad = "+ dRow["id_ciudad"] +"";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Valor = true;
                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al  Guardar los Datos " + Environment.NewLine + ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valor = false;

                    }

                }

                cnObj.Close();
            }

            return Valor;

        }

    }

}
