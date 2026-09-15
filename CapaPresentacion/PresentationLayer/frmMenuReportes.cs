using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.PresentationLayer
{
    public partial class frmMenuReportes : Form
    {
        public frmMenuReportes()
        {
            InitializeComponent();
        }

        private void rbPacientes_Click(object sender, EventArgs e)
        {
            rbConsultas.Checked = false;
           
        }

        private void rbConsultas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbConsultas_Click(object sender, EventArgs e)
        {
            rbPacientes.Checked = false;
        
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbPacientes.Checked == true)
            {
                var form = new rptListaPacientes();
                form.ShowDialog(this);
            }
            else if (rbConsultas.Checked == true)
            {
                var form = new rptConsultasPaciente();
                form.ShowDialog(this);
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrrar
        }
    }
}
