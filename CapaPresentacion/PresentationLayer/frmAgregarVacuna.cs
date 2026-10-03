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
// using CapaEntidad;
using CapaDato;

namespace CapaPresentacion.PresentationLayer
{
    public partial class frmAgregarVacuna : Form
    {


        public frmAgregarVacuna()
        {
            InitializeComponent();
        }

        int codigoVacuna;

        private void frmAgregarVacuna_Load(object sender, EventArgs e)
        {
            cargarDGV();
        }

        private void btnGuardarV_Click_1(object sender, EventArgs e)
        {
            var VacunaNu = new VacunaV();

            VacunaNu.Nombre = txtNombreVacuna.Text;
            VacunaNu.NumeroDosis = Convert.ToInt16(cmbDosisNumero.Text);
            VacunaNu.Observacion = txtDescripcionVacuna.Text;
            VacunaNu.Activo = true;


            VacunaNegocio Vn = new VacunaNegocio();
            Vn.VacunaInsertar(VacunaNu);

            MessageBox.Show("Vacuna agregada correctamente!");
            cargarDGV();
        }

        private void seleccionarVacunasTabla()
        {
            var indiceRow = dgvVacunas.CurrentRow.Index;

            try
            {
                codigoVacuna = Convert.ToInt16(dgvVacunas[0, indiceRow].Value);

                txtNombreVacuna.Text = dgvVacunas[1, indiceRow].Value.ToString();
                txtDescripcionVacuna.Text = dgvVacunas[2, indiceRow].Value.ToString();
                cmbDosisNumero.Text = dgvVacunas[3, indiceRow].Value.ToString();

            }
            catch (NullReferenceException)
            {
                codigoVacuna = Convert.ToInt16(dgvVacunas[0, indiceRow].Value);
                txtNombreVacuna.Text = dgvVacunas[1, indiceRow].Value.ToString(); //Le asigna el valor de la primer columna del registro seleccionado
                txtDescripcionVacuna.Text = dgvVacunas[2, indiceRow].Value.ToString();
                cmbDosisNumero.Text = dgvVacunas[3, indiceRow].Value.ToString();

            }
        }

        private void cargarDGV()
        {
            VacunaNegocio vn = new VacunaNegocio();

            var mostrar = vn.VacunaObtenerTodos();

            dgvVacunas.DataSource = mostrar;

            dgvVacunas.Columns[0].Visible = false;
        }


        private void dgvVacunas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarVacunasTabla();
        }

        private void btnEditarV_Click(object sender, EventArgs e)
        {
            var VacunaUp = new VacunaV();
            VacunaUp.Id = codigoVacuna;
            VacunaUp.Nombre = txtNombreVacuna.Text;
            VacunaUp.NumeroDosis = Convert.ToInt16(cmbDosisNumero.Text);
            VacunaUp.Observacion = txtDescripcionVacuna.Text;

            VacunaNegocio VN = new VacunaNegocio();

            VN.VacunaActualizar(VacunaUp);

            MessageBox.Show("Vacuna actualizada correctamente!");
            cargarDGV();
        }

      
    }
}
