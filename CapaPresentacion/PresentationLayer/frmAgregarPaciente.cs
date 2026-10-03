using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;
// using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.PresentationLayer
{
    public partial class frmAgregarPaciente : Form
    {
        public frmAgregarPaciente()
        {
            InitializeComponent();
        }

        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        GrupoSanguineoNegocio GSN = new GrupoSanguineoNegocio();

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool exito = false;
            if (ValidarTexto(txtNombre1) && ValidarTexto(txtApellido1) &&
                ValidarTexto(txtCiudadNacimiento) && ValidarTexto(txtLugarNacimiento))
            {

                var paciente = new PacienteV();
                paciente.Nombre1 = txtNombre1.Text;
                paciente.Nombre2 = txtNombre2.Text;
                paciente.Apellido1 = txtApellido1.Text;
                paciente.Apellido2 = txtApellido2.Text;
                paciente.CiudadNacimiento = txtCiudadNacimiento.Text;
                paciente.LugarNacimiento = txtLugarNacimiento.Text;
                paciente.NacimientoHospital = chbSi.Checked;
                paciente.FechaNacimiento = dtpFechaNac.Value;
                paciente.NombreMadre = txtNombreMadre.Text;
                paciente.CedulaMadre = txtCedulaMadre.Text;
                paciente.NombrePadre = txtNombrePadre.Text;
                paciente.CedulaPadre = txtCedulaPadre.Text;
                paciente.IDGrupoSanguineo = Convert.ToInt16(cmbGrupoSangre.SelectedValue);
                paciente.Direccion = txtDireccion.Text;
                paciente.EsNino = Convert.ToBoolean(cmbSexo.SelectedIndex);
                paciente.Religion = Convert.ToString(cmbReligion.SelectedItem);
                paciente.Origen = Convert.ToString(cmbOrigen.SelectedItem);
                paciente.Notas = txtObservaciones.Text;
                paciente.Activo = true;

                var expediente = new ExpedienteV();
                // var pacienteExpediente = new PacienteExpedienteAgregar();

                expediente.FechaCreacion = System.DateTime.Now;
                expediente.Descripcion = "Ninguna";
                expediente.Activo = true;
                
                try
                {

                    exito = pacienteNegocio.PacienteExpedienteAdd(paciente, expediente);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:"+ex.InnerException.Message);
                }

                if (exito)//si exito=true
                {
                    var mensaje = "El Paciente ha sido añadido con éxito";
                    MessageBox.Show(mensaje, "Éxito");
                    this.Close();
                   

                }

                
            }

        }


        private bool ValidarTexto(TextBox controlTexto)
        {
            bool continuar = true;
            if (string.IsNullOrEmpty(controlTexto.Text))
            {
                errorValidacion.SetError(controlTexto, "Por favor llenar el campo");
                continuar = false;
            }

            return continuar;
        }

        private void txtNombre1_Validating(object sender, CancelEventArgs e)
        {
            ValidarTexto(txtNombre1);

        }

        private void txtApellido1_Validating(object sender, CancelEventArgs e)
        {
            ValidarTexto(txtApellido1);
        }

        private void txtNombrePadre_Validating(object sender, CancelEventArgs e)
        {
            ValidarTexto(txtNombrePadre);
        }

        private void txtNombreMadre_Validating(object sender, CancelEventArgs e)
        {
            ValidarTexto(txtNombreMadre);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LlenarCmbGrupoSangre();
            cmbOrigen.SelectedValue = 1;

        }

        private void LlenarCmbGrupoSangre()
        {

            
            cmbGrupoSangre.DisplayMember = "NombreGrupo";
            cmbGrupoSangre.ValueMember = "Id";
            cmbGrupoSangre.DataSource = GSN.GrupoSanguineoObtenerTodos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrrar
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public Point mauseLocation; //para que el form se pueda mover

        private void PanelCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void PanelCabecera_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

        private void frmAgregarPaciente_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void frmAgregarPaciente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

        private void txtNombre2_Validating(object sender, CancelEventArgs e)
        {
            ValidarTexto(txtNombre2);
        }

        private void txtApellido2_Validating(object sender, CancelEventArgs e)
        {
            ValidarTexto(txtApellido2);
        }
    }
}
