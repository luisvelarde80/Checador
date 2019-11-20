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
    public class Pais_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Pais_Mdl> listaPaises()
        {

            List<Pais_Mdl> listapaises = new List<Pais_Mdl>();          
            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_pais, ";
                strSql += "pais ";
                strSql += "FROM ";
                strSql += "pais";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Pais_Mdl objPais = new Pais_Mdl();

                    objPais.id_pais = rdrObj[0].ToString();
                    objPais.pais = rdrObj[2].ToString();

                    listapaises.Add(objPais);

                }

                rdrObj.Close();
                cnObj.Close();
                
            }

            return listapaises;
            
        }

        public Boolean NuevoPais(DataTable dtPais)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach (DataRow dRow in dtPais.Rows)
                {

                    strSql = "INSERT ";
                    strSql += "INTO ";
                    strSql += "pais ";
                    strSql += "(pais) ";
                    strSql += "VALUES ";
                    strSql += "('" + dRow["pais"] + "'";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Valor = true;

                    } catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al Guardar los Datos " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valor = false;

                    }

                }

                cnObj.Close();
                
            }

            return Valor;

        }

        public Boolean EditarPais(DataTable dtPais)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                foreach (DataRow dRow in dtPais.Rows)
                {

                    strSql = "UPDATE ";
                    strSql += "pais ";
                    strSql += "SET ";
                    strSql += "pais = '" + dRow["pais"] + "' ";
                    strSql += "WHERE ";
                    strSql += "id_pais = "+ dRow["id_pais"] +"";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Valor = true;

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al Actualizar los Datos " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Valor = false;

                    }

                }

                cnObj.Close();

            }

            return Valor;

        }

    }

}
