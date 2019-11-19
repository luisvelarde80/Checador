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

            frmInicioSesion frmSesion = new frmInicioSesion();
            this.Hide();
            if(frmSesion.ShowDialog() == DialogResult.OK)
            {
                frmSucInicio frmsucinicio = new frmSucInicio();
                if(frmsucinicio.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Close();
                }
               
            }
            else
            {
                this.Close();

            }

        }

        private void tsmiSucursales_Click(object sender, EventArgs e)
        {

            frmSucursales frmsucursales = new frmSucursales();
            frmsucursales.MdiParent = this;
            frmsucursales.Show();

        }

        private void tsmiDepartamentos_Click(object sender, EventArgs e)
        {

            frmDepartamentos frmdepartamentos = new frmDepartamentos();
            frmdepartamentos.MdiParent = this;
            frmdepartamentos.Show();

        }

        private void tsmiPuestos_Click(object sender, EventArgs e)
        {

            frmPuestos frmpuestos = new frmPuestos();
            frmpuestos.MdiParent = this;
            frmpuestos.Show();

        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {

            frmUsuarios frmusuarios = new frmUsuarios();
            frmusuarios.MdiParent = this;
            frmusuarios.Show();

        }

    }

}
