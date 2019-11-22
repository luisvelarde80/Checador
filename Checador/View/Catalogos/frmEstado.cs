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
    public partial class frmEstado : Form
    {

        private int idPais;
        private int idEstado;

        #region "Constructor"

        public frmEstado(int _idPais)
        {
            InitializeComponent();
            idPais = _idPais;
            idEstado = 0;

        }

        public frmEstado(int _idPais, int _idEstado)
        {
            InitializeComponent();
            idEstado = _idEstado;
            idPais = _idPais;
        }

        #endregion

        #region "Formulario"

        private void frmEstado_Load(object sender, EventArgs e)
        {

            if (idEstado > 0)
            {

                CargaEstado();

            }

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if (idEstado > 0)
            {
                Edita();
            }
            else
            {
                Nuevo();
            }

        }

        #endregion

        #region "Funciones"

        private void CargaEstado()
        {

            Estado_Ctl objEstado = new Estado_Ctl();
            BindingSource dbEstado = new BindingSource();

            dbEstado.DataSource = objEstado.EstadoSeleccionado(idPais, idEstado);

            txtEstado.DataBindings.Add("Text", dbEstado, "estado", true);

        }

        private void Nuevo()
        {

            DataTable dtEstado = new DataTable();
            dtEstado.Columns.Add("id_estado");
            dtEstado.Columns.Add("id_pais");
            dtEstado.Columns.Add("estado");

            DataRow dRow = dtEstado.NewRow();

            dRow["id_estado"] = idEstado;
            dRow["id_pais"] = idPais;
            dRow["estado"] = txtEstado.Text;

            Estado_Ctl objEstado = new Estado_Ctl();

            if (objEstado.NuevoEstado(dtEstado) == true)
            {

                this.Close();
                return;

            }

        }

        private void Edita()
        {

            DataTable dtEstado = new DataTable();
            dtEstado.Columns.Add("id_estado");
            dtEstado.Columns.Add("id_pais");
            dtEstado.Columns.Add("estado");

            DataRow dRow = dtEstado.NewRow();

            dRow["id_estado"] = idEstado;
            dRow["id_pais"] = idPais;
            dRow["estado"] = txtEstado.Text;

            Estado_Ctl objEstado = new Estado_Ctl();

            if (objEstado.EditaEstado(dtEstado) == true)
            {

                this.Close();
                return;

            }

        }

        #endregion

    }

}
