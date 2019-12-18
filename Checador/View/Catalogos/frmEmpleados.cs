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
    public partial class frmEmpleados : Form
    {

        private int activo;

        public frmEmpleados()
        {
            InitializeComponent();
            activo = 0;
        }

        public frmEmpleados(int _activo)
        {
            InitializeComponent();
            activo = _activo;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

            CargaEmpleados();
            if(activo > 0)
            {
                tsbEditar.Enabled = false;
            }

        }

       private void CargaEmpleados()
        {

            Configura();

            List<Empleado_Mdl> ListaEmpleados = new List<Empleado_Mdl>();
            Empleado_Ctl objEmpleado = new Empleado_Ctl();

            ListaEmpleados = objEmpleado.ListaEmpleados(activo);

            foreach(var empleado in ListaEmpleados)
            {

                fgEmpleados.AddItem("");

                fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 0, empleado.id_empleado);
                fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 1, empleado.a_paterno);
                fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 2, empleado.a_materno);
                fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 3, empleado.nombre);

                if(empleado.estatus == 1)
                {
                    fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 4, "Activo");
                }
                else
                {
                    fgEmpleados.SetData(fgEmpleados.Rows.Count - 1, 4, "Inactivo");
                }

            }

        }

        private void Configura()
        {

            fgEmpleados.Cols.Count = 5;
            fgEmpleados.Rows.Count = 1;

            fgEmpleados.Cols[0].Caption = "Id";
            fgEmpleados.Cols[0].Visible = false;
            fgEmpleados.Cols[1].Caption = "A. Paterno";
            fgEmpleados.Cols[2].Caption = "A. Materno";
            fgEmpleados.Cols[3].Caption = "Nombre";
            fgEmpleados.Cols[4].Caption = "Estatus";

            fgEmpleados.AutoSizeCols();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {

            frmEmpleado frmempleado = new frmEmpleado();
            frmempleado.ShowDialog();

            CargaEmpleados();

        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {

            if(fgEmpleados.Row > 0)
            {
                frmEmpleado frmempleado = new frmEmpleado(Convert.ToInt32(fgEmpleados.GetData(fgEmpleados.Row, 0)));
                frmempleado.ShowDialog();

                CargaEmpleados();

            }

        }

    }

}
