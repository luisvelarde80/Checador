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
    public partial class frmPais : Form
    {

        private int idPais;

        #region "Constructores"

        public frmPais()
        {
            InitializeComponent();
            idPais = 0;
        }

        public frmPais(int _idPais)
        {
            InitializeComponent();
            idPais = _idPais;
        }

        #endregion

        private void frmPais_Load(object sender, EventArgs e)
        {

            if(idPais > 0)
            {

                CargaPais();

            }

        }

        private void CargaPais()
        {

            Pais_Ctl objPais = new Pais_Ctl();
            BindingSource dbPais = new BindingSource
            {
                DataSource = objPais.PaisSeleccionado(idPais)
            };
            txtPais.DataBindings.Add("Text", dbPais, "pais", true);

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if(idPais > 0)
            {
                Editar();
            }
            else
            {
                Nuevo();
            }

        }

        private void Editar()
        {

            using (DataTable dtPais = new DataTable())
            {
                dtPais.Columns.Add("id_pais");
                dtPais.Columns.Add("pais");

                DataRow dRow = dtPais.NewRow();

                dRow["id_pais"] = idPais;
                dRow["pais"] = txtPais.Text;

                dtPais.Rows.Add(dRow);

                Pais_Ctl objPais = new Pais_Ctl();

                if (objPais.EditarPais(dtPais) == true)
                {

                    this.Close();
                    return;

                }
            }

        }

        private void Nuevo()
        {

            using (DataTable dtPais = new DataTable())
            {
                dtPais.Columns.Add("id_pais");
                dtPais.Columns.Add("pais");

                DataRow dRow = dtPais.NewRow();

                dRow["id_pais"] = idPais;
                dRow["pais"] = txtPais.Text;

                dtPais.Rows.Add(dRow);

                Pais_Ctl objPais = new Pais_Ctl();

                if (objPais.NuevoPais(dtPais) == true)
                {

                    this.Close();

                }

            }

        }

    }

}
