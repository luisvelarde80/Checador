using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Checador.Model;
using MySql.Data.MySqlClient;


namespace Checador.Model.Clases
{
    public class Sucursal_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();


        /******************************************************************************************************************************
         *                                                                                                                                                           *
         *                                           Regresa el listado de las sucursales                                                           *
         *                                                                                                                                                           *
         ******************************************************************************************************************************/

        public List<Sucursal_Mdl> listaSucursal()
        {

            List<Sucursal_Mdl> listasucursal = new List<Sucursal_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_sucursal, ";
                strSql += "id_empresa, ";
                strSql += "sucursal, ";
                strSql += "calle, ";
                strSql += "num_ext, ";
                strSql += "num_int, ";
                strSql += "colonia, ";
                strSql += "id_pais, ";
                strSql += "id_estado, ";
                strSql += "id_ciudad, ";
                strSql += "cod_postal, ";
                strSql += "telefono, ";
                strSql += "extencion, ";
                strSql += "responsable, ";
                strSql += "correo, ";
                strSql += "estatus ";
                strSql += "FROM ";
                strSql += "sucursal ";
                strSql += "ORDER BY ";
                strSql += "id_sucursal";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Sucursal_Mdl objSucursal = new Sucursal_Mdl
                    {
                        id_sucursal = Convert.ToInt32(rdrObj[0].ToString()),
                        id_empresa = Convert.ToInt32(rdrObj[1].ToString()),
                        sucursal = rdrObj[2].ToString(),
                        calle = rdrObj[3].ToString(),
                        num_ext = rdrObj[4].ToString(),
                        num_int = rdrObj[5].ToString(),
                        colonia = rdrObj[6].ToString(),
                        pais = rdrObj[7].ToString(),
                        estado = rdrObj[8].ToString(),
                        ciudad = Convert.ToInt32(rdrObj[9].ToString()),
                        codigo_pos = rdrObj[10].ToString(),
                        telefono = rdrObj[11].ToString(),
                        extencion = rdrObj[12].ToString(),
                        responsable = rdrObj[13].ToString(),
                        correo = rdrObj[14].ToString(),
                        estatus = Convert.ToInt32(rdrObj[15].ToString())
                    };

                    listasucursal.Add(objSucursal);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listasucursal;

        }

        /******************************************************************************************************************************
         *                                                                                                                                                           *
         *                                    Regresa los datos de la sucursal seleccionada                                                   *
         *                                                                                                                                                           *
         ******************************************************************************************************************************/

        public List<Sucursal_Mdl> sucursalSeleccionada(int id)
        {

            List<Sucursal_Mdl> listasucursal = new List<Sucursal_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_sucursal, ";
                strSql += "id_empresa, ";
                strSql += "sucursal, ";
                strSql += "calle, ";
                strSql += "num_ext, ";
                strSql += "num_int, ";
                strSql += "colonia, ";
                strSql += "id_pais, ";
                strSql += "id_estado, ";
                strSql += "id_ciudad, ";
                strSql += "cod_postal, ";
                strSql += "telefono, ";
                strSql += "extencion, ";
                strSql += "responsable, ";
                strSql += "correo, ";
                strSql += "estatus ";
                strSql += "FROM ";
                strSql += "sucursal ";
                strSql += "WHERE ";
                strSql += "id_sucursal = " + id + "";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Sucursal_Mdl objSucursal = new Sucursal_Mdl
                    {
                        id_sucursal = Convert.ToInt32(rdrObj[0].ToString()),
                        id_empresa = Convert.ToInt32(rdrObj[1].ToString()),
                        sucursal = rdrObj[2].ToString(),
                        calle = rdrObj[3].ToString(),
                        num_ext = rdrObj[4].ToString(),
                        num_int = rdrObj[5].ToString(),
                        colonia = rdrObj[6].ToString(),
                        pais = rdrObj[7].ToString(),
                        estado = rdrObj[8].ToString(),
                        ciudad = Convert.ToInt32(rdrObj[9].ToString()),
                        codigo_pos = rdrObj[10].ToString(),
                        telefono = rdrObj[11].ToString(),
                        extencion = rdrObj[12].ToString(),
                        responsable = rdrObj[13].ToString(),
                        correo = rdrObj[14].ToString(),
                        estatus = Convert.ToInt32(rdrObj[15].ToString())
                    };

                    listasucursal.Add(objSucursal);

                }

                rdrObj.Close();
                cnObj.Close();

            }

            return listasucursal;
        }

        /******************************************************************************************************************************
         *                                                                                                                                                           *
         *                                         Agrega una nueva sucursal al catalogo                                                          *
         *                                                                                                                                                           *
         ******************************************************************************************************************************/
        public Boolean AgregaSucursal(DataTable sucursal)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                foreach(DataRow dRow in sucursal.Rows)
                {

                    strSql = "INSERT ";
                    strSql += "INTO ";
                    strSql += "sucursal ";
                    strSql += "(id_sucursal, ";
                    strSql += "id_empresa, ";
                    strSql += "sucursal, ";
                    strSql += "calle, ";
                    strSql += "num_ext, ";
                    strSql += "num_int, ";
                    strSql += "colonia, ";
                    strSql += "id_pais, ";
                    strSql += "id_estado, ";
                    strSql += "id_ciudad, ";
                    strSql += "cod_postal, ";
                    strSql += "telefono, ";
                    strSql += "extencion, ";
                    strSql += "responsable, ";
                    strSql += "correo, ";
                    strSql += "estatus) ";
                    strSql += "VALUES ";
                    strSql += "(" + dRow["id_sucursal"] + ", ";
                    strSql += "" + dRow["id_empresa"] +", ";
                    strSql += "'" + dRow["sucursal"] + "', ";
                    strSql += "'" + dRow["calle"] + "', ";
                    strSql += "'" + dRow["num_ext"] + "', ";
                    strSql += "'" + dRow["num_int"] + "', ";
                    strSql += "'" + dRow["colonia"] + "', ";
                    strSql += "'" + dRow["pais"] + "', ";
                    strSql += "'" + dRow["estado"] +"', ";
                    strSql += "" + dRow["ciudad"] + ", ";
                    strSql += "'" + dRow["codigo_pos"] + "', ";
                    strSql += "'" + dRow["telefono"] + "', ";
                    strSql += "'" + dRow["extencion"] + "', ";
                    strSql += "'" + dRow["responsable"]  + "', ";
                    strSql += "'" + dRow["correo"] + "', ";
                    strSql += "" + dRow["estatus"] + ") ";

                    cmdObj.CommandText = strSql;

                    try
                    {
                        
                        cmdObj.ExecuteNonQuery();
                        Valor = true;

                    }catch(MySqlException ex)
                    {

                        MessageBox.Show("Error al Ingresar los Datos, " + ex.Message, "Error Critico", MessageBoxButton.OK);
                        Valor = false;
           
                    }

                }

            }
            else
            {
                Valor = false;
            }

            return Valor;

        }

        /******************************************************************************************************************************
         *                                                                                                                                                           *   
         *                                                   Edita la sucursal seleccionada                                                            *
         *                                                                                                                                                           *
         ******************************************************************************************************************************/
        public Boolean EditaSucursal(DataTable sucursal)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                foreach (DataRow dRow in sucursal.Rows)
                {

                    strSql = "UPDATE ";
                    strSql += "sucursal ";
                    strSql += "SET ";
                    strSql += "id_empresa = " + dRow["id_empresa"] + ", ";
                    strSql += "sucursal = '" + dRow["sucursal"] + "', ";
                    strSql += "calle = '" + dRow["calle"] + "', ";
                    strSql += "num_ext = '" + dRow["num_ext"] + "', ";
                    strSql += "num_int = '" + dRow["num_int"] + "', ";
                    strSql += "colonia = '" + dRow["colonia"] + "', ";
                    strSql += "id_pais = " + dRow["pais"] + ", ";
                    strSql += "id_estado = " + dRow["estado"] + ", ";
                    strSql += "id_ciudad = " + dRow["ciudad"] + ", ";
                    strSql += "cod_postal =  '" + dRow["codigo_pos"] + "', ";
                    strSql += "telefono = '" + dRow["telefono"] + "', ";
                    strSql += "extencion = '"+ dRow["extencion"] +"', ";
                    strSql += "responsable = '" + dRow["responsable"]  + "', ";
                    strSql += "correo = '" + dRow["correo"]  + "', ";
                    strSql += "estatus = " + dRow["estatus"] + " ";
                    strSql += "WHERE ";
                    strSql += "id_sucursal = " + dRow["id_sucursal"] + "";

                    cmdObj.CommandText = strSql;

                    try
                    {

                        cmdObj.ExecuteNonQuery();
                        Valor = true;

                    }
                    catch (MySqlException ex)
                    {

                        MessageBox.Show("Error al Ingresar los Datos, " + ex.Message, "Error Critico", MessageBoxButton.OK);
                        Valor = false;

                    }

                }

            }
            else
            {
                Valor = false;
            }

            return Valor;

        }

    }

}
