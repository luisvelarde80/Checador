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
    public partial class frmPuesto : Form
    {

        private int idPuesto;

        public frmPuesto()
        {
            InitializeComponent();
            idPuesto = 0;

        }

        public frmPuesto(int _idPuesto)
        {
            InitializeComponent();
            idPuesto = _idPuesto;

        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {

            if(idPuesto > 0)
            {

                CargaPuesto();

            }

        }

        private void CargaPuesto()
        {

            BindingSource dbPuesto = new BindingSource();
            Puesto_Ctl objPuestos = new Puesto_Ctl();
            dbPuesto.DataSource = objPuestos.PuestoSeleccionado(idPuesto);

            txtPuesto.DataBindings.Add("Text", dbPuesto, "puesto", true);

        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {

            if(txtPuesto.Text != "")
            {

                if (idPuesto > 0)
                {
                    Edita();
                }
                else
                {
                    Nuevo();
                }

            }
            else
            {
                lblPuesto.ForeColor = Color.Red;
            }
          
        }

        private void Nuevo() 
        {

            Puesto_Ctl objPuesto = new Puesto_Ctl();
            if( objPuesto.NuevoPuesto(txtPuesto.Text) == 1)
            {
                this.Close();
            }
          
        }

        private void Edita()
        {

            Puesto_Ctl objPuesto = new Puesto_Ctl();
            if(objPuesto.EditaPuesto(idPuesto, txtPuesto.Text) == 1)
            {
                this.Close();
            }

        }

    }

}
