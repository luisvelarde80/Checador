using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador.Model;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
    public class Puesto_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Puesto_Mdl> ListarPuestos()
        {

            List<Puesto_Mdl> listapuestos = new List<Puesto_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_puesto, ";
                strSql += "puesto ";
                strSql += "FROM ";
                strSql += "cat_puesto";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Puesto_Mdl objPuesto = new Puesto_Mdl();

                    objPuesto.id_puesto = Convert.ToInt32(rdrObj[0].ToString());
                    objPuesto.puesto = rdrObj[1].ToString();

                    listapuestos.Add(objPuesto);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listapuestos;

        }

        public List<Puesto_Mdl> PuestoSeleccionado(int idPuesto)
        {

            List<Puesto_Mdl> listapuestos = new List<Puesto_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_puesto, ";
                strSql += "puesto ";
                strSql += "FROM ";
                strSql += "cat_puesto ";
                strSql += "WHERE ";
                strSql += "id_puesto = " + idPuesto + "";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Puesto_Mdl objPuesto = new Puesto_Mdl();

                    objPuesto.id_puesto = Convert.ToInt32(rdrObj[0].ToString());
                    objPuesto.puesto = rdrObj[1].ToString();

                    listapuestos.Add(objPuesto);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listapuestos;

        }

        public int NuevoPuesto(string puesto)
        {

            int Valor = 0;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "INSERT ";
                strSql += "INTO ";
                strSql += "cat_puesto ";
                strSql += "(puesto) ";
                strSql += "VALUES ";
                strSql += "('" + puesto + "'";

                cmdObj.CommandText = strSql;

                try
                {
                
                    cmdObj.ExecuteNonQuery();
                    Valor = 1;
                }
                catch(MySqlException ex)
                {

                    MessageBox.Show("Error al Ingresar los Datos, " + ex.Message,"Error Critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Valor = 0;
                }

            }

            cnObj.Close();
            return Valor;

        }

        public int EditaPuesto(int idPuesto, string puesto)
        {

            int Valor = 0;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "UPDATE ";
                strSql += "cat_puesto ";
                strSql += "SET ";
                strSql += "puesto = '"+ puesto + "' ";
                strSql += "WHERE ";
                strSql += "id_puesto = " + idPuesto + "";

                cmdObj.CommandText = strSql;

                try
                {

                    cmdObj.ExecuteNonQuery();
                    Valor = 1;

                }
                catch (MySqlException ex)
                {

                    MessageBox.Show("Error al Ingresar los Datos, " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Valor = 0;

                }

            }

            cnObj.Close();
            return Valor;

        }

    }

}
