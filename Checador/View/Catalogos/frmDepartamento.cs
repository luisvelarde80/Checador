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
    public partial class frmDepartamento : Form
    {

        private int idDepto = 0;
        Departamento_Ctl objDepto = new Departamento_Ctl();

        #region "Formulario"

        private void frmDepartamento_Load(object sender, EventArgs e)
        {

            if (idDepto > 0)
            {

                CargaDepto();

            }

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if (txtDepto.Text != "")
            {

                if (idDepto > 0)
                {

                    Edita();

                }
                else
                {

                    Nuevo();

                }

            }

        }

        #endregion

        #region "Constructores"

        public frmDepartamento()
        {

            InitializeComponent();

        }

        public frmDepartamento(int _idDepto)
        {

            InitializeComponent();
            idDepto = _idDepto;

        }

        #endregion

        #region "Funciones"

        private void CargaDepto()
        {

            BindingSource dbDepto = new BindingSource();
            dbDepto.DataSource = objDepto.DeptoSeleccionado(VariablesGlobales_Ctl.getIdSucursal(), idDepto);

            txtDepto.DataBindings.Add("Text", dbDepto, "departamento");

        }

        private void Nuevo()
        {

            if (objDepto.NuevoDepartamento(VariablesGlobales_Ctl.getIdSucursal(), txtDepto.Text) == 1)
            {

                this.Close();
                return;

            }


        }

        private void Edita()
        {

            if (objDepto.EditaDepartamento(idDepto, txtDepto.Text) == 1)
            {

                this.Close();
                return;

            }

        }

        #endregion

    }

}
