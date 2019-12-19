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
            CargaBancos();
            CargaJornadas();
            CargaSucursales();
            CargaDepto();
            CargaPuestos();
            CargarMetodoPago();
            CargarContratos();
            CargarTipoSalario();

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

        private void CargaBancos()
        {

            BindingSource dbBancos = new BindingSource();
            Banco_Ctl objBanco = new Banco_Ctl();

            dbBancos.DataSource = objBanco.ListaBancos();

            cmbBanco.DataSource = dbBancos;
            cmbBanco.ValueMember = "id_banco";
            cmbBanco.DisplayMember = "banco";

        }

        private void CargaJornadas()
        {

            BindingSource dbJornadas = new BindingSource();
            Jornada_Ctl objJornada = new Jornada_Ctl();

            dbJornadas.DataSource = objJornada.ListaJornada();

            cmbJornada.DataSource = dbJornadas;
            cmbJornada.ValueMember = "id_jornada";
            cmbJornada.DisplayMember = "jornada";

        }

        private void CargaSucursales()
        {

            BindingSource dbSucursal = new BindingSource();
            Sucursal_Ctl objSucursal = new Sucursal_Ctl();

            dbSucursal.DataSource = objSucursal.listaSucursal();

            cmbSucursal.DataSource = dbSucursal;
            cmbSucursal.ValueMember = "id_sucursal";
            cmbSucursal.DisplayMember = "sucursal";

        }

        private void CargaDepto()
        {

            BindingSource dbDepto = new BindingSource();
            Departamento_Ctl objDepto = new Departamento_Ctl();

            dbDepto.DataSource = objDepto.ListaDepartamentos(Convert.ToInt32(cmbSucursal.SelectedValue));

            cmbDepto.DataSource = dbDepto;
            cmbDepto.ValueMember = "id_departamento";
            cmbDepto.DisplayMember = "departamento";

        }

        private void CargaPuestos()
        {

            BindingSource dbPuesto = new BindingSource();
            Puesto_Ctl objPuesto = new Puesto_Ctl();

            dbPuesto.DataSource = objPuesto.ListarPuestos();

            cmbPuesto.DataSource = dbPuesto;
            cmbPuesto.ValueMember = "id_puesto";
            cmbPuesto.DisplayMember = "puesto";

        }

        private void CargarMetodoPago()
        {

            BindingSource dbMetodoPago = new BindingSource();
            Metodo_Pago_Ctl objMetodoPago = new Metodo_Pago_Ctl();

            dbMetodoPago.DataSource = objMetodoPago.ListarMetodoPago();

            cmbMetPago.DataSource = dbMetodoPago;
            cmbMetPago.ValueMember = "id_metodo_pago";
            cmbMetPago.DisplayMember = "metodo_pago";

        }

        private void CargarContratos()
        {

            BindingSource dbContrato = new BindingSource();
            Contrato_Ctl objContrato = new Contrato_Ctl();

            dbContrato.DataSource = objContrato.ListarContrato();

            cmbContrato.DataSource = dbContrato;
            cmbContrato.ValueMember = "id_contrato";
            cmbContrato.DisplayMember = "contrato";

        }

        private void CargarTipoSalario()
        {

            BindingSource dbTipoSalario = new BindingSource();
            Tipo_Salario_Ctl objTipoSalario = new Tipo_Salario_Ctl();

            dbTipoSalario.DataSource = objTipoSalario.ListarTipoSalario();

            cmbTipoSalario.DataSource = dbTipoSalario;
            cmbTipoSalario.ValueMember = "id_tipo_salario";
            cmbTipoSalario.DisplayMember = "tipo_salario";
        
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
