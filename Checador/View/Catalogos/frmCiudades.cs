using Checador.Controller;
using Checador.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Checador.View.Catalogos
{
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        #region "Formulario"

        private void frmCiudades_Load(object sender, EventArgs e)
        {

            CargaEstados();

        }

        private void tscbEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaCiudad();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (fgCiudades.Row > 0)
            {

                frmCiudad frmciudad = new frmCiudad(Convert.ToInt32(tscbEstados.ComboBox.SelectedValue), Convert.ToInt32(fgCiudades.GetData(fgCiudades.Row, 0)));
                frmciudad.ShowDialog();

                CargaCiudad();

            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmCiudad frmciudad = new frmCiudad(Convert.ToInt32(tscbEstados.ComboBox.SelectedValue));
            frmciudad.ShowDialog();

            CargaCiudad();

        }

        #endregion

        #region "Funciones"

        private void CargaEstados()
        {

            Estado_Ctl objEstado = new Estado_Ctl();
            BindingSource dbEstados = new BindingSource();

            dbEstados.DataSource = objEstado.listaEstados();

            tscbEstados.ComboBox.ValueMember = "id_estado";
            tscbEstados.ComboBox.DisplayMember = "estado";
            tscbEstados.ComboBox.DataSource = dbEstados;

        }

        private void Configura()
        {

            fgCiudades.Cols.Count = 3;
            fgCiudades.Rows.Count = 1;


            fgCiudades.Cols[0].Caption = "IdCiudad";
            fgCiudades.Cols[0].Visible = false;
            fgCiudades.Cols[1].Caption = "IdEstado";
            fgCiudades.Cols[1].Visible = false;
            fgCiudades.Cols[2].Caption = "Ciudad";

            fgCiudades.AutoSizeCols();

        }

        private void CargaCiudad()
        {

            Configura();

            Ciudad_Ctl objCiudad = new Ciudad_Ctl();
            List<Ciudad_Mdl> ListaCiudades = new List<Ciudad_Mdl>();

            ListaCiudades = objCiudad.listaCiudades(Convert.ToInt32(tscbEstados.ComboBox.SelectedValue));

            foreach (var ciudad in ListaCiudades)
            {

                fgCiudades.AddItem("");

                fgCiudades.SetData(fgCiudades.Rows.Count - 1, 0, ciudad.id_ciudad);
                fgCiudades.SetData(fgCiudades.Rows.Count - 1, 1, ciudad.id_estado);
                fgCiudades.SetData(fgCiudades.Rows.Count - 1, 2, ciudad.ciudad);

            }

            fgCiudades.AutoSizeCols();

        }

        #endregion

    }

}
