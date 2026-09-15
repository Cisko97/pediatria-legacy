using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Reportes
{
    public partial class rptSomatometriaXPaciente : Form
    {
        public rptSomatometriaXPaciente()
        {
            InitializeComponent();
        }

        private void rptSomatometriaXPaciente_Load(object sender, EventArgs e)
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

            SomatometriaXPaciente cxp = new SomatometriaXPaciente();
            cxp.SetParameterValue("@IDExpediente", IDExpediente);

            this.crystalReportViewer1.ReportSource = cxp;
            this.crystalReportViewer1.Refresh();
        }

        private void dgvListaPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
