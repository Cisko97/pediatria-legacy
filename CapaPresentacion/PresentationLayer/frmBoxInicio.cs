
using CapaPresentacion.Reportes;
using CapaPresentacion.Stats;
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
    public partial class frmBoxInicio : Form
    {
        public static bool banderita; //Permite definir si se agregará un paciente o bien se creará una nueva consulta sobre uno ya existente
        public frmBoxInicio()
        {
            InitializeComponent();
        }


        private void btnAgregarNuevoPaciente_Click(object sender, EventArgs e)
        {

        }

        private void frmBoxInicio_Load(object sender, EventArgs e)
        {

        }
        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrrar
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public Point mauseLocation;
        private void frmBoxInicio_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void frmBoxInicio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

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

        private void btnAgregarNuevoPaciente_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmAgregarPaciente();
            form.ShowDialog(this);
            this.Show();
            banderita = true; //Sí será para crear un paciente nuevo
        }


        private void btnCargarPaciente_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmCargarPaciente();
            form.ShowDialog(this);
            this.Show();
            banderita = false; //Sí será para crear un paciente nuevo
        }

        private void btnAcercaDe_Click_1(object sender, EventArgs e)
        {
            var form = new frmAcercaDe();
            form.ShowDialog(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //var form = new rptListaPacientes();
            var form = new frmMenuReportes();

            form.ShowDialog(this);
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //var form = new testEstadistica();
            //form.ShowDialog(this);

            //var form = new frmCurvaPeso();
            //form.ShowDialog(this);

            var form = new frmDiagnosticos();
            form.ShowDialog(this);
        }
    }
}
