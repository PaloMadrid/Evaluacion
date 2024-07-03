using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormulariosComputadoras;
using mis_clases;

namespace Forms
{
    public partial class formPrincipal : Form
    {

        public formPrincipal()
        {
            InitializeComponent();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            dtg_informacion.DataSource = null;
            dtg_informacion.DataSource = Computadora.listadoDeComputadoras();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            formCrear formAlta=new formCrear();

            formAlta.ShowDialog();
            
        }
    }
}
