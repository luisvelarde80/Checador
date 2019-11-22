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
    public partial class frmCiudades : Form
    {
        public frmCiudades()
        {
            InitializeComponent();
        }

        private void frmCiudades_Load(object sender, EventArgs e)
        {

        }

        private void CargaEstados()
        {

            Estado_Ctl objEstado = new Estado_Ctl();
            BindingSource dbEstados = new BindingSource();

            dbEstados.DataSource = objEstado.listaEstados();

            tscbEstados.ComboBox.ValueMember = "id_estado";
            tscbEstados.ComboBox.DisplayMember = "estado";
            tscbEstados.ComboBox.DataSource = dbEstados;

        }

    }

}
