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

namespace Checador.View.Catalogos
{
    public partial class frmEmpleado : Form
    {

        private int idEmp;

        #region "Constructor"

        public frmEmpleado()
        {

            InitializeComponent();
            idEmp = 0;

        }

        public frmEmpleado(int _idEmp)
        {

            InitializeComponent();
            idEmp = _idEmp;

        }

        #endregion

        #region "Formulario"

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

            CargaCatalogos();

            if(idEmp > 0)
            {

                CargaEmpleado();

            }

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaCiudad();

        }

        #endregion

        #region "Funciones"

        private void CargaCatalogos()
        {

            CargaPais();
            CargaEstado();
            CargaCiudad();
     
        }

        private void CargaEstado()
        {

            BindingSource dbEstado = new BindingSource();
            Estado_Ctl objEstado = new Estado_Ctl();

            dbEstado.DataSource = objEstado.listaEstados(Convert.ToInt32(cmbPais.SelectedValue));

            cmbEstado.DataSource = dbEstado;
            cmbEstado.ValueMember = "id_estado";
            cmbEstado.DisplayMember = "estado";

        }

        private void CargaPais()
        {

            BindingSource dbPais = new BindingSource();
            Pais_Ctl objPais = new Pais_Ctl();

            dbPais.DataSource = objPais.ListaPaises();

            cmbPais.DataSource = dbPais;
            cmbPais.ValueMember = "id_pais";
            cmbPais.DisplayMember = "pais";

        }

        private void CargaCiudad()
        {

            BindingSource dbCiudad = new BindingSource();
            Ciudad_Ctl objCiudad = new Ciudad_Ctl();

            dbCiudad.DataSource = objCiudad.listaCiudades(Convert.ToInt32(cmbEstado.SelectedValue));

            cmbCiudad.DataSource = dbCiudad;
            cmbCiudad.ValueMember = "id_ciudad";
            cmbCiudad.DisplayMember = "ciudad";

        }

        private void CargaEmpleado()
        {

            BindingSource dbEmpleado = new BindingSource();
            Empleado_Ctl objEmpleado = new Empleado_Ctl();

            dbEmpleado.DataSource = objEmpleado.EmpleadoSeleccionado(idEmp);

            txtClave.DataBindings.Add("Text", dbEmpleado, "clave", true);
            txtApaterno.DataBindings.Add("Text", dbEmpleado, "a_paterno", true);
            txtAmaterno.DataBindings.Add("Text", dbEmpleado, "a_materno", true);
            txtNombre.DataBindings.Add("Text", dbEmpleado, "nombre", true);
            txtRfc.DataBindings.Add("Text", dbEmpleado, "rfc", true);       
            txtCurp.DataBindings.Add("Text", dbEmpleado, "curp", true);        
            txtNss.DataBindings.Add("Text", dbEmpleado, "nss", true);       
            dtpFechaNac.DataBindings.Add("Value", dbEmpleado, "fecha_nac");       
            dtpAlta.DataBindings.Add("Value", dbEmpleado, "alta");     
            chbActivo.DataBindings.Add("Checked", dbEmpleado, "estatus");

            BindingSource dbDireccion = new BindingSource();
            Direccion_Ctl objDireccion = new Direccion_Ctl();

            dbDireccion.DataSource = objDireccion.DireccionEmpleado(idEmp);

            txtCalle.DataBindings.Add("Text", dbDireccion, "calle", true);
            txtNumExt.DataBindings.Add("Text", dbDireccion, "num_ext", true);
            txtNumInt.DataBindings.Add("Text", dbDireccion, "num_int", true);
            txtColonia.DataBindings.Add("Text", dbDireccion, "colonia", true);
            txtCodPostal.DataBindings.Add("Text", dbDireccion, "cod_postal", true);
            cmbPais.DataBindings.Add("SelectedValue", dbDireccion, "id_pais");
            cmbEstado.DataBindings.Add("SelectedValue", dbDireccion, "id_estado");
            cmbCiudad.DataBindings.Add("SelectedValue", dbDireccion, "id_ciudad");
            txtTelefono.DataBindings.Add("Text", dbDireccion, "telefono", true);
            txtCorreo.DataBindings.Add("Text", dbDireccion, "correo", true);
            txtCelular.DataBindings.Add("Text", dbDireccion, "celular", true);

    }

        #endregion

    
    }

}
