using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador.Controller;
using Checador.Model;

namespace Checador.View.Catalogos
{
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
        }

        private void frmSucursales_Load(object sender, EventArgs e)
        {

            CargaSucursales();
            
        }

        private void Configura()
        {

            fgSucursales.Cols.Count = 6;
            fgSucursales.Rows.Count = 1;

            fgSucursales.Cols[0].Caption = "Id";
            fgSucursales.Cols[0].Visible = false;
            fgSucursales.Cols[1].Caption = "Sucursal";
            fgSucursales.Cols[2].Caption = "Contacto";
            fgSucursales.Cols[3].Caption = "Telefono";
            fgSucursales.Cols[4].Caption = "Email";
            fgSucursales.Cols[5].Caption = "Estatus";

            fgSucursales.AutoSizeCols();

        }

        private void CargaSucursales()
        {

            List<Sucursal_Mdl> listasucursales = new List<Sucursal_Mdl>();
            Sucursal_Ctl objSucursales = new Sucursal_Ctl();

            listasucursales = objSucursales.listaSucursal();

            Configura();

            foreach (var sucursal in listasucursales)
            {

                fgSucursales.AddItem("");

                fgSucursales.SetData(fgSucursales.Rows.Count - 1, 0, sucursal.id_sucursal);
                fgSucursales.SetData(fgSucursales.Rows.Count - 1, 1, sucursal.sucursal);
                fgSucursales.SetData(fgSucursales.Rows.Count - 1, 2, sucursal.responsable);
                fgSucursales.SetData(fgSucursales.Rows.Count - 1, 3, sucursal.telefono);
                fgSucursales.SetData(fgSucursales.Rows.Count - 1, 4, sucursal.correo);

                if (sucursal.estatus == 1)
                {
                    fgSucursales.SetData(fgSucursales.Rows.Count - 1, 5, "Activo");
                }
                else
                {
                    fgSucursales.SetData(fgSucursales.Rows.Count - 1, 5, "Inactivo");
                }

            }

            fgSucursales.AutoSizeCols();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if(fgSucursales.Row > 0)
            {

                frmSucursal frmsucursal = new frmSucursal(Convert.ToInt32(fgSucursales.GetData(fgSucursales.Row,0)));
                frmsucursal.ShowDialog();

                CargaSucursales();

            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmSucursal frmsucursal = new frmSucursal();
            frmsucursal.ShowDialog();

            CargaSucursales();

        }

    }

}
