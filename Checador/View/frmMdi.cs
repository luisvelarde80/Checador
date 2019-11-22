using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Checador.View;
using Checador.View.Catalogos;
namespace Checador
{
    public partial class frmMdi : Form
    {
      
        public frmMdi()
        {
          
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        
        }

        private void frmMdi_Load(object sender, EventArgs e)
        {

            using (frmInicioSesion frmSesion = new frmInicioSesion())
            {
                this.Hide();
                if (frmSesion.ShowDialog() == DialogResult.OK)
                {
                    using (frmSucInicio frmsucinicio = new frmSucInicio())
                    {
                        if (frmsucinicio.ShowDialog() == DialogResult.OK)
                        {
                            this.Show();
                        }
                        else
                        {
                            this.Close();
                        }
                    }

                }
                else
                {
                    this.Close();

                }
            }

        }

        #region "Catalogos"

        private void tsmiSucursales_Click(object sender, EventArgs e)
        {

            using (frmSucursales frmsucursales = new frmSucursales())
            {
                frmsucursales.MdiParent = this;
                frmsucursales.Show();
            }

        }

        private void tsmiDepartamentos_Click(object sender, EventArgs e)
        {

            using (frmDepartamentos frmdepartamentos = new frmDepartamentos())
            {
                frmdepartamentos.MdiParent = this;
                frmdepartamentos.Show();
            }

        }

        private void tsmiPuestos_Click(object sender, EventArgs e)
        {

            using (frmPuestos frmpuestos = new frmPuestos())
            {
                frmpuestos.MdiParent = this;
                frmpuestos.Show();
            }

        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {

            using (frmUsuarios frmusuarios = new frmUsuarios())
            {
                frmusuarios.MdiParent = this;
                frmusuarios.Show();
            }

        }

        private void tsmiPais_Click(object sender, EventArgs e)
        {

            using (frmPaises frmpaises = new frmPaises())
            {
                frmpaises.MdiParent = this;
                frmpaises.Show();
            }

        }

        private void tsmiEstado_Click(object sender, EventArgs e)
        {

            frmEstados frmestados = new frmEstados();
            frmestados.MdiParent = this;
            frmestados.Show();

        }

        #endregion

        #region "Control de Asistencia"



        #endregion

    }

}
