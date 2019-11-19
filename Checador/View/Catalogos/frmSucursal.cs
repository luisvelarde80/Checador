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

        private int id;
        public frmSucursal(int _id)
        {
           
            InitializeComponent();
            id = _id;
            CargaPaises();

        }

        public frmSucursal()
        {

            InitializeComponent();
            id = 0;
            CargaPaises();

        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {

            if (id > 0)
            {

                Sucursal_Ctl objSucursal = new Sucursal_Ctl();

                List<Sucursal_Mdl> listasucursal = new List<Sucursal_Mdl>();
                listasucursal = objSucursal.sucursalSeleccionada(id);

                foreach (var sucursal in listasucursal)
                {

                    txtSucursal.Text = sucursal.sucursal;
                    txtCalle.Text = sucursal.calle;
                    txtNumExt.Text = sucursal.num_ext;
                    txtNumInt.Text = sucursal.num_int;
                    txtColonia.Text = sucursal.colonia;
                    txtCodPostal.Text = sucursal.codigo_pos;
                    cmbPais.SelectedValue = sucursal.pais;
                    cmbEstado.SelectedValue = sucursal.estado;
                    cmbCiudad.SelectedValue = sucursal.ciudad;
                    txtResponsable.Text = sucursal.responsable ;
                    txtTelefono.Text = sucursal.telefono;
                    txtExtencion.Text = sucursal.extencion;
                    txtCorreo.Text = sucursal.correo ;

                    if (sucursal.estatus == 1)
                    {
                        chbEstatus.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        chbEstatus.CheckState = CheckState.Unchecked;
                    }

                }

            }
            else
            {

                chbEstatus.CheckState = CheckState.Checked;

            }
        
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

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {


            CargaEstados(Convert.ToString(cmbPais.SelectedValue));

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

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaCiudades(Convert.ToString(cmbEstado.SelectedValue));

        }

        private void Nuevo()
        {

            List<Sucursal_Mdl> NuevaSucursal = new List<Sucursal_Mdl>();
            Sucursal_Mdl objSucursal = new Sucursal_Mdl();

            objSucursal.id_empresa = 1;
            objSucursal.sucursal = txtSucursal.Text;
            objSucursal.calle = txtCalle.Text;
            objSucursal.num_ext = txtNumExt.Text;
            objSucursal.num_int = txtNumInt.Text;
            objSucursal.colonia = txtColonia.Text;
            objSucursal.pais = cmbPais.SelectedValue.ToString();
            objSucursal.estado = cmbEstado.SelectedValue.ToString();
            objSucursal.ciudad = Convert.ToInt32(cmbCiudad.SelectedValue.ToString());
            objSucursal.codigo_pos = txtCodPostal.Text;
            objSucursal.responsable = txtResponsable.Text;
            objSucursal.telefono = txtTelefono.Text;
            objSucursal.extencion = txtExtencion.Text;
            objSucursal.correo = txtCorreo.Text;

            if(chbEstatus.CheckState == CheckState.Checked)
            {
                objSucursal.estatus = 1;
            }else
            {
                objSucursal.estatus = 0;
            }

            NuevaSucursal.Add(objSucursal);

            Sucursal_Ctl objSucursalNuevo = new Sucursal_Ctl();
            if (objSucursalNuevo.AgregaSucursal(NuevaSucursal) == true)
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

            List<Sucursal_Mdl> NuevaSucursal = new List<Sucursal_Mdl>();
            Sucursal_Mdl objSucursal = new Sucursal_Mdl();

            objSucursal.id_empresa = 1;
            objSucursal.sucursal = txtSucursal.Text;
            objSucursal.calle = txtCalle.Text;
            objSucursal.num_ext = txtNumExt.Text;
            objSucursal.num_int = txtNumInt.Text;
            objSucursal.colonia = txtColonia.Text;
            objSucursal.pais = cmbPais.SelectedValue.ToString();
            objSucursal.estado = cmbEstado.SelectedValue.ToString();
            objSucursal.ciudad = Convert.ToInt32(cmbCiudad.SelectedValue.ToString());
            objSucursal.codigo_pos = txtCodPostal.Text;
            objSucursal.responsable  = txtResponsable.Text;
            objSucursal.telefono = txtTelefono.Text;
            objSucursal.correo  = txtCorreo.Text;

            if (chbEstatus.CheckState == CheckState.Checked)
            {
                objSucursal.estatus = 1;
            }
            else
            {
                objSucursal.estatus = 0;
            }

            NuevaSucursal.Add(objSucursal);
            Sucursal_Ctl objSucursalNuevo = new Sucursal_Ctl();

            if(objSucursalNuevo.EditaSucursal(NuevaSucursal) == true)
            {

                MessageBox.Show("Datos Actualizados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {

                MessageBox.Show("Error al Actualizar los Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if(id > 0)
            {

                Editar();

            }
            else
            {

                Nuevo();

            }

        }

    }

}
