using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class rptConsultasPaciente : Form
    {
        public rptConsultasPaciente()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void rptConsultasPaciente_Load(object sender, EventArgs e)
        {
            PacienteNegocio PN = new PacienteNegocio();
            dgvListaPacientes.DataSource = PN.PacienteObtenerPorBit(true);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            var indiceRow = dgvListaPacientes.CurrentRow.Index;
            int IDPaciente = 0;
            int IDExpediente = 0;

            IDPaciente = Convert.ToInt32(dgvListaPacientes[0, indiceRow].Value);
            ExpedienteNegocio EN = new ExpedienteNegocio();

            var expediente = EN.ExpedienteObtenerPorIdPaciente(IDPaciente);
            IDExpediente = expediente.Id;

            

            ConsultaXPaciente cxp = new ConsultaXPaciente();
            cxp.SetParameterValue("@IDExpediente", Convert.ToInt32(IDExpediente));
            
            this.crystalReportViewer1.ReportSource = cxp;
            this.crystalReportViewer1.Refresh();
        }

        private void dgvListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
