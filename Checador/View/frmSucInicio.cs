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

namespace Checador.View
{
    public partial class frmSucInicio : Form
    {

        Sucursal_Ctl objSucursal = new Sucursal_Ctl();

        public frmSucInicio()
        {
            
            InitializeComponent();
          

        }

        private void frmSucInicio_Load(object sender, EventArgs e)
        {

            CargaSucursales();

        }

        private void CargaSucursales()
        {

            BindingSource dbSucursales = new BindingSource();
            dbSucursales.DataSource = objSucursal.listaSucursal();

            cmbSucursal.DisplayMember = "sucursal";
            cmbSucursal.ValueMember = "id_sucursal";
            cmbSucursal.DataSource = dbSucursales.DataSource;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            VariablesGlobales_Ctl.setIdSucursal(Convert.ToInt32(cmbSucursal.SelectedValue));
            this.DialogResult = DialogResult.OK;
            this.Close();
            return;

        }

    }

}
