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
    public class Empleado_Cls
    {

        Conexion_Cls objConexion = new Conexion_Cls();

        public List<Empleado_Mdl> ListaEmpleados(int _estatus)
        {

            List<Empleado_Mdl> listaempleado = new List<Empleado_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if(cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_empleado, ";
                strSql += "clave, ";
                strSql += "a_paterno, ";
                strSql += "a_materno, ";
                strSql += "nombre, ";
                strSql += "rfc, ";
                strSql += "curp, ";
                strSql += "nss, ";
                strSql += "fecha_nac, ";
                strSql += "alta, ";
                strSql += "baja, ";
                strSql += "estatus ";
                strSql += "FROM ";
                strSql += "empleado ";
                strSql += "WHERE ";
                strSql += "estatus = " + _estatus + "";

                cmdObj.CommandText = strSql;

                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Empleado_Mdl objEmpleado = new Empleado_Mdl();

                    objEmpleado.id_empleado = Convert.ToInt32(rdrObj[0].ToString());
                    objEmpleado.clave = rdrObj[1].ToString();
                    objEmpleado.a_paterno = rdrObj[2].ToString();
                    objEmpleado.a_materno = rdrObj[3].ToString();
                    objEmpleado.nombre = rdrObj[4].ToString();
                    objEmpleado.rfc = rdrObj[5].ToString();
                    objEmpleado.curp = rdrObj[6].ToString();
                    objEmpleado.nss = rdrObj[7].ToString();
                    objEmpleado.fecha_nac = Convert.ToDateTime(rdrObj[8]).ToString("yyyyMMdd");
                    objEmpleado.alta = Convert.ToDateTime(rdrObj[9]).ToString("yyyyMMdd");
                    objEmpleado.baja = Convert.ToDateTime(rdrObj[10]).ToString("yyyyMMdd");
                    objEmpleado.estatus = Convert.ToInt32(rdrObj[11].ToString());

                    listaempleado.Add(objEmpleado);

                }

                rdrObj.Close();
            
            }

            cnObj.Close();
            return listaempleado;

        }

        public List<Empleado_Mdl> EmpleadoSeleccionado(int idEmpleado)
        {

            List<Empleado_Mdl> listaempleado = new List<Empleado_Mdl>();

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();

            if (cnObj != null)
            {

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "id_empleado, ";
                strSql += "clave, ";
                strSql += "a_paterno, ";
                strSql += "a_materno, ";
                strSql += "nombre, ";
                strSql += "rfc, ";
                strSql += "curp, ";
                strSql += "nss, ";
                strSql += "fecha_nac, ";
                strSql += "alta, ";
                strSql += "baja, ";
                strSql += "estatus ";
                strSql += "FROM ";
                strSql += "empleado ";
                strSql += "WHERE ";
                strSql += "id_empleado = " + idEmpleado + "";

                cmdObj.CommandText = strSql;

                MySqlDataReader rdrObj = cmdObj.ExecuteReader();

                while (rdrObj.Read())
                {

                    Empleado_Mdl objEmpleado = new Empleado_Mdl();

                    objEmpleado.id_empleado = Convert.ToInt32(rdrObj[0].ToString());
                    objEmpleado.clave = rdrObj[1].ToString();
                    objEmpleado.a_paterno = rdrObj[2].ToString();
                    objEmpleado.a_materno = rdrObj[3].ToString();
                    objEmpleado.nombre = rdrObj[4].ToString();
                    objEmpleado.rfc = rdrObj[5].ToString();
                    objEmpleado.curp = rdrObj[6].ToString();
                    objEmpleado.nss = rdrObj[7].ToString();
                    objEmpleado.fecha_nac = Convert.ToDateTime(rdrObj[8]).ToString("yyyyMMdd");
                    objEmpleado.alta = Convert.ToDateTime(rdrObj[9]).ToString("yyyyMMdd");
                    objEmpleado.baja = Convert.ToDateTime(rdrObj[10]).ToString("yyyyMMdd");
                    objEmpleado.estatus = Convert.ToInt32(rdrObj[11].ToString());

                    listaempleado.Add(objEmpleado);

                }

                rdrObj.Close();

            }

            cnObj.Close();
            return listaempleado;

        }

        public Boolean NuevoEmpleado(DataTable dtEmpleado, DataTable dtDireccion, DataTable dtRh)
        {

            Boolean Valor = false;
            int idEmpleado = 0;

            MySqlConnection cnObj = new MySqlConnection();
            cnObj = objConexion.Conectar();
            if(cnObj != null)
            {

                MySqlTransaction Trans = cnObj.BeginTransaction();

                MySqlCommand cmdObj = new MySqlCommand();
                cmdObj.Connection = cnObj;

                string strSql;

                strSql = "SELECT ";
                strSql += "MAX(id_empleado + 1) ";
                strSql += "FROM ";
                strSql += "empleado";

                cmdObj.CommandText = strSql;
                MySqlDataReader rdrObj = cmdObj.ExecuteReader();
                while (rdrObj.Read())
                {
                    idEmpleado = Convert.ToInt32(rdrObj[0].ToString());
                }
                rdrObj.Close();

               foreach(DataRow dRowEmpleado in dtEmpleado.Rows)
                {

                    strSql = "INSERT ";
                    strSql += "INTO ";
                    strSql += "empleado ";
                    strSql += "(clave, ";
                    strSql += "a_paterno, ";
                    strSql += "a_materno, ";
                    strSql += "nombre, ";
                    strSql += "rfc, ";
                    strSql += "curp, ";
                    strSql += "nss, ";
                    strSql += "fecha_nac, ";
                    strSql += "alta, ";
                    strSql += "baja, ";
                    strSql += "estatus) ";
                    strSql += "VALUES ";
                    strSql += "('"+ dRowEmpleado["clave"] +"', ";
                    strSql += "'" + dRowEmpleado["a_paterno"] + "', ";
                    strSql += "'" + dRowEmpleado["a_materno"] + "', ";
                    strSql += "'" + dRowEmpleado["nombre"] + "', ";
                    strSql += "'" + dRowEmpleado["rfc"] + "', ";
                    strSql += "'" + dRowEmpleado["curp"] + "', ";
                    strSql += "'" + dRowEmpleado["nss"] + "', ";
                    strSql += "'" + dRowEmpleado["fecha_nac"] + "', ";
                    strSql += "'" + dRowEmpleado["alta"] + "', ";
                    strSql += "'" + dRowEmpleado["baja"] + "', ";
                    strSql += "" + dRowEmpleado["estatus"] + ")";

                    cmdObj.CommandText = strSql;

                    try
                    {
                        cmdObj.ExecuteNonQuery();
                    }catch(MySqlException ex)
                    {

                        MessageBox.Show("Error al Ingresar los Datos, " + ex.Message,"Error Critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        Trans.Rollback();

                    }

                    foreach(DataRow dRowDireccion in dtDireccion.Rows)
                    {

                        strSql = "INSERT ";
                        strSql += "INTO ";
                        strSql += "direccion ";
                        strSql += "(id_empleado, ";
                        strSql += "calle, ";
                        strSql += "num_ext, ";
                        strSql += "num_int, ";
                        strSql += "colonia, ";
                        strSql += "cod_postal, ";
                        strSql += "id_pais, ";
                        strSql += "id_estado, ";
                        strSql += "id_ciudad, ";
                        strSql += "telefono, ";
                        strSql += "correo, ";
                        strSql += "celular, ";
                        strSql += "contacto) ";
                        strSql += "VALUES ";
                        strSql += "("+ idEmpleado +", ";
                        strSql += "'"+ dRowDireccion["calle"] +"', ";
                        strSql += "'" + dRowDireccion["num_ext"] + "', ";
                        strSql += "'" + dRowDireccion["num_int"] + "', ";
                        strSql += "'" + dRowDireccion["colonia"] + "', ";
                        strSql += "'" + dRowDireccion["cod_postal"] + "', ";
                        strSql += "" + dRowDireccion["id_pais"] + ", ";
                        strSql += "" + dRowDireccion["id_estado"] + ", ";
                        strSql += "" + dRowDireccion["id_ciudad"] + ", ";
                        strSql += "'" + dRowDireccion["telefono"] + "', ";
                        strSql += "'" + dRowDireccion["correo"] + "', ";
                        strSql += "'" + dRowDireccion["celular"] + "', ";
                        strSql += "'" + dRowDireccion["contacto"] + "')";

                        cmdObj.CommandText = strSql;

                        try
                        {
                            cmdObj.ExecuteNonQuery();
                        }catch(MySqlException ex)
                        {
                            MessageBox.Show("Error al Ingresar los Datos, " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Trans.Rollback();
                        }

                        foreach(DataRow dRowRh in dtRh.Rows)
                        {

                            strSql = "INSERT ";
                            strSql += "INTO ";
                            strSql += "datos_rh ";
                            strSql += "(id_empleado, ";
                            strSql += "id_banco, ";
                            strSql += "cuenta_banco, ";
                            strSql += "id_jornada, ";
                            strSql += "id_sucursal, ";
                            strSql += "id_departamento, ";
                            strSql += "id_puesto, ";
                            strSql += "salario_diario, ";
                            strSql += "id_metodo_pago, ";
                            strSql += "id_contrato, ";
                            strSql += "id_tipo_salario) ";
                            strSql += "VALUES ";
                            strSql += "("+ idEmpleado +", ";
                            strSql += ""+ dRowRh["id_banco"] +", ";
                            strSql += "'"+ dRowRh["cuenta_banco"] +"', ";
                            strSql += "" + dRowRh["id_jornada"] + ", ";
                            strSql += "" + dRowRh["id_sucursal"] + ", ";
                            strSql += "" + dRowRh["id_departamento"] + ", ";
                            strSql += "" + dRowRh["id_puesto"] + ", ";
                            strSql += "'"+ dRowRh["salario_diario"] +"', ";
                            strSql += "" + dRowRh["id_metodo_pago"] + ", ";
                            strSql += "" + dRowRh["id_contrato"] + ", ";
                            strSql += "" + dRowRh["id_tipo_salario"] + ")";

                            cmdObj.CommandText = strSql;

                            try
                            {
                                cmdObj.ExecuteNonQuery();
                            }catch(MySqlException ex)
                            {
                                MessageBox.Show("Error al Ingresar los Datos, " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Trans.Rollback();
                            }

                        }

                    }

                    Trans.Commit();

                }

            }

            cnObj.Close();
            return Valor;

        }

    }

}
