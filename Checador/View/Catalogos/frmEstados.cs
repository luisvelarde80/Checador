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

namespace Checador.View.Catalogos
{
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        #region "Formulario"

        private void frmEstados_Load(object sender, EventArgs e)
        {

            CargaPaises();

        }

        private void tscbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

            CargaEstados();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if (fgEstados.Row > 0)
            {

                frmEstado frmestado = new frmEstado(Convert.ToInt32(tscbPaises.ComboBox.SelectedValue), Convert.ToInt32(fgEstados.GetData(fgEstados.Row, 0)));
                frmestado.ShowDialog();

                CargaPaises();

            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmEstado frmestado = new frmEstado(Convert.ToInt32(tscbPaises.ComboBox.SelectedValue));
            frmestado.ShowDialog();

            CargaPaises();

        }

        #endregion

        #region "Funciones"

        private void CargaPaises()
        {

            Pais_Ctl objPaises = new Pais_Ctl();
            BindingSource dbPaises = new BindingSource();
            dbPaises.DataSource = objPaises.ListaPaises();

            tscbPaises.ComboBox.ValueMember = "id_pais";
            tscbPaises.ComboBox.DisplayMember = "pais";
            tscbPaises.ComboBox.DataSource = dbPaises;

            CargaEstados();

        }

        private void CargaEstados()
        {

            Configura();

            Estado_Ctl objEstados = new Estado_Ctl();
            List<Estado_Mdl> ListaEstados = new List<Estado_Mdl>();

            ListaEstados = objEstados.listaEstados(Convert.ToInt32(tscbPaises.ComboBox.SelectedValue));

            foreach (var estado in ListaEstados)
            {

                fgEstados.AddItem("");

                fgEstados.SetData(fgEstados.Rows.Count - 1, 0, estado.id_estado);
                fgEstados.SetData(fgEstados.Rows.Count - 1, 1, estado.estado);

            }

            fgEstados.AutoSizeCols();

        }

        private void Configura()
        {

            fgEstados.Cols.Count = 2;
            fgEstados.Rows.Count = 1;

            fgEstados.Cols[0].Caption = "Id";
            fgEstados.Cols[0].Visible = false;
            fgEstados.Cols[1].Caption = "Estado";

            fgEstados.AutoSizeCols();

        }

        #endregion

    }

}
