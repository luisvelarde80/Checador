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
    public partial class frmCiudad : Form
    {

        private int idCiudad;
        private int idEstado;

        #region "Constructor"

        public frmCiudad(int _idEstado)
        {

            InitializeComponent();
            idEstado = _idEstado;
            idCiudad = 0;

        }

        public frmCiudad(int _idEstado, int _idCiudad)
        {

            InitializeComponent();
            idEstado = _idEstado;
            idCiudad = _idCiudad;

        }

        #endregion

        #region "Formulario"

        private void frmCiudad_Load(object sender, EventArgs e)
        {

            if (idCiudad > 0)
            {

                CargaCiudad();

            }

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if (idCiudad > 0)
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

        private void CargaCiudad()
        {

            Ciudad_Ctl objCiudad = new Ciudad_Ctl();
            BindingSource dbCiudad = new BindingSource();

            dbCiudad.DataSource = objCiudad.CiudadSeleccionada(idEstado, idCiudad);

            txtCiudad.DataBindings.Add("Text", dbCiudad, "ciudad", true);

        }

        private void Nuevo()
        {

            if (txtCiudad.Text != "")
            {

                DataTable dtCiudad = new DataTable();
                dtCiudad.Columns.Add("id_ciudad");
                dtCiudad.Columns.Add("id_estado");
                dtCiudad.Columns.Add("ciudad");

                DataRow dRow = dtCiudad.NewRow();

                dRow["id_ciudad"] = idCiudad;
                dRow["id_estado"] = idEstado;
                dRow["ciudad"] = txtCiudad.Text;

                dtCiudad.Rows.Add(dRow);

                Ciudad_Ctl objCiudad = new Ciudad_Ctl();

                if (objCiudad.NuevaCiudad(dtCiudad) == true)
                {

                    this.Close();
                    return;

                }

            }

        }

        private void Edita()
        {

            if (txtCiudad.Text != "")
            {

                DataTable dtCiudad = new DataTable();
                dtCiudad.Columns.Add("id_ciudad");
                dtCiudad.Columns.Add("id_estado");
                dtCiudad.Columns.Add("ciudad");

                DataRow dRow = dtCiudad.NewRow();

                dRow["id_ciudad"] = idCiudad;
                dRow["id_estado"] = idEstado;
                dRow["ciudad"] = txtCiudad.Text;

                dtCiudad.Rows.Add(dRow);

                Ciudad_Ctl objCiudad = new Ciudad_Ctl();

                if (objCiudad.EditaCiudad(dtCiudad) == true)
                {

                    this.Close();
                    return;

                }

            }

        }

        #endregion

    }

}
