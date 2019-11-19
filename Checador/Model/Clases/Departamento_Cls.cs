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
    public class Departamento_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Departamento_Mdl> ListaDepartamentos(int idSuc)
        {

            List<Departamento_Mdl> listaDepartamentos = new List<Departamento_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {
                
                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_departamento, ";
                strSql += "id_sucursal, ";
                strSql += "departamento ";
                strSql += "FROM ";
                strSql += "cat_departamentos ";
                strSql += "WHERE ";
                strSql += "id_sucursal = '" + idSuc + "'";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Departamento_Mdl objDep = new Departamento_Mdl();

                    objDep.id_departamento = Convert.ToInt32(rdrObj[0].ToString());
                    objDep.id_sucursal = Convert.ToInt32(rdrObj[1].ToString());
                    objDep.departamento = rdrObj[2].ToString();

                    listaDepartamentos.Add(objDep);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaDepartamentos;

        }

        public List<Departamento_Mdl> DeptoSeleccionado(int idSuc, int idDepto)
        {

            List<Departamento_Mdl> listaDepartamentos = new List<Departamento_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_departamento, ";
                strSql += "id_sucursal, ";
                strSql += "departamento ";
                strSql += "FROM ";
                strSql += "cat_departamentos ";
                strSql += "WHERE ";
                strSql += "id_sucursal = " + idSuc + " AND ";
                strSql += "id_departamento = " + idDepto + "";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Departamento_Mdl objDep = new Departamento_Mdl();

                    objDep.id_departamento = Convert.ToInt32(rdrObj[0].ToString());
                    objDep.id_sucursal = Convert.ToInt32(rdrObj[1].ToString());
                    objDep.departamento = rdrObj[2].ToString();

                    listaDepartamentos.Add(objDep);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listaDepartamentos;

        }

        public int NuevoDepartamento(int idSuc, string Depto)
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
                strSql += "cat_departamentos ";
                strSql += "(id_sucursal, ";
                strSql += "departamento) ";
                strSql += "VALUES ";
                strSql += "(" + idSuc + ", ";
                strSql += "'" + Depto + "')";

                cmdObj.CommandText = strSql;

                try
                {

                    cmdObj.ExecuteNonQuery();
                    MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Valor = 1;

                }catch(MySqlException ex)
                {

                    MessageBox.Show("Error al Ingresar los Datos, " + ex.Message,"Error Critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Valor = 0;
                }

            }

            cnObj.Close();
            return Valor;

        }

        public int EditaDepartamento(int idDepto, string Depto)
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
                strSql += "cat_departamentos ";
                strSql += "SET ";
                strSql += "departamento = '"+ Depto + "' ";
                strSql += "WHERE ";
                strSql += "id_departamento = " + idDepto + "";

                cmdObj.CommandText = strSql;

                try
                {

                    cmdObj.ExecuteNonQuery();
                    MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
