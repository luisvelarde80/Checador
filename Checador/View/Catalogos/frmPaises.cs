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
    public partial class frmPaises : Form
    {
        public frmPaises()
        {
            InitializeComponent();
        }

        private void frmPaises_Load(object sender, EventArgs e)
        {

            CargaPaises();

        }

        private void Configura()
        {

            fgPais.Cols.Count = 2;
            fgPais.Rows.Count = 1;

            fgPais.Cols[0].Caption = "Id";
            fgPais.Cols[0].Visible = false;
            fgPais.Cols[1].Caption = "Pais";

            fgPais.AutoSizeCols();

        }

        private void CargaPaises()
        {

            Configura();

            List<Pais_Mdl> ListaPaises = new List<Pais_Mdl>();
            Pais_Ctl objPaises = new Pais_Ctl();

            ListaPaises = objPaises.ListaPaises();

            foreach(var pais in ListaPaises)
            {

                fgPais.AddItem("");

                fgPais.SetData(fgPais.Rows.Count - 1, 0, pais.id_pais);
                fgPais.SetData(fgPais.Rows.Count - 1, 1, pais.pais);

            }

            fgPais.AutoSizeCols();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if(fgPais.Row > 0)
            {

                frmPais frmpais = new frmPais(Convert.ToInt32(fgPais.GetData(fgPais.Row, 0)));
                frmpais.ShowDialog();

                CargaPaises();

            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmPais frmpais = new frmPais();
            frmpais.ShowDialog();

            CargaPaises();

        }

    }

}
