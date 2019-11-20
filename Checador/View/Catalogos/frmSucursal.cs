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

namespace Checador.View
{
    public partial class frmSucursal : Form
    {

        private int idSuc;

        #region "Constructor"

        public frmSucursal(int _idSuc)
        {

            InitializeComponent();
            idSuc = _idSuc;
            CargaPaises();

        }

        public frmSucursal()
        {

            InitializeComponent();
            idSuc = 0;
            CargaPaises();

        }

        #endregion

        #region "Formulario"

        private void frmSucursal_Load(object sender, EventArgs e)
        {

            if (idSuc > 0)
            {

                CargaSucursal();

            }
            else
            {

                chbEstatus.CheckState = CheckState.Checked;

            }

        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {


            CargaEstados(Convert.ToString(cmbPais.SelectedValue));

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaCiudades(Convert.ToString(cmbEstado.SelectedValue));

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if (idSuc > 0)
            {

                Editar();

            }
            else
            {

                Nuevo();

            }

        }

        #endregion

        #region "Funciones"

        private void CargaSucursal()
        {

            Sucursal_Ctl objSucursal = new Sucursal_Ctl();
            BindingSource dbSucursal = new BindingSource();

            dbSucursal.DataSource = objSucursal.sucursalSeleccionada(idSuc);

            txtSucursal.DataBindings.Add("Text", dbSucursal, "sucursal", true);
            txtCalle.DataBindings.Add("Text", dbSucursal, "calle", true);
            txtNumExt.DataBindings.Add("Text", dbSucursal, "num_ext", true);
            txtNumInt.DataBindings.Add("Text", dbSucursal, "num_int", true);
            txtColonia.DataBindings.Add("Text", dbSucursal, "colonia", true);
            txtCodPostal.DataBindings.Add("Text", dbSucursal, "codigo_pos", true);
            cmbPais.DataBindings.Add("SelectedValue", dbSucursal, "pais");
            cmbEstado.DataBindings.Add("SelectedValue", dbSucursal, "estado");
            cmbCiudad.DataBindings.Add("SelectedValue", dbSucursal, "ciudad");
            txtResponsable.DataBindings.Add("Text", dbSucursal, "responsable", true);
            txtTelefono.DataBindings.Add("Text", dbSucursal, "telefono", true);
            txtExtencion.DataBindings.Add("Text", dbSucursal, "extencion", true);
            txtCorreo.DataBindings.Add("Text", dbSucursal, "correo", true);
            chbEstatus.DataBindings.Add("Checked", dbSucursal, "estatus");

        }

        private void CargaPaises()
        {

            BindingSource dbPais = new BindingSource();
            Pais_Ctl objPais = new Pais_Ctl();
            dbPais.DataSource = objPais.listaPaises();

            cmbPais.ValueMember = "id_pais";
            cmbPais.DisplayMember = "pais";
            cmbPais.DataSource = dbPais;

        }

        private void CargaEstados(string idPais)
        {

            BindingSource dbEstado = new BindingSource();
            Estado_Ctl objEstado = new Estado_Ctl();
            dbEstado.DataSource = objEstado.listaEstados(idPais);

            cmbEstado.DisplayMember = "estado";
            cmbEstado.ValueMember = "id_estado";
            cmbEstado.DataSource = dbEstado;

        }

        private void CargaCiudades(string idEstado)
        {

            BindingSource dbCiudad = new BindingSource();
            Ciudad_Ctl objCiudad = new Ciudad_Ctl();
            dbCiudad.DataSource = objCiudad.listaCiudades(idEstado);

            cmbCiudad.DisplayMember = "ciudad";
            cmbCiudad.ValueMember = "id_ciudad";
            cmbCiudad.DataSource = dbCiudad;

        }

        private void Nuevo()
        {

            DataTable dtSucursal = new DataTable();

            dtSucursal.Columns.Add("id_sucursal");
            dtSucursal.Columns.Add("id_empresa");
            dtSucursal.Columns.Add("sucursal");
            dtSucursal.Columns.Add("calle");
            dtSucursal.Columns.Add("num_ext");
            dtSucursal.Columns.Add("num_int");
            dtSucursal.Columns.Add("colonia");
            dtSucursal.Columns.Add("pais");
            dtSucursal.Columns.Add("estado");
            dtSucursal.Columns.Add("ciudad");
            dtSucursal.Columns.Add("codigo_pos");
            dtSucursal.Columns.Add("responsable");
            dtSucursal.Columns.Add("telefono");
            dtSucursal.Columns.Add("extencion");
            dtSucursal.Columns.Add("correo");
            dtSucursal.Columns.Add("estatus");

            DataRow Renglon = dtSucursal.NewRow();

            Renglon["id_sucursal"] = VariablesGlobales_Ctl.getIdSucursal();
            Renglon["id_empresa"] = 1;
            Renglon["sucursal"] = txtSucursal.Text;
            Renglon["calle"] = txtCalle.Text;
            Renglon["num_ext"] = txtNumExt.Text;
            Renglon["num_int"] = txtNumInt.Text;
            Renglon["colonia"] = txtColonia.Text;
            Renglon["pais"] = cmbPais.SelectedValue;
            Renglon["estado"] = cmbEstado.SelectedValue;
            Renglon["ciudad"] = cmbCiudad.SelectedValue;
            Renglon["codigo_pos"] = txtCodPostal.Text;
            Renglon["responsable"] = txtResponsable.Text;
            Renglon["telefono"] = txtTelefono.Text;
            Renglon["extencion"] = txtExtencion.Text;
            Renglon["correo"] = txtCorreo.Text;

            if (chbEstatus.CheckState == CheckState.Checked)
            {
                Renglon["estatus"] = 1;
            }
            else
            {
                Renglon["estatus"] = 0;
            }

            dtSucursal.Rows.Add(Renglon);

            Sucursal_Ctl objSucursalNuevo = new Sucursal_Ctl();
            if (objSucursalNuevo.AgregaSucursal(dtSucursal) == true)
            {

                MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {

                MessageBox.Show("Error al Guardar los Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Editar()
        {


            DataTable dtSucursal = new DataTable();

            dtSucursal.Columns.Add("id_sucursal");
            dtSucursal.Columns.Add("id_empresa");
            dtSucursal.Columns.Add("sucursal");
            dtSucursal.Columns.Add("calle");
            dtSucursal.Columns.Add("num_ext");
            dtSucursal.Columns.Add("num_int");
            dtSucursal.Columns.Add("colonia");
            dtSucursal.Columns.Add("pais");
            dtSucursal.Columns.Add("estado");
            dtSucursal.Columns.Add("ciudad");
            dtSucursal.Columns.Add("codigo_pos");
            dtSucursal.Columns.Add("responsable");
            dtSucursal.Columns.Add("telefono");
            dtSucursal.Columns.Add("extencion");
            dtSucursal.Columns.Add("correo");
            dtSucursal.Columns.Add("estatus");

            DataRow Renglon = dtSucursal.NewRow();

            Renglon["id_sucursal"] = VariablesGlobales_Ctl.getIdSucursal();
            Renglon["id_empresa"] = 1;
            Renglon["sucursal"] = txtSucursal.Text;
            Renglon["calle"] = txtCalle.Text;
            Renglon["num_ext"] = txtNumExt.Text;
            Renglon["num_int"] = txtNumInt.Text;
            Renglon["colonia"] = txtColonia.Text;
            Renglon["pais"] = cmbPais.SelectedValue;
            Renglon["estado"] = cmbEstado.SelectedValue;
            Renglon["ciudad"] = cmbCiudad.SelectedValue;
            Renglon["codigo_pos"] = txtCodPostal.Text;
            Renglon["responsable"] = txtResponsable.Text;
            Renglon["telefono"] = txtTelefono.Text;
            Renglon["extencion"] = txtExtencion.Text;
            Renglon["correo"] = txtCorreo.Text;

            if (chbEstatus.CheckState == CheckState.Checked)
            {
                Renglon["estatus"] = 1;
            }
            else
            {
                Renglon["estatus"] = 0;
            }

            dtSucursal.Rows.Add(Renglon);

            Sucursal_Ctl objSucursalNuevo = new Sucursal_Ctl();
            if (objSucursalNuevo.EditaSucursal(dtSucursal) == true)
            {

                MessageBox.Show("Datos Guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {

                MessageBox.Show("Error al Guardar los Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

    }

}
