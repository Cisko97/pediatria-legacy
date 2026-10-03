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
using CapaEntidad;
using CapaDato;

namespace CapaPresentacion.Stats
{
    public partial class frmDiagnosticos : Form
    {
        public frmDiagnosticos()
        {
            InitializeComponent();
        }

        private void frmDiagnosticos_Load(object sender, EventArgs e)
        {

            cargarPacientes();
            cargarDiagnosticos();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarPacientes()
        {
            PacienteNegocio PN = new PacienteNegocio();
            dgvListaPacientes.DataSource = PN.PacienteObtenerPorBit(true);
            dgvListaPacientes.Columns[0].Visible = false;
        }

        private void cargarDiagnosticos()
        {
            ConsultaNegocio CN = new ConsultaNegocio();
            var diagnosticos = CN.ConsultaPersonalizadaTodas();

            IEnumerable<CargarConsultaV> filteredList = diagnosticos
  .GroupBy(c => c.Diagnostico)
  .Select(group => group.First());

            for (var i = 0; i < diagnosticos.Count; i++)
            {
                //  this.chart1.Series["Diagnosticos"].Points.AddXY(diagnosticos[i].Diagnostico);

                //search por diagnosticos para sacar el count

                int porcentaje = CN.ConsultaPersonalizadaPorDiagnostico(diagnosticos[i].Diagnostico).Count;

                chart1.Series[0].Points.AddXY(filteredList.ElementAt(i).Diagnostico, porcentaje);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
          


        }

        private void dgvListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //limpia el gráfico
            foreach (var series in chartPeso.Series)
            {
                series.Points.Clear();
            }

            var indiceRow = dgvListaPacientes.CurrentRow.Index;
            int IDPaciente = 0;
            int IDExpediente = 0;

            IDPaciente = Convert.ToInt32(dgvListaPacientes[0, indiceRow].Value);
            ExpedienteNegocio EN = new ExpedienteNegocio();

            var expediente = EN.ExpedienteObtenerPorIdPaciente(IDPaciente);
            IDExpediente = expediente.Id;

            ConsultaNegocio CN = new ConsultaNegocio();

            var consultas = CN.ConsultaPersonalizadaPorIdExpediente(IDExpediente);
            for (var i = 0; i < consultas.Count; i++)
            {

                this.chartPeso.Series["Peso"].Points.AddXY(consultas[i].Fecha.Value.Year, consultas[i].Peso);

            }
        }
    }
}
