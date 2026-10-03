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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            autenticarUsuario();
        }

        public void autenticarUsuario()
        {
            AutenticarUsuarioNegocio au = new AutenticarUsuarioNegocio();
            //Mandamos a llamar a la función desde la capa de negocios, y le pasamos los parámetros correspondientes
            if (String.IsNullOrWhiteSpace(txtUsername.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe rellernar todos los campos!");
            }
            else
            {

                UsuarioV usuario = new UsuarioV();

                usuario.Username = txtUsername.Text;
                usuario.Password = txtPassword.Text;

                bool validacion = au.ValidarUsuario(usuario);

                if (validacion == true)
                {
                    MessageBox.Show("¡Bienvenida!");
                    var form = new frmBoxInicio();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error de identificación");
                }

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            autenticarUsuario();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrrar
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            Color colorText;
            colorText = Color.FromArgb(50, 50, 50);
            if (txtUsername.Text == "Usuario")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = colorText;
            }
        }

        private void txtUsername_MouseLeave(object sender, EventArgs e)
        {
            Color colorHint;
            colorHint = Color.FromArgb(200, 200, 200);
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Usuario";
                txtUsername.ForeColor = colorHint;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.isPassword = false;
            }
            else
            {
                txtPassword.isPassword = true;
            }
        }

        public Point mauseLocation;

        private void bunifuGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void bunifuGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mauseLocation = new Point(-e.X, -e.Y);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mausePose = Control.MousePosition;
                mausePose.Offset(mauseLocation.X, mauseLocation.Y);
                Location = mausePose;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_MouseEnter_1(object sender, EventArgs e)
        {
          
            
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            
        }
    }
}
