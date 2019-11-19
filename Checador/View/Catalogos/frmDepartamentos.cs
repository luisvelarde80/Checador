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
    public partial class frmDepartamentos : Form
    {
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {

            CargaDepto(VariablesGlobales_Ctl.getIdSucursal());

        }


        public void CargaDepto(int idSuc)
        {

            if(idSuc == 0)
            {

                tsbEditar.Enabled = false;

            }
            else
            {

                List<Departamento_Mdl> listaDepto = new List<Departamento_Mdl>();
                Departamento_Ctl objDepto = new Departamento_Ctl();

                listaDepto = objDepto.ListaDepartamentos(idSuc);

                Configura();

                foreach (var depto in listaDepto)
                {

                    fgDepto.AddItem("");

                    fgDepto.SetData(fgDepto.Rows.Count - 1, 0, depto.id_departamento);
                    fgDepto.SetData(fgDepto.Rows.Count - 1, 1, depto.id_sucursal);
                    fgDepto.SetData(fgDepto.Rows.Count -1, 2, depto.departamento);

                    fgDepto.AutoSizeCols();

                }

            }

        }

        private void Configura()
        {

            fgDepto.Cols.Count = 3;
            fgDepto.Rows.Count = 1;

            fgDepto.Cols[0].Caption = "IdDepto";
            fgDepto.Cols[0].Visible = false;
            fgDepto.Cols[1].Caption = "IdSuc";
            fgDepto.Cols[1].Visible = false;
            fgDepto.Cols[2].Caption = "Departamento";

            fgDepto.AutoSizeCols();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if(fgDepto.Row > 0)
            {

                frmDepartamento frmdepto = new frmDepartamento(Convert.ToInt32(fgDepto.GetData(fgDepto.Row,0)));
                frmdepto.ShowDialog();

                CargaDepto(VariablesGlobales_Ctl.getIdSucursal());

            }

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmDepartamento frmdepto = new frmDepartamento();
            frmdepto.ShowDialog();

            CargaDepto(VariablesGlobales_Ctl.getIdSucursal());

        }

    }

}
