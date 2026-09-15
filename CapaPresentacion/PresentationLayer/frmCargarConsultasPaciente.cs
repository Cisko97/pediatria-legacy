using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaDato;
using CapaNegocio;

namespace CapaPresentacion.PresentationLayer
{
    public partial class frmCargarConsultasPaciente : Form
    {
        private int idConsulta = 0;
        private int idExpediente = 0;
        private int idSomatometria = 0;

        public frmCargarConsultasPaciente()
        {
            InitializeComponent();
        }

      

        public void CargarDgvPacientes()
        {
            ConsultaNegocio CN = new ConsultaNegocio();

            var listaConsultas = CN.ConsultaObtenerPorIdExpedienteBit(DatosComunesConsulta.expediente.Id, true);
            dgvConsultaPaciente.DataSource = listaConsultas;
            //dgvConsultaPaciente.Columns[1].Visible = false;
            //dgvConsultaPaciente.Columns[10].Visible = false;
            //dgvConsultaPaciente.Columns[11].Visible = false;
            //dgvConsultaPaciente.Columns[12].Visible = false;
            //dgvConsultaPaciente.Columns[13].Visible = false;
        }

        private void frmCargarConsultasPaciente_Load(object sender, EventArgs e)
        {
            CargarDgvPacientes();
            CargarDatosConsulta();
        }

        private void CargarDatosConsulta()
        {
            txtPaciente.Text = DatosComunesConsulta.pacienteCargado.Nombre1 + " " +
                                   DatosComunesConsulta.pacienteCargado.Apellido1;



        }

        private void dgvConsultaPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var indiceRow = dgvConsultaPaciente.CurrentRow.Index;
                idConsulta = Convert.ToInt16(dgvConsultaPaciente[0, indiceRow].Value);
                idExpediente = DatosComunesConsulta.expediente.Id;

                SomatometriaNegocio SN = new SomatometriaNegocio();
                ConsultaNegocio CN = new ConsultaNegocio();

                var consulta = new ConsultaV();

                //trae el objeto consulta 
                consulta = CN.ConsultaObtenerPorId(idConsulta);

                //trae el objeto somatometría
                var somatometria = new SomatometriaV();
                somatometria = SN.SomatometriaObtenerPorIdConsulta(idConsulta);
                idSomatometria = somatometria.Id;

              
              dpFechaConsulta.Value = Convert.ToDateTime(dgvConsultaPaciente[3, indiceRow].Value);
              tbxSintomas.Text = consulta.Sintomas;
              txtDiagnostico.Text = consulta.Diagnostico;
              
              txtHEA.Text = consulta.HistoriaActual;
              txtObservacionesGenerales.Text = consulta.Observaciones;
              txtTratamiento.Text = consulta.Tratamiento;
              txtSistemas.Text = consulta.RevisionSistema;



              // // examen físico
              txtPeso.Text = somatometria.Peso.ToString();
              txtEstatura.Text = somatometria.Estatura.ToString();
              txtPresionSistolica.Text = somatometria.PresionSistolica.ToString(); ;
              txtPresionDiastolica.Text = somatometria.PresionDiastolica.ToString();
              txtTemperatura.Text = somatometria.Temperatura.ToString();
              txtFC.Text = somatometria.FrecuenciaCardiaca.ToString();
              txtFR.Text = somatometria.FrecuenciaRespiratoria.ToString();
              txtObservacionesSG.Text = somatometria.ObservacionesSG;
              txtObservacionesaAntro.Text = somatometria.ObservacionesAntro;
              txtHallazgo.Text = somatometria.Exploratorio;

            var estaturaMetros = Convert.ToDouble(txtEstatura.Text) / 100;

            var imc = Convert.ToDouble(txtPeso.Text) / (Math.Pow(estaturaMetros, 2));
            txtImc.Text = imc.ToString("0.00");
            //manda a llamar a la funcion ObtenerEdadConsulta
            lblEdadConsulta.Text = CN.ObtenerEdadConsulta(DatosComunesConsulta.pacienteCargado.Id, dpFechaConsulta.Value);


               


            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("error" + ex.InnerException.Message);

            }
            catch (FormatException)
            {


            }


        }

        public void CargarDgvConsulta()
        {

            ConsultaNegocio CN = new ConsultaNegocio();

            var listaConsultas = CN.ConsultaObtenerPorIdExpedienteBit(DatosComunesConsulta.expediente.Id, true);
            // MessageBox.Show(listaConsultas[1].Peso.Value);
            dgvConsultaPaciente.DataSource = listaConsultas;
            dgvConsultaPaciente.Columns[1].Visible = false;
            dgvConsultaPaciente.Columns[1].Visible = false;
            dgvConsultaPaciente.Columns[10].Visible = false;
            dgvConsultaPaciente.Columns[11].Visible = false;
            dgvConsultaPaciente.Columns[12].Visible = false;
            dgvConsultaPaciente.Columns[13].Visible = false;
        }


        private void LimpiarDatos()
        {
            idConsulta = 0;

            idSomatometria = 0;

            dpFechaConsulta.Value = DateTime.Now;
            tbxSintomas.Text = string.Empty;
            txtDiagnostico.Text = string.Empty;
            txtTemperatura.Text = string.Empty;
            txtHEA.Text = string.Empty;
            txtObservacionesGenerales.Text = string.Empty;
            txtObservacionesSG.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtEstatura.Text = string.Empty;
            txtPresionSistolica.Text = String.Empty;
            txtPresionDiastolica.Text = string.Empty;
            txtImc.Text = string.Empty;
        }

        private void btnEliminarConsultas_Click(object sender, EventArgs e)
        {
            if (idConsulta == 0)
            {
                MessageBox.Show("Por favor seleccione un registro a eliminar", "Atención", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            var acceso = new ConsultaDataAccess();
            //Solamente manda a llamar a la función de modificar y se le cambia el valor activo
            //Igual que se hace al momento de editar un registro, por tal motivo no se necesita una función
            //de activar o desactivar en la capa de datos, puesto que se usa la función de modificar directamente.
            var consulta = acceso.ConsultaObtenerPorId(idConsulta);
            consulta.Activo = false;
            bool exito = acceso.ConsultaActualizar(consulta);

            if (exito)
            {
                MessageBox.Show("El registro ha sido eliminado con éxito");

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error. Por favor contacte a Soporte");

            }

            LimpiarDatos();
            CargarDgvConsulta();

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (idConsulta == 0)
            {
                MessageBox.Show("Por favor escoja un registro a editar");
                return;
            }


            var respuesta = DialogResult.Yes;
            if (!(ValidarTexto(txtEstatura) && ValidarTexto(txtPeso) && ValidarTexto(txtPresionSistolica) &&
                ValidarTexto(txtTemperatura) && ValidarTexto(txtDiagnostico) && ValidarTexto(txtObservacionesGenerales) &&
                ValidarTexto(tbxSintomas) && ValidarTexto(txtHEA)))
            {
                var msg = "Hay campos vacíos, desea continuar?";
                respuesta = MessageBox.Show(msg, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }

            if (respuesta != DialogResult.Yes) return;
            var somatometria = new SomatometriaV();

            if (String.IsNullOrWhiteSpace(txtPeso.Text) && String.IsNullOrWhiteSpace(txtEstatura.Text)
                    && String.IsNullOrWhiteSpace(txtPresionSistolica.Text) && String.IsNullOrWhiteSpace(txtTemperatura.Text))
            {
                somatometria.Peso = 0;
                somatometria.Estatura = 1;
                somatometria.PresionSistolica= 0;
                somatometria.PresionDiastolica = 0;
                somatometria.Temperatura = 0;
            }
            if (String.IsNullOrWhiteSpace(txtTemperatura.Text))
            {
                somatometria.Temperatura = 0;
            }
            else
            {
                somatometria.Temperatura = Convert.ToDouble(txtTemperatura.Text);
            }
            if (String.IsNullOrWhiteSpace(txtPeso.Text))
            {
                somatometria.Peso = 0;
            }
            else
            {
                somatometria.Peso = Convert.ToDouble(txtPeso.Text);
            }
            if (String.IsNullOrWhiteSpace(txtEstatura.Text))
            {
                somatometria.Estatura = 0;
            }
            else
            {
                somatometria.Estatura = Convert.ToDouble(txtEstatura.Text);
            }
            if (String.IsNullOrWhiteSpace(txtPresionSistolica.Text))
            {
                somatometria.PresionSistolica = 0;
            }
            else
            {
                somatometria.PresionSistolica = Convert.ToDouble(txtPresionSistolica.Text);
            }

            if (String.IsNullOrWhiteSpace(txtPresionDiastolica.Text))
            {
                somatometria.PresionDiastolica = 0;
            }
            else
            {
                somatometria.PresionDiastolica = Convert.ToDouble(txtPresionDiastolica.Text);
            }

            somatometria.ObservacionesAntro = txtObservacionesaAntro.Text;
            somatometria.ObservacionesSG = txtObservacionesSG.Text;
            somatometria.Id = idSomatometria;
            somatometria.IDConsulta = idConsulta;

            var consulta = new ConsultaV();
            consulta.IDExpediente = DatosComunesConsulta.expediente.Id;
            consulta.Diagnostico = txtDiagnostico.Text;
            consulta.Observaciones = txtObservacionesGenerales.Text;
            consulta.Sintomas = tbxSintomas.Text;
            consulta.HistoriaActual = txtHEA.Text;
            consulta.Fecha = dpFechaConsulta.Value;
            consulta.Activo = true;
            consulta.Tratamiento = txtTratamiento.Text;
            consulta.RevisionSistema = txtSistemas.Text;
            consulta.IDMedico = 1;
            consulta.Id = idConsulta;

            var guardarConsultaSomatometria = new GuardarConsultaSomatometria();

            //clase de negocio
            var exito = guardarConsultaSomatometria.ConsultaSomatometriaActualizar(consulta, somatometria);

            if (exito)
            {
                string mensaje = "La información de la Consulta ha sido guardada con éxito.";
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {

                string mensaje = "Ha ocurrido un eror. Por favor llame a Soporte";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            LimpiarDatos();
            CargarDgvConsulta();
        }

        private void btnRestaurarConsultas_Click(object sender, EventArgs e)
        {
            var form = new frmRestaurarConsulta();
            form.ShowDialog(this);
            CargarDgvConsulta();
        }

        #region ValidacionesGenerales
        private bool ValidarTexto(TextBox controlTexto)
        {
            bool continuar = true;
            if (string.IsNullOrEmpty(controlTexto.Text))
            {
                errorEnValidacion.SetError(controlTexto, "Por favor llenar el campo");
                continuar = false;
            }
            return continuar;
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }


        private void txtTemperatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtEstatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtEstatura_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                var estaturaMetros = Convert.ToDouble(txtEstatura.Text) / 100;

                var imc = Convert.ToDouble(txtPeso.Text) / (Math.Pow(estaturaMetros, 2));
                txtImc.Text = imc.ToString("0.00");
            }
            catch (DivideByZeroException)
            {

                MessageBox.Show("No es recomendable dejar la estatura en cero, o vacía");
                txtImc.Text = 1.ToString();

            }

        }

        #endregion

       
    }
}
