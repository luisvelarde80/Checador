using System;
using System.Collections.Generic;
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

                    Sucursal_Mdl objSucursal = new Sucursal_Mdl();

                    objSucursal.id_sucursal = Convert.ToInt32(rdrObj[0].ToString());
                    objSucursal.id_empresa = Convert.ToInt32(rdrObj[1].ToString());
                    objSucursal.sucursal = rdrObj[2].ToString();
                    objSucursal.calle = rdrObj[3].ToString();
                    objSucursal.num_ext = rdrObj[4].ToString();
                    objSucursal.num_int = rdrObj[5].ToString();
                    objSucursal.colonia = rdrObj[6].ToString();
                    objSucursal.pais = rdrObj[7].ToString();
                    objSucursal.estado = rdrObj[8].ToString();
                    objSucursal.ciudad = Convert.ToInt32(rdrObj[9].ToString());
                    objSucursal.codigo_pos = rdrObj[10].ToString();
                    objSucursal.telefono = rdrObj[11].ToString();
                    objSucursal.extencion = rdrObj[12].ToString();
                    objSucursal.responsable  = rdrObj[13].ToString();
                    objSucursal.correo  = rdrObj[14].ToString();
                    objSucursal.estatus = Convert.ToInt32(rdrObj[15].ToString());

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

                    Sucursal_Mdl objSucursal = new Sucursal_Mdl();

                    objSucursal.id_sucursal = Convert.ToInt32(rdrObj[0].ToString());
                    objSucursal.id_empresa = Convert.ToInt32(rdrObj[1].ToString());
                    objSucursal.sucursal = rdrObj[2].ToString();
                    objSucursal.calle = rdrObj[3].ToString();
                    objSucursal.num_ext = rdrObj[4].ToString();
                    objSucursal.num_int = rdrObj[5].ToString();
                    objSucursal.colonia = rdrObj[6].ToString();
                    objSucursal.pais = rdrObj[7].ToString();
                    objSucursal.estado = rdrObj[8].ToString();
                    objSucursal.ciudad = Convert.ToInt32(rdrObj[9].ToString());
                    objSucursal.codigo_pos = rdrObj[10].ToString();
                    objSucursal.telefono = rdrObj[11].ToString();
                    objSucursal.extencion = rdrObj[12].ToString();
                    objSucursal.responsable = rdrObj[13].ToString();
                    objSucursal.correo = rdrObj[14].ToString();
                    objSucursal.estatus = Convert.ToInt32(rdrObj[15].ToString());

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
        public Boolean AgregaSucursal(List<Sucursal_Mdl> sucursal)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                foreach(var suc in sucursal)
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
                    strSql += "codigo_pos, ";
                    strSql += "telefono, ";
                    strSql += "extencion, ";
                    strSql += "responsable, ";
                    strSql += "correo, ";
                    strSql += "estatus) ";
                    strSql += "VALUES ";
                    strSql += "(" + suc.id_sucursal + ", ";
                    strSql += "" + suc.id_empresa +", ";
                    strSql += "'" + suc.sucursal + "', ";
                    strSql += "'" + suc.calle + "', ";
                    strSql += "'" + suc.num_ext + "', ";
                    strSql += "'" + suc.num_int + "', ";
                    strSql += "'" + suc.colonia + "', ";
                    strSql += "'" + suc.pais + "', ";
                    strSql += "'" + suc.estado +"', ";
                    strSql += "" + suc.ciudad + ", ";
                    strSql += "'" + suc.codigo_pos + "', ";
                    strSql += "'" + suc.telefono + "', ";
                    strSql += "'" + suc.extencion + "', ";
                    strSql += "'" + suc.responsable  + "', ";
                    strSql += "'" + suc.correo + "', ";
                    strSql += "" + suc.estatus + ") ";

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
        public Boolean EditaSucursal(List<Sucursal_Mdl> sucursal)
        {

            Boolean Valor = false;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;
                string strSql;

                foreach (var suc in sucursal)
                {

                    strSql = "UPDATE ";
                    strSql += "sucursal ";
                    strSql += "SET ";
                    strSql += "id_empresa = " + suc.id_empresa + ", ";
                    strSql += "sucursal = '" + suc.sucursal + "', ";
                    strSql += "calle = '" + suc.calle + "', ";
                    strSql += "num_ext = '" + suc.num_ext + "', ";
                    strSql += "num_int = '" + suc.num_int + "', ";
                    strSql += "colonia = '" + suc.colonia + "', ";
                    strSql += "id_pais = '" + suc.pais + "', ";
                    strSql += "id_estado = '" + suc.estado + "', ";
                    strSql += "id_ciudad = ''" + suc.ciudad + "'', ";
                    strSql += "codigo_pos =  '" + suc.codigo_pos + "', ";
                    strSql += "telefono = '" + suc.telefono + "', ";
                    strSql += "extencion = '"+ suc.extencion +"', ";
                    strSql += "responsable = '" + suc.responsable  + "', ";
                    strSql += "correo = '" + suc.correo  + "', ";
                    strSql += "estatus = " + suc.estatus + " ";
                    strSql += "WHERE ";
                    strSql += "id_sucursal = '" + suc.id_sucursal + "'";

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
