using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Checador.Model.Clases
{
    public class Conexion_Cls
    {

        //Conexion local para pruebas
        private string strCon = "Server=LocalHost;DataBase=maranatha;User Id=sistemas;Password=s1st3m@s2017";

        //Conexion Real
        //private string strCon = "Server=192.168.2.248;DataBase=checador;User Id=sistemas;Password=s1st3m@s2017";

        public MySqlConnection Conectar()
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = strCon;

            try
            {
                cn.Open();
                return cn;
            }catch(MySqlException ex)
            {
                MessageBox.Show("Error al Conectar a la Base de Datos, " + ex.Message,"Error Critico",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }

        }

    }

}
