
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
using CapaDato;
using CapaEntidad;


namespace CapaPresentacion.PresentationLayer
{
    public partial class frmCargarPaciente : Form
    {
        public int PacienteId = 0;
        public frmCargarPaciente()
        {
            InitializeComponent();
        }
         
        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        ExpedienteNegocio expedienteNegocio = new ExpedienteNegocio();
        InformacionNacimientoNegocio nacimientoNegocio = new InformacionNacimientoNegocio();

        private void frmCargarPaciente_Load(object sender, EventArgs e)
        {
            cmbCategoria.SelectedIndex = 0; //Selecciona siempre el elemento #1
            CargarPacientesDGV();
            //SeleccionarRegistro(); //Permite que al momento de cargar el formulario, se muestre la info del primer paciente del dgv en los tbx
        }

        public void CargarPacientesDGV()
        {
           
            //le pasa el valor true a la capa de negocio y la de negocio se encarga de enviar el parametro al CargarPacienteDataAccess
            dgvListaPacientes.DataSource = pacienteNegocio.PacienteObtenerPorBit(true);
            dgvListaPacientes.Columns[0].Visible = false;
        }

        private InformacionNacimientoV TraerInformacionNacimiento()
        {      
            var nacimiento = nacimientoNegocio.NacimientoObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);
            return nacimiento;
        }

        public PacienteV TraerInformacionPaciente()
        {
            var indiceRow = dgvListaPacientes.CurrentRow.Index;
            PacienteId = Convert.ToInt16(dgvListaPacientes[0, indiceRow].Value);

            //Trae el objeto de tipo PacienteEntidad
            var paciente = pacienteNegocio.PacienteObtenerPorId(PacienteId);

            return paciente;
        }

        private ExpedienteV TraerInformacionExpediente()
        {

            
            return expedienteNegocio.ExpedienteObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);
 
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            DatosComunesConsulta.pacienteCargado = TraerInformacionPaciente();
            DatosComunesConsulta.expediente = TraerInformacionExpediente();



            if (PacienteId != 0)
            {

                var consulta = new frmNuevaConsulta();
                consulta.ShowDialog(this);

                //var inicio = new Form1();
                //inicio.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }
        }



        private int SeleccionarRegistro()
        {
            var indiceRow = dgvListaPacientes.CurrentRow.Index;

            try
            {
                tbxNombrePaciente.Text = dgvListaPacientes[1, indiceRow].Value.ToString(); //Le asigna el valor de la primer columna del registro seleccionado
                tbxSegundoNombre.Text = dgvListaPacientes[2, indiceRow].Value.ToString();
                tbxApellido.Text = dgvListaPacientes[3, indiceRow].Value.ToString();
                tbxSegundoApellido.Text = dgvListaPacientes[4, indiceRow].Value.ToString();
            }
            catch (NullReferenceException)
            {
                tbxNombrePaciente.Text = dgvListaPacientes[1, indiceRow].Value.ToString();
                tbxSegundoNombre.Text = String.Empty;
                tbxApellido.Text = dgvListaPacientes[3, indiceRow].Value.ToString();
                tbxSegundoApellido.Text = String.Empty;

            }
            return indiceRow;
        }

        private void btnBuscarTexto_Click(object sender, EventArgs e)
        {
            var ListaPorFiltro = new CargarPacienteDataAccess();

            //Esto permite, llamar al método ObtenerPorFiltro (el cual retorna un List<>) de la clase de acceso a datos de cargarpacientes, luego
            //los componentes (cmbCategoria y tbxTexto) son utilizados para especificar los parámetros del método
            //Se procede a evaluar, dependiendo de la categoría seleccionada, y el texto escrito, el método
            //procede a realizar las diversas consultas. En caso de que encuentre coincidencias, las almacena en q, que es la lista que retorna
            //Aprovechando el hecho de que el método retorna un List<> (q) es posible pasarle todos los valores 
            //que el método recupere (registros) directamente a
            if (String.IsNullOrWhiteSpace(tbxTexto.Text))
            {
                MessageBox.Show("Por favor, especifique el texto que desea buscar");
            }
            else
            {
                dgvListaPacientes.DataSource = ListaPorFiltro.ObtenerPorFiltro(cmbCategoria.SelectedItem.ToString(), tbxTexto.Text);
            }
            //Si el método no arroja ningún registro, se manda un mensaje de error
            if (dgvListaPacientes.RowCount == 0)
            {
                MessageBox.Show("No hay coincidencias");
            }
        }

        private void btnRecargarDGV_Click(object sender, EventArgs e)
        {
            CargarPacientesDGV();
        }

        private void btnEliminarPaciente_Click_1(object sender, EventArgs e)
        {
            var respuesta = DialogResult.None;
            if (PacienteId == 0) return;
            var mensaje = "Seguro desea eliminar el registro seleccionado?";
            respuesta = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes) return;
            
            var paciente = pacienteNegocio.PacienteObtenerPorId(PacienteId);

            paciente.Activo = false;


            bool exito = pacienteNegocio.PacienteActualizar(paciente);

            MessageBox.Show(exito
                ? "El registro ha sido eliminado con éxito"
                : "Ha ocurrido un error. Por favor contactar a soporte");
            PacienteId = 0;
            CargarPacientesDGV();
        }

        private void dgvListaPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var indice = SeleccionarRegistro();
            PacienteId = (int)dgvListaPacientes[0, indice].Value;
        }

        private void btnRestaurarPaciente_Click_1(object sender, EventArgs e)
        {
            var form = new frmPacienteEliminar();
            form.ShowDialog(this);
            CargarPacientesDGV();
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

        private void frmCargarPaciente_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void frmCargarPaciente_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

        private void PanelCabecera_Paint(object sender, PaintEventArgs e)
        {

        }

       






        //Para poder mostrar los datos del dgv en los textbox, con solo hacer click en el registro deseado
        //es necesario hacer uso del evento del dgv conocido como "cellmouseclik" desde la ventana de propiedades.

        //Si se desea eliminar un evento. se puede hacer desde la ventana de propiedades
    }
}
