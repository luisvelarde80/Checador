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
    public partial class frmPuestos : Form
    {
        public frmPuestos()
        {
            InitializeComponent();
        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {

            CargaPuestos();

        }

        private void Configura()
        {

            fgPuestos.Cols.Count = 2;
            fgPuestos.Rows.Count = 1;

            fgPuestos.Cols[0].Caption = "Id";
            fgPuestos.Cols[0].Visible = false;
            fgPuestos.Cols[1].Caption = "Puesto";

            fgPuestos.AutoSizeCols();

        }

        private void CargaPuestos()
        {

            Configura();

            Puesto_Ctl objPuestos = new Puesto_Ctl();

            List<Puesto_Mdl> ListaPuestos = new List<Puesto_Mdl>();
            ListaPuestos = objPuestos.ListarPuestos();

            foreach (var puesto in ListaPuestos)
            {

                fgPuestos.AddItem("");

                fgPuestos.SetData(fgPuestos.Rows.Count - 1, 0, puesto.id_puesto);
                fgPuestos.SetData(fgPuestos.Rows.Count - 1, 1, puesto.puesto);

            }

            fgPuestos.AutoSizeCols();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if(fgPuestos.Row > 0)
            {

                frmPuesto frmpuesto = new frmPuesto(Convert.ToInt32(fgPuestos.GetData(fgPuestos.Row,0)));
                frmpuesto.ShowDialog();

                CargaPuestos();

            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmPuesto frmpuesto = new frmPuesto();
            frmpuesto.ShowDialog();

            CargaPuestos();

        }

    }

}
