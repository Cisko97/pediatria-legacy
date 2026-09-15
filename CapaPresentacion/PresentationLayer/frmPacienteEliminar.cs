using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CapaDato;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.PresentationLayer
{
    public partial class frmPacienteEliminar : Form
    {

        private int idPaciente = 0;


        public frmPacienteEliminar()
        {
            InitializeComponent();
        }

        PacienteNegocio pacienteNeg = new PacienteNegocio();
        private void frmPacienteEliminar_Load(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void CargarDgv()
        {

            var acceso = new CargarPacienteDataAccess();
            dgvPacientesEliminados.DataSource = acceso.PacienteObtenerPorBit(false);


        }

        private void dgvPacientesEliminados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var indiceRow = dgvPacientesEliminados.CurrentRow.Index;
            idPaciente = (int)dgvPacientesEliminados[0, indiceRow].Value;

        }

        private void btnRestaurarPaciente_Click(object sender, EventArgs e)
        {
            if (idPaciente == 0) return;
            var pacienteAccess = new PacienteDataAccess();
            var paciente = pacienteAccess.PacienteObtenerPorId(idPaciente);
            paciente.Activo = true;
            bool exito = pacienteAccess.PacienteActualizar(paciente);

            if (exito)
            {
                var mensaje = "El paciente ha sido restaurado con éxito";
                MessageBox.Show(mensaje);
                CargarDgv();


            }
            else
            {
                var mensaje = "Ha ocurrido un error. Por favor Contacte a soporte.";
                MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            idPaciente = 0;
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {

       //     bool exito = false;
            if (idPaciente == 0) return;
            DialogResult respuesta;
            respuesta = MessageBox.Show(
                "Esta operación borrará permanentemente al paciente y toda información relacionada a él. Desea continuar?",
                "Precaución",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {

                
                pacienteNeg.PacienteElimiarCascada(idPaciente);



            }
            idPaciente = 0;
            CargarDgv();
        }





    }
}
