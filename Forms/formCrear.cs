using mis_clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosComputadoras
{
    public partial class formCrear : Form
    {
        public formCrear()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formCrear_Load(object sender, EventArgs e)
        {
            cmbx_procesadores.DataSource = Computadora.ListadoDeProcesadores();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
