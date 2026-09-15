using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CapaNegocio;
using CapaEntidad;
using CapaDato;

namespace CapaPresentacion.PresentationLayer
{
    public partial class frmNuevaConsulta : Form
    {

        #region VARIABLES GLOBALES

        System.Drawing.Size sizes;
        int zoom;
        bool banderita = false;

        // int codigoExamen = 0;
        string cadenita; //guarda temporalmente las rutas de las imágenes de los exámenes


        //variables globales para cargar consultas
        private int idConsulta = 0;
        private int idExpediente = 0;
        private int idSomatometria = 0;


        //variables globales para tabFamiliares
        //private bool banderitaFamiliarEditar = false;
        int idFamiliar = 0;
        int idHistoriaFamiliar = 0;

        //variables globales para tabExamenes
        int examenID;

        //Variables globales para tabVacunaDosis
        int vacunaPadre = 0;
        int idVacuna = 0;
        bool flag = false;
        #endregion



        public frmNuevaConsulta()
        {
            InitializeComponent();

        }

        PacienteNegocio pacienteNegocio = new PacienteNegocio();
        ParentescoNegocio parentescoNeg = new ParentescoNegocio();
        GrupoSanguineoNegocio sanguineoNeg = new GrupoSanguineoNegocio();
        InformacionNacimientoNegocio nacimientoNeg = new InformacionNacimientoNegocio();

        private void frmPacienteHome_Load(object sender, EventArgs e)
        {
            //Cada vez que una clase se instancia con new, todas sus variables globales se reinician - OJO al queres usarlas luego de la instanciación
            //Para evitarlo se recomienda usar static en la variable

            sizes = pbExamen.Size; //Obtiene el tamaño original del picture box del examen


            if (frmBoxInicio.banderita == true)
            {
                //this.btnEditar.Enabled = false;


                lblExitoConsulta.ForeColor = Color.ForestGreen;
                lblRecordatorioNac.Font = new Font(lblRecordatorioNac.Font.Name, 12.0F);
                lblRecordatorioNac.Text = "¡Recuerde ingresar la información de nacimiento!";


            }

            FitImage();
            CargarGrupoSanguineo();
            CargarDatosPacienteTabGeneral();
            CargarExamenPaciente();
            Cargar_vacuna();
            Cargar_Parentesco();
            Cargar_InfoFamiliar();
            CargarInformacionNacimiento();
            CargarAntecedentes();
            CargarDgvConsulta();
            dpFechaConsulta.Value = DateTime.Now;
            dtpFechaRealizacion.Value = DateTime.Now;
            dtpFechaSuministro.Value = DateTime.Now;
        }



        #region PARENTESCO

        private void Cargar_Parentesco()
        {

            var catalogoParentesco = parentescoNeg.ParentescoObtenerTodos();

            cmbParentesco.ValueMember = "Id";
            cmbParentesco.DisplayMember = "Nombre";
            cmbParentesco.DataSource = catalogoParentesco;
        }

        #endregion

        #region GRUPO_SANGUÍNEO
        private void CargarGrupoSanguineo()
        {

            var grupos = sanguineoNeg.GrupoSanguineoObtenerTodos();

            //Combobox del paciente
            cmbGrupoSanguineo.ValueMember = "Id";
            cmbGrupoSanguineo.DisplayMember = "NombreGrupo";
            cmbGrupoSanguineo.DataSource = grupos;

            //Combobox de los familiares
            cmbGrupoSanguineoFam.ValueMember = "Id";
            cmbGrupoSanguineoFam.DisplayMember = "NombreGrupo";
            cmbGrupoSanguineoFam.DataSource = grupos;

        }
        #endregion


        #region CONSULTA

        private void btnGuardarConsulta_Click(object sender, EventArgs e)
        {

            var msg = "Hay campos vacíos, desea continuar?";
            var respuesta = MessageBox.Show(msg, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {

                SomatometriaV somatometria = new SomatometriaV();

                if (String.IsNullOrWhiteSpace(txtPeso.Text) && String.IsNullOrWhiteSpace(txtEstatura.Text)
                    && String.IsNullOrWhiteSpace(txtPresionSistolica.Text) && String.IsNullOrWhiteSpace(txtTemperatura.Text))
                {
                    somatometria.Peso = 0;
                    somatometria.Estatura = 1;

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

                somatometria.PerimetroCefalico = Convert.ToDouble(txtPC.Text);
                somatometria.PerimetroAbdominal = Convert.ToDouble(txtPA.Text);
                somatometria.PerimetroToracico = Convert.ToDouble(txtPT.Text);
                //  somatometria.ObservacionesAntro = txtObservacionesaAntro.Text;

                somatometria.FrecuenciaCardiaca = Convert.ToInt32(txtFC.Text);
                somatometria.FrecuenciaRespiratoria = Convert.ToInt32(txtFR.Text);


                // somatometria.ObservacionesSG = txtObservacionesSG.Text;
                somatometria.Exploratorio = txtHallazgo.Text;

                var consulta = new ConsultaV();

                consulta.IDExpediente = DatosComunesConsulta.expediente.Id;
                consulta.Diagnostico = txtDiagnostico.Text;
                consulta.Observaciones = txtObservacionesGenerales.Text;
                //consulta.Sintomas = tbxSintomas.Text;
                consulta.HistoriaActual = txtHEA.Text;
                consulta.Fecha = dpFechaConsulta.Value;
                consulta.Tratamiento = txtTratamiento.Text;
                consulta.IDMedico = 1;
                //consulta.RevisionSistema = txtSistemas.Text;
                consulta.Activo = true;

                //desde la capa de negocio
                var guardarConsultaSomatometria = new GuardarConsultaSomatometria();

                var exito = guardarConsultaSomatometria.ConsultaSomatometriaAdd(consulta, somatometria);

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
                LimpiarCamposConsulta();
                CargarDgvConsulta();
            }
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
            catch (FormatException)
            {
                MessageBox.Show("Ingrese solo números!!!");
            }

        }



        #endregion


        #region PACIENTE

        private void CargarDatosPacienteTabGeneral()
        {
            tlbNombre.Text = DatosComunesConsulta.pacienteCargado.Nombre1 + "  " + DatosComunesConsulta.pacienteCargado.Apellido1;
            txtNombre1.Text = DatosComunesConsulta.pacienteCargado.Nombre1;
            txtNombre2.Text = DatosComunesConsulta.pacienteCargado.Nombre2;
            txtApellido1.Text = DatosComunesConsulta.pacienteCargado.Apellido1;
            txtApellido2.Text = DatosComunesConsulta.pacienteCargado.Apellido2;
            txtNombrePadre.Text = DatosComunesConsulta.pacienteCargado.NombrePadre;
            txtNombreMadre.Text = DatosComunesConsulta.pacienteCargado.NombreMadre;
            txtDireccion.Text = DatosComunesConsulta.pacienteCargado.Direccion;
            dtpFechaNac.Value = Convert.ToDateTime(DatosComunesConsulta.pacienteCargado.FechaNacimiento);
            txtCiudadNacimiento.Text = DatosComunesConsulta.pacienteCargado.CiudadNacimiento;
            txtLugarNacimiento.Text = DatosComunesConsulta.pacienteCargado.LugarNacimiento;
            txtNotas.Text = DatosComunesConsulta.pacienteCargado.Notas;
            cmbGrupoSanguineo.SelectedValue = DatosComunesConsulta.pacienteCargado.IDGrupoSanguineo;
            cmbSexo.SelectedIndex = Convert.ToInt16(DatosComunesConsulta.pacienteCargado.EsNino);
            chbSi.Checked = Convert.ToBoolean(DatosComunesConsulta.pacienteCargado.NacimientoHospital);
            lblTextoEdad.ForeColor = Color.ForestGreen;
            lblExito.Font = new Font(lblTextoEdad.Font.Name, 11.0F);
            lblTextoEdad.Text = pacienteNegocio.ObtenerEdad(DatosComunesConsulta.pacienteCargado.Id);
            txtPaciente.Text = DatosComunesConsulta.pacienteCargado.Nombre1 + "  " + DatosComunesConsulta.pacienteCargado.Apellido1;
            cmbReligion.SelectedItem = DatosComunesConsulta.pacienteCargado.Religion;
            cmbOrigen.SelectedItem= DatosComunesConsulta.pacienteCargado.Origen;
            dpFechaConsulta.Value = DateTime.Now;

        }

        #endregion 

        #region CONTROLES
        public void CambiarReadOnlyToFalse(TabControl panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox) control.Enabled = false;

            }

            if (panel.TabIndex == 1)
            {
                cmbSexo.Enabled = false;
                cmbGrupoSanguineo.Enabled = false;
                chbSi.Enabled = false;
                dtpFechaNac.Enabled = false;
            }

            else if (panel.TabIndex == 2)
            {
                //Consulta
                //tbxSintomas.Enabled = false;
                txtDiagnostico.Enabled = false;
                txtObservacionesGenerales.Enabled = false;
                //txtObservacionesaAntro.Enabled = false;
                txtHEA.Enabled = false;
                txtPresionSistolica.Enabled = false;
                txtTemperatura.Enabled = false;
                txtImc.Enabled = false;
                txtEstatura.Enabled = false;
            }

            else if (panel.TabIndex == 3)
            {
                //Exámenes
                tbxNombreExamen.Enabled = false;
                txtNotas.Enabled = false;

            }

        }


        public void CambiarReadOnlyToTrue()
        {
            foreach (Control control in tabGeneral.Controls)
            {
                if (control is TextBox) control.Enabled = true;

            }

            cmbSexo.Enabled = true;
            cmbGrupoSanguineo.Enabled = true;
            chbSi.Enabled = true;
            dtpFechaNac.Enabled = true;

        }

        #endregion

        #region EXPEDIENTE

        private void txtNombre1_TextChanged(object sender, EventArgs e)
        {
            ValidarTexto(txtNombre1);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        #endregion


        #region INFORMACIÓN_NACIMIENTO

        private void CargarInformacionNacimiento()
        {
            var existe = nacimientoNeg.VerificarRegistroNacimiento(DatosComunesConsulta.pacienteCargado.Id);

            if (existe == true)
            {
                //traemos el objeto desde la bd
                var nacimiento = nacimientoNeg.NacimientoObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);

                txtPesoNacimiento.Text = nacimiento.Peso.ToString();
                txtPerimetroCefalico.Text = nacimiento.PerimetroCefalico.ToString();
                txtAlturaNacimiento.Text = Convert.ToDouble(nacimiento.Altura).ToString();
                txtMotivoCesarea.Text = nacimiento.MotivoCesarea;
                txtObservacionesParto.Text = nacimiento.Observaciones;
                cbCesarea.Checked = Convert.ToBoolean(nacimiento.FueCesarea);
                chbCircularCordon.Checked = Convert.ToBoolean(nacimiento.CircularCordon);
                txtEnfermedades.Text = nacimiento.EnfermedadEmbarazo;
                txtMedicacion.Text = nacimiento.MedicacionEmbarazo;
                txtComplicaciones.Text = nacimiento.ComplicacionEmbarazo;

                txtEdadGestacional.Text = Convert.ToInt32(nacimiento.EdadGestacional).ToString();


                if (Convert.ToBoolean(nacimiento.CircularCordon) == true)
                {
                    rbVer.Checked = true;
                    rbHor.Checked = false;
                }
                else
                {
                    rbVer.Checked = false;
                    rbHor.Checked = true;
                }

            }

            else {

                lblNacimiento.Text = "El paciente no cuenta con información de nacimiento registrada";
            }
        }


        private InformacionNacimientoV TraerInformacionNacimiento()
        {

            return nacimientoNeg.NacimientoObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);
        }


        private void btnGuardarNac_Click(object sender, EventArgs e)
        {


            //actualiza


            //para obtener el ID del registro de nacimiento y poder actualizarlo.


            InformacionNacimientoV inv = new InformacionNacimientoV();



            inv.IDPaciente = DatosComunesConsulta.pacienteCargado.Id;

            inv.Observaciones = txtObservacionesParto.Text;
            inv.MotivoCesarea = txtMotivoCesarea.Text;
            inv.FueCesarea = cbCesarea.Checked;
            inv.CircularCordon = chbCircularCordon.Checked;

            inv.EnfermedadEmbarazo = txtEnfermedades.Text;
            inv.ComplicacionEmbarazo = txtComplicaciones.Text;
            inv.MedicacionEmbarazo = txtMedicacion.Text;


            //Posicion
            if (rbHor.Checked == true)
            {
                inv.Posicion = true;
            }
            else
            {
                inv.Posicion = false;
            }


            //Registro de antropometría
            if ((String.IsNullOrWhiteSpace(txtPesoNacimiento.Text) && String.IsNullOrWhiteSpace(txtPerimetroCefalico.Text)
                && String.IsNullOrWhiteSpace(txtAlturaNacimiento.Text)))
            {
                inv.PerimetroCefalico = 0;
                inv.Peso = 0;
                inv.Altura = 1;
            }
            if (String.IsNullOrWhiteSpace(txtPerimetroCefalico.Text))
            {
                inv.PerimetroCefalico = 0;
            }
            else
            {
                inv.PerimetroCefalico = Convert.ToDouble(txtPerimetroCefalico.Text);
            }
            if (String.IsNullOrWhiteSpace(txtPesoNacimiento.Text))
            {
                inv.Peso = 0;
            }
            else
            {
                inv.Peso = Convert.ToDouble(txtPesoNacimiento.Text);
            }
            if (String.IsNullOrWhiteSpace(txtAlturaNacimiento.Text))
            {

                inv.Altura = 1;
            }

            else
            {

                inv.Altura = Convert.ToDouble(txtAlturaNacimiento.Text);
            }

            if (String.IsNullOrWhiteSpace(txtEdadGestacional.Text))
            {
                inv.EdadGestacional = 0;
            }
            else
            {
                inv.EdadGestacional = Convert.ToInt32(txtEdadGestacional.Text);
            }


            //verifica si el registro existe solo para actualizarlo
            var existe = nacimientoNeg.VerificarRegistroNacimiento(DatosComunesConsulta.pacienteCargado.Id);

            if (existe == true)
            {
                var nacimiento = nacimientoNeg.NacimientoObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);

                inv.Id = nacimiento.Id; //Se le pasa el id de nacimiento del paciente cargado para poder modificar el único registro en la tabla
                                        //ya que el guardar es único a la hora de agregar un paciente nuevo, luego solo se carga el idpaciente de la tabla nacimiento
                                        //y se le pasa ese id al método de actualizar la información de nacimiento.
                nacimientoNeg.InformacionNacimientoActualizar(inv);
                MessageBox.Show("¡Datos actualizados correctamente!");
            }
            else
            {
                //le pasa los datos sin el id de nacimiento
                nacimientoNeg.InformacionNacimientoInsertar(inv);

                MessageBox.Show("¡Datos guardados correctamente!");
            }


        }


        #endregion


        #region INFORMACIÓN_FAMILIAR

        private void dgvFamiliares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indiceRow = dgvFamiliares.CurrentRow.Index;

                idFamiliar = Convert.ToInt16(dgvFamiliares[0, indiceRow].Value); //si ningun id fue seleccionado, entonces el valor de la variable es 0
                idHistoriaFamiliar = Convert.ToInt16(dgvFamiliares[1, indiceRow].Value);

                txtNombre.Text = dgvFamiliares[2, indiceRow].Value.ToString();

              
               
                cmbParentesco.SelectedValue = dgvFamiliares[3, indiceRow].Value;
                cmbGrupoSanguineoFam.SelectedValue = dgvFamiliares[5, indiceRow].Value;
                txtTelefono.Text = dgvFamiliares[7, indiceRow].Value.ToString();
                txtAnotaciones.Text = dgvFamiliares[9, indiceRow].Value.ToString();
                txtCondicionMedica.Text = dgvFamiliares[10, indiceRow].Value.ToString();
              

            }
            catch (NullReferenceException)
            {


            }
        }

        private void Cargar_InfoFamiliar()
        {
            var IFN = new InformacionFamiliarNegocio();
            var list = IFN.CargarInformacionFamiliarObtenerPorBit(true, DatosComunesConsulta.pacienteCargado.Id);
            dgvFamiliares.DataSource = list;
            dgvFamiliares.Columns[0].Visible = false;
            dgvFamiliares.Columns[1].Visible = false;
            dgvFamiliares.Columns[3].Visible = false;
            dgvFamiliares.Columns[4].Visible = false;
            dgvFamiliares.Columns[5].Visible = false;
            dgvFamiliares.Columns[12].Visible = false;

        }
        private void btnRestaurarFamiliar_Click(object sender, EventArgs e)
        {
            //var form = new frmRestaurarFamiliar();
            //form.ShowDialog(this);
            //Cargar_InfoFamiliar();

        }

        private void btnGuardarFamiliar_Click(object sender, EventArgs e)
        {


            /*Ya que en la capa de negocios fue definido el método de ingresar dos registros en tablas distintas.
            A continuación solo se procede a determinar los parámetros correspondientes a cada tabla, pero de forma
            independiente, pero se sabe que la función de agregar, se encargará de separar la información, y relacionar
            los campos que sean necesarios.            
            Referencia al registro de la tabla subordinada (mediante su vista correspondiente, la cual ya tiene designada una entidad)
            Por tanto, se aprovecha pasarle como parámetros los campos de la vista a los métodos encargados de actualizar e ingresar registros
            */

            if (idFamiliar == 0)
            {
                var respuesta = DialogResult.None;
                if (ValidarTexto(txtTelefono))
                {
                    respuesta = MessageBox.Show(
                    "Si el numero teléfono están incompletos, no se guardarán, desea continuar?",
                    "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (respuesta == DialogResult.No) return;



                if (ValidarTexto(txtNombre) && ValidarTexto(txtCondicionMedica))
                {

                    var hfc = new HistoriaClinicaFamiliarV();
                    hfc.IDGrupoSanguineo = Convert.ToInt16(cmbGrupoSanguineoFam.SelectedValue);
                    hfc.ObservacionesMedicas = txtCondicionMedica.Text;

                    //El valor del id foráneo ya fue asignado en la capa de negocios, una vez que se haya creado la información familiar
                    //se le pasa el valor del id generado  al id foráneo de forma automática
                    //Referencia a la tabla de Información Familiar (Principal)

                    var fi = new InformacionFamiliarV();
                    fi.Nombre = txtNombre.Text;
                    fi.IDParentesco = Convert.ToInt16(cmbParentesco.SelectedValue);
                    fi.IDPaciente = Convert.ToInt16(DatosComunesConsulta.pacienteCargado.Id);
                    fi.Observaciones = txtAnotaciones.Text;
                    fi.Activo = true;




                    if (txtTelefono.MaskFull)
                    {
                        var justDigits = new string(txtTelefono.Text.Where(char.IsDigit).ToArray());
                        fi.TelContacto = Convert.ToInt32(justDigits);
                    }
                    else
                    {
                        fi.TelContacto = 0;
                    }
                    var guardarInfoFamiliar = new InformacionFamiliarHistorialClinico();
                    //Accede a la clase de la capa de negocio
                    bool exito = false;

                    exito = guardarInfoFamiliar.InfoFamiliarHistorialClinico(fi, hfc);
                    //Manda a llamar al método encargado de ingresar ambos registros en tablas distintas, claro,etá, habiendo creado primero el registro padre



                    if (exito)
                    {
                        var mensaje = "El registro ha sido guardado con éxito";
                        MessageBox.Show(mensaje);
                        LimpiarCamposFamiliares();
                        Cargar_InfoFamiliar();
                        idFamiliar = 0;
                        idHistoriaFamiliar = 0;
                    }
                    else
                    {
                        var mensaje = "Ha ocurrido un error. \nPor favor contacte a soporte técnico";
                        // MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else return;

            }

            else
            {



                var hfc = new HistoriaClinicaFamiliarV();
                hfc.IDGrupoSanguineo = Convert.ToInt16(cmbGrupoSanguineoFam.SelectedValue);
                hfc.ObservacionesMedicas = txtCondicionMedica.Text;
                hfc.IDInformacionFamiliar = idFamiliar;
                hfc.Id = idHistoriaFamiliar;

                var fi = new InformacionFamiliarV();
                fi.Nombre = txtNombre.Text;
                fi.IDParentesco = Convert.ToInt16(cmbParentesco.SelectedValue);
                fi.IDPaciente = Convert.ToInt16(DatosComunesConsulta.pacienteCargado.Id);
                fi.Observaciones = txtAnotaciones.Text;
                fi.Activo = true;

                fi.Activo = true;
                var justDigits = new string(txtTelefono.Text.Where(char.IsDigit).ToArray());

                justDigits = new string(txtTelefono.Text.Where(char.IsDigit).ToArray());

                fi.TelContacto = Convert.ToInt32(justDigits);
                fi.Id = idFamiliar;

                var infoHistoria = new InformacionFamiliarHistorialClinico();
                bool exito = infoHistoria.InformacionFamiliarHistorialClinicoEditar(fi, hfc);


                if (exito)
                {
                    var mensaje = "El registro ha sido modificado con éxito";
                    MessageBox.Show(mensaje);
                    LimpiarCamposFamiliares();
                    Cargar_InfoFamiliar();
                }
                else
                {
                    var mensaje = "Ha ocurrido un error. \nPor favor contacte a soporte técnico";
                    MessageBox.Show(mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                idFamiliar = 0;
                idHistoriaFamiliar = 0;


            }

        }
        private void btnEliminarFamiliar_Click(object sender, EventArgs e)
        {
            var mensaje = "El registro será eliminado, desea continuar?";
            var respuesta = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                bool exito;
                if (idFamiliar == 0)
                {
                    var msg = "Por favor seleccione un registro a eliminar";
                    MessageBox.Show(msg, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    var IFN = new InformacionFamiliarNegocio();
                    var familiar = new InformacionFamiliarV();
                    familiar = IFN.InformacionFamiliarObtenerPorId(idFamiliar);
                    familiar.Activo = false;
                    exito = IFN.InformacionFamiliarActualizar(familiar);

                }

                if (exito)
                {
                    var message = "El registro ha sido eliminado con éxito";
                    MessageBox.Show(message);
                    LimpiarCamposFamiliares();
                    Cargar_InfoFamiliar();

                }
                else
                {
                    var message = "Ha ocurrido un error. \nPor favor contacte a soporte técnico";
                    MessageBox.Show(message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                idFamiliar = 0;
                idHistoriaFamiliar = 0;

            }

            idFamiliar = 0;
            idHistoriaFamiliar = 0;

        }

        private void txtCelular_Click(object sender, EventArgs e)
        {

        }
        private void txtTelefono_Click(object sender, EventArgs e)
        {
            txtTelefono.SelectAll();
        }

        //Validaciones en Tab Familiares
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }


        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }



        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCamposFamiliares();
            Cargar_InfoFamiliar();
            idFamiliar = 0;
            idHistoriaFamiliar = 0;

        }
        private void LimpiarCamposFamiliares()
        {
            txtNombre.Text = string.Empty;

            txtTelefono.Text = string.Empty;

            txtAnotaciones.Text = string.Empty;
            txtCondicionMedica.Text = string.Empty;
        }


        #endregion


        #region EXÁMENES


        private void FitImage() {

            pbEsquema.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void CargarExamenPaciente()
        {

            var EN = new ExamenNegocio();
            var list = EN.CargarExamenObtenerPorBit(true, DatosComunesConsulta.expediente.Id); //Los exámenes del paciente con bit true

            dgvExamen.DataSource = list;

            //Oculta los  campos innecesarios de la vista
            dgvExamen.Columns[0].Visible = false;
            dgvExamen.Columns[1].Visible = false;
            dgvExamen.Columns[6].Visible = false;
        }


        private void InsertarExamen()
        {
            
        } //de david


        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();

            Abrir.Filter = "*.bmp; *.gif;*.jpg;*.png|*.bmp; *.gif;*.jpg;*.png";
            Abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Abrir.Title = "Seleccionar la imagen";
            Abrir.RestoreDirectory = true;

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                string rutita;

                pbExamen.Image = Image.FromFile(Abrir.FileName);
                pbExamen.SizeMode = PictureBoxSizeMode.StretchImage;
                rutita = Abrir.FileName;
                ValidarImagen vi = new ValidarImagen();
                FileInfo fi = new FileInfo(rutita);

                var validacion = vi.ValidarFormatoImagen(fi.Length / 1000, rutita); //Le pasa como parámetros el tamaño del archivo y la ruta

                lblExtension.Text = Path.GetExtension(rutita); //Le indica al usuario la extensión de la imagen
                lblTM.Text = (fi.Length / 1000).ToString() + " KB"; //Define el tamaño de la imagen seleccionada

                if (validacion != true)
                {
                    MessageBox.Show("Es probable que la imagen seleccionada no se ajuste a los parámetros establecidos");
                    cadenita = Abrir.FileName;
                }
                else
                {
                    cadenita = Abrir.FileName;
                }


            }
            else
            {
                pbExamen.Image = null;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            InsertarExamen();
        }

        private void tbExamen_Scroll(object sender, EventArgs e)
        {
            //Para controlar el tamaño de la imagen a medida que se hace zoom
            if (banderita == false)
            {
                zoom = tbExamen.Value;
                if (zoom == 20) //Permite determinar si el trackerball ha llegado a su tope en el lado derecho,
                //de tal manera que el zoom no avance más hacia esa dirección, sino solo a la izquierda
                {
                    banderita = true;
                }
            }

            if (banderita == true)
            {
                zoom = tbExamen.Value;
                if (zoom == 0)//Permite determinar si el trackerball ha llegado a su tope en el lado izquierdo,
                //de tal manera que el zoom no avance más hacia esa dirección, sino solo a la derecha
                {
                    banderita = false;
                }
            }

            //Controla el tamaño del picturebox a medida que se accede al evento del trackerball
            pbExamen.Width = (sizes.Width / 10) * zoom; //El ancho del pb será igual al valor del trackerbal
            pbExamen.Height = (sizes.Height / 10) * zoom;
        }



        private void dgvExamen_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var indiceRow = dgvExamen.CurrentRow.Index;


            ImageConverter Converter = new ImageConverter();
            examenID = Convert.ToInt16(dgvExamen[0, indiceRow].Value.ToString()); //Le asignamos el valor del ID, para luego ocuparlo como parámetro a la hora de modificar o eliminar registros

            tbxNombreExamen.Text = dgvExamen[2, indiceRow].Value.ToString();
            rbNotasExamen.Text = dgvExamen[3, indiceRow].Value.ToString();

            if ((dgvExamen[4, indiceRow].Value == null))
            {
                pbExamen.Image = null;
            }
            else
            {
                pbExamen.Image = (Image)Converter.ConvertFrom(dgvExamen[4, indiceRow].Value);
            }
            dtpFechaRealizacion.Value = Convert.ToDateTime(dgvExamen[5, indiceRow].Value.ToString());


        }


        private void btnEditarExamen_Click(object sender, EventArgs e)
        {
           
        }

        //Validaciones para tabEaxamenes

        public void LimpiarCamposExamenes()
        {
            tbxNombreExamen.Clear();
            rbNotasExamen.Clear();
            dgvExamen.Columns.Clear();
            pbExamen.Image = null;
            dtpFechaRealizacion.Value = DateTime.Now;
            lblExtension.Text = "-";
            lblTM.Text = "-";
        }

        #endregion



        #region VACUNAS

        private void Cargar_vacuna()
        {
            var VN = new VacunaNegocio();
            var vacuna = VN.VacunaObtenerTodos();
            cmbVacunaNom.ValueMember = "Id";
            cmbVacunaNom.DisplayMember = "Nombre";
            cmbVacunaNom.DataSource = vacuna;


            var dosis = new DosisVacunaNegocio();

            dvgVacunaDosis.DataSource = dosis.CargarDosisPorBit(true, DatosComunesConsulta.expediente.Id);
            dvgVacunaDosis.Columns[0].Visible = false;
            dvgVacunaDosis.Columns[1].Visible = false;
            dvgVacunaDosis.Columns[2].Visible = false;
            dvgVacunaDosis.Columns[7].Visible = false;
        }


        private void btnAgregarNuevaVacuna_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarVacuna();
            frm.Show();
        }

        private void btnGuardarV_Click(object sender, EventArgs e)
        {
            var vacuna = new DosisVacunaV();
            vacuna.IDExpediente = Convert.ToInt16(DatosComunesConsulta.expediente.Id);
            vacuna.Notas = txtObservacionesVacuna.Text;
            vacuna.NumeroDosis = cmbNumeroDosis.Text;
            vacuna.IDVacuna = Convert.ToInt16(cmbVacunaNom.SelectedValue);
            vacuna.FechaAplicacion = dtpFechaSuministro.Value;
            vacuna.enConsultorio = Convert.ToBoolean(cbAplicacion.Checked);
            vacuna.Activo = true;

            var guardarDosisVacuna = new DosisVacunaNegocio();
            guardarDosisVacuna.DosisVacunaInsertar(vacuna);
            Cargar_vacuna();
        }

        public void Cargar_cmbVacunaNom()
        {
            var VN = new VacunaNegocio();
            var vacuna = VN.VacunaObtenerTodos();
            cmbVacunaNom.ValueMember = "Id";
            cmbVacunaNom.DisplayMember = "Nombre";
            cmbVacunaNom.DataSource = vacuna;
        }

        private void mbVacunaNom_SelectedClick(object sender, EventArgs e)
        {
            Cargar_cmbVacunaNom();
            flag = true;
        }

        private void btnEditarDosisV_Click(object sender, EventArgs e)
        {
            if (idVacuna == 0)
            {
                MessageBox.Show("Debe seleccionar un registro de la tabla!!!");
            }
            else
            {
                var vacuna = new DosisVacunaV();

                vacuna.Id = idVacuna;
                vacuna.IDExpediente = Convert.ToInt16(DatosComunesConsulta.expediente.Id);
                vacuna.Notas = txtObservacionesVacuna.Text;
                vacuna.NumeroDosis = cmbNumeroDosis.Text;
                if (flag == true)
                {
                    vacuna.IDVacuna = Convert.ToInt16(cmbVacunaNom.SelectedValue);
                }
                else
                {
                    vacuna.IDVacuna = vacunaPadre;
                }

                vacuna.FechaAplicacion = dtpFechaSuministro.Value;
                vacuna.enConsultorio = Convert.ToBoolean(cbAplicacion.Checked);
                vacuna.Activo = true;

                var guardarDosisVacuna = new DosisVacunaNegocio();

                guardarDosisVacuna.DosisVacunaActualizar(vacuna);
                Cargar_vacuna();
            }
        }

        private void dvgVacunaDosis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var indiceRow = dvgVacunaDosis.CurrentRow.Index;

            try
            {
                cmbVacunaNom.Text = " ";
                cmbNumeroDosis.Text = " ";
                idVacuna = Convert.ToInt16(dvgVacunaDosis[0, indiceRow].Value.ToString());
                vacunaPadre = Convert.ToInt16(dvgVacunaDosis[1, indiceRow].Value.ToString());
                cmbVacunaNom.SelectedText = dvgVacunaDosis[3, indiceRow].Value.ToString();
                cmbNumeroDosis.SelectedText = dvgVacunaDosis[4, indiceRow].Value.ToString();
                dtpFechaSuministro.Value = Convert.ToDateTime(dvgVacunaDosis[5, indiceRow].Value.ToString());
                txtObservacionesVacuna.Text = dvgVacunaDosis[6, indiceRow].Value.ToString();
                cbAplicacion.Checked = Convert.ToBoolean(dvgVacunaDosis[8, indiceRow].Value.ToString());

            }
            catch (NullReferenceException)
            {

            }
        }

        #endregion


        private void btnCargarConsultas_Click(object sender, EventArgs e)
        {
            this.dgvConsultaPaciente.ReadOnly = false;
            this.dgvConsultaPaciente.Enabled = true;
            this.btnGuardarConsulta.Enabled = false;
            this.txtEstatura.Enabled = false;
            this.txtPeso.Enabled = false;
            this.txtTemperatura.Enabled = false;
            this.txtPerimetroCefalico.Enabled = false;
            this.txtPC.Enabled = false;
            this.txtPT.Enabled = false;
            this.txtPA.Enabled = false;
            this.txtFC.Enabled = false;
            this.txtFR.Enabled = false;
            this.txtImc.Enabled = false;
            this.txtPresionDiastolica.Enabled = false;
            this.txtPresionSistolica.Enabled = false;
        }

        private void LimpiarCamposConsulta()
        {
          
            foreach (Control ctr in gbSignos.Controls)
                {
                  if (ctr is TextBox)
                    {
                        ctr.Text = "";
                    }

                  if (ctr is ComboBox)
                    {
                        ComboBox cm = new ComboBox();
                        cm = (ComboBox)ctr;
                        cm.SelectedIndex = -1;
                    }

                }
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
        private bool ValidarTexto(MaskedTextBox controlTexto)
        {
            bool continuar = true;
            if (!controlTexto.MaskFull)
            {
                errorEnValidacion.SetError(controlTexto, "Por favor llenar el campo");
                continuar = false;
            }
            return continuar;
        }
        #endregion


        private void btnEliminarDosis_Click(object sender, EventArgs e)
        {


            var mensaje = "El registro será eliminado, ¿Desea continuar?";
            var respuesta = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                bool exito;
                if (idVacuna == 0)
                {
                    var msg = "Por favor seleccione un registro a eliminar";
                    MessageBox.Show(msg, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    var dvAccess = new DosisVacunaDataAccess();
                    var dva = new DosisVacunaV();
                    dva = dvAccess.DosisVacunaObtenerPorId(idVacuna); //Arroja directamente el registro que coincide con el id de examen para luego pasarle el objeto completo como parámetro al método actualizar
                    dva.Activo = false;
                    exito = dvAccess.DosisVacunaActualizar(dva);

                }

                if (exito)
                {
                    var message = "El registro ha sido eliminado con éxito";
                    MessageBox.Show(message);
                    Cargar_vacuna();
                }
                else
                {
                    var message = "Ha ocurrido un error. \nPor favor contacte a soporte técnico";
                    MessageBox.Show(message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                idVacuna = 0;

            }
        }

        private void tabExamenes_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var mensaje = "El registro será eliminado, ¿Desea continuar?";
            var respuesta = MessageBox.Show(mensaje, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                bool exito;
                if (examenID == 0)
                {
                    var msg = "Por favor seleccione un registro a eliminar";
                    MessageBox.Show(msg, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    var examenAccess = new ExamenDataAccess();
                    var examencito = new ExamenV();
                    examencito = examenAccess.ExamenObtenerPorId(examenID); //Arroja directamente el registro que coincide con el id de examen para luego pasarle el objeto completo como parámetro al método actualizar
                    examencito.Activo = false;
                    exito = examenAccess.ExamenActualizar(examencito);

                }

                if (exito)
                {
                    var message = "El registro ha sido eliminado con éxito";
                    MessageBox.Show(message);
                    LimpiarCamposExamenes();
                    CargarExamenPaciente();
                }
                else
                {
                    var message = "Ha ocurrido un error. \nPor favor contacte a soporte técnico";
                    MessageBox.Show(message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                examenID = 0;

            }
        }

        private void btnRestaurarDosisVacuna_Click(object sender, EventArgs e)
        {

            var form = new frmRestaurarDosisVacunas();
            form.ShowDialog(this);
            Cargar_vacuna();

        }

        private void cmbVacunaNom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxNombreExamen_TextChanged(object sender, EventArgs e)
        {
            ValidarTexto(tbxNombreExamen);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCedulaMadre_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblImc_Click(object sender, EventArgs e)
        {

        }

        private void lblEstatura_Click(object sender, EventArgs e)
        {

        }

        private void lblCentimetros_Click(object sender, EventArgs e)
        {

        }

        private void txtEstatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabAntecedentes_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmNuevaConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaConsulta_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cerrrar
        }


        #region antecedentes


        private void CargarAntecedentes()
        {


            AntecedentePersonalNegocio APN = new AntecedentePersonalNegocio();

            var exito = APN.VerificarRegistroAntecedente(DatosComunesConsulta.pacienteCargado.Id);

            if (exito == true)
            {

                var antecedentes = APN.AntecedenteObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);

                txtAlergias.Text = antecedentes.Alergias;
                txtTransfusiones.Text = antecedentes.Transfusion;
                txtSocial.Text = antecedentes.DesarrolloSocial;
                txtVivienda.Text = antecedentes.TipoVivienda;
                txtPadecimiento.Text = antecedentes.Padecimiento;
                txtEnfermedadCronica.Text = antecedentes.EnfermedadCronica;
                txtCirugias.Text = antecedentes.Cirugias;
                txtHospitalizacion.Text = antecedentes.Hospitalizacion;
                txtAlimentacion.Text = antecedentes.HabitoAlimentacion;
                txtHigiene.Text = antecedentes.HabitoHigiene;
            }

            
        }


        private void btnGuardarAntecedentes_Click(object sender, EventArgs e)
        {
            AntecedentePersonalV antecedente = new AntecedentePersonalV();

            antecedente.IDPaciente = DatosComunesConsulta.pacienteCargado.Id;
            antecedente.Padecimiento = txtPadecimiento.Text;
            antecedente.EnfermedadCronica = txtEnfermedadCronica.Text;
            antecedente.Alergias = txtAlergias.Text;
            antecedente.Cirugias = txtCirugias.Text;
            antecedente.Transfusion = txtTransfusiones.Text;
            antecedente.Hospitalizacion = txtHospitalizacion.Text;
            antecedente.TipoVivienda = txtVivienda.Text;
            antecedente.HabitoAlimentacion = txtTransfusiones.Text;
            antecedente.HabitoHigiene = txtHigiene.Text;
            antecedente.Activo = true;

            AntecedentePersonalNegocio APN = new AntecedentePersonalNegocio();

            var existe = APN.VerificarRegistroAntecedente(DatosComunesConsulta.pacienteCargado.Id);

            if (existe == true)
            {

                //actualiza
                var ant = APN.AntecedenteObtenerPorIdPaciente(DatosComunesConsulta.pacienteCargado.Id);

                antecedente.Id = ant.Id;
                APN.AntecedentePersonalActualizar(antecedente);
                MessageBox.Show("Antecedentes actualizados correctamente");
            }

            else {

                APN.AntecedentePersonalInsertar(antecedente);
                MessageBox.Show("Antecedentes registrados correctamente!");
            }

        }

        #endregion


        public void CargarDgvConsulta()
        {

            ConsultaNegocio CN = new ConsultaNegocio();

            var listaConsultas = CN.ConsultaObtenerPorIdExpedienteBit(DatosComunesConsulta.expediente.Id, true);
            // MessageBox.Show(listaConsultas[1].Peso.Value);
            dgvConsultaPaciente.DataSource = listaConsultas;
            dgvConsultaPaciente.Columns[0].Visible = false;
            dgvConsultaPaciente.Columns[1].Visible = false;
            dgvConsultaPaciente.Columns[2].Visible = false;
            dgvConsultaPaciente.Columns[4].Visible = false;
            dgvConsultaPaciente.Columns[10].Visible = false;
            dgvConsultaPaciente.Columns[11].Visible = false;
            dgvConsultaPaciente.Columns[12].Visible = false;
            dgvConsultaPaciente.Columns[13].Visible = false;
        }

            private void btnActualizarConsulta_Click(object sender, EventArgs e)
        {
            if (idConsulta == 0)
            {
                MessageBox.Show("Por favor escoja un registro a editar");
                return;
            }


            var respuesta = DialogResult.Yes;
            if (!(ValidarTexto(txtEstatura) && ValidarTexto(txtPeso) && ValidarTexto(txtPresionSistolica) &&
                ValidarTexto(txtTemperatura) && ValidarTexto(txtDiagnostico) && ValidarTexto(txtObservacionesGenerales)
                 && ValidarTexto(txtHEA)))
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
                somatometria.PresionSistolica = 0;
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

            
            somatometria.Id = idSomatometria;
            somatometria.IDConsulta = idConsulta;

            var consulta = new ConsultaV();
            consulta.IDExpediente = DatosComunesConsulta.expediente.Id;
            consulta.Diagnostico = txtDiagnostico.Text;
            consulta.Observaciones = txtObservacionesGenerales.Text;
          
            consulta.HistoriaActual = txtHEA.Text;
            consulta.Fecha = dpFechaConsulta.Value;
            consulta.Activo = true;
            consulta.Tratamiento = txtTratamiento.Text;
            
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
           // LimpiarDatos();
            CargarDgvConsulta();
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
               
                txtDiagnostico.Text = consulta.Diagnostico;

                txtHEA.Text = consulta.HistoriaActual;
                txtObservacionesGenerales.Text = consulta.Observaciones;
                txtTratamiento.Text = consulta.Tratamiento;
              



                // // examen físico
                txtPeso.Text = somatometria.Peso.ToString();
                txtEstatura.Text = somatometria.Estatura.ToString();
                txtPresionSistolica.Text = somatometria.PresionSistolica.ToString(); 
                txtPresionDiastolica.Text = somatometria.PresionDiastolica.ToString();
                txtTemperatura.Text = somatometria.Temperatura.ToString();
                txtFC.Text = somatometria.FrecuenciaCardiaca.ToString();
                txtFR.Text = somatometria.FrecuenciaRespiratoria.ToString();
              
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

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {

            bool exito;
            if (ValidarTexto(txtNombre1) && ValidarTexto(txtApellido1) &&
                ValidarTexto(txtCiudadNacimiento) && ValidarTexto(txtLugarNacimiento))
            {

                PacienteV paciente = new PacienteV();

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
                paciente.IDGrupoSanguineo = Convert.ToInt16(cmbGrupoSanguineo.SelectedValue);
                paciente.Direccion = txtDireccion.Text;
                paciente.EsNino = Convert.ToBoolean(cmbSexo.SelectedIndex);
                paciente.Religion = Convert.ToString(cmbReligion.SelectedItem);
                paciente.Origen = Convert.ToString(cmbOrigen.SelectedItem);
                paciente.Notas = txtNotas.Text;
                paciente.Id = DatosComunesConsulta.pacienteCargado.Id;


                exito = pacienteNegocio.PacienteActualizar(paciente);


                // CargarDatosPacienteTabGeneral();
                if (exito)
                {
                    MessageBox.Show("¡Datos actualizados correctamente!");
                }
                else
                {
                    MessageBox.Show("¡ERROR!");

                }
            }
        }

        private void btnGuardarExamen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxNombreExamen.Text))
            {
                MessageBox.Show("Hay campos que deben rellenarse");
            }
            else
            {
                if (pbExamen.Image == null)
                {


                    ExamenV imagenExamen = new ExamenV(); //Instancia de la tabla Examen


                    imagenExamen.IDExpediente = Convert.ToInt16(DatosComunesConsulta.expediente.Id);
                    imagenExamen.NombreImagen = tbxNombreExamen.Text;
                    imagenExamen.Notas = rbNotasExamen.Text;
                    imagenExamen.FechaQueSeRealizo = dtpFechaRealizacion.Value;
                    imagenExamen.FechaIngresoBD = DateTime.Today;
                    imagenExamen.Activo = true;

                    var examenNeg = new ExamenNegocio();
                    examenNeg.ExamenInsertar(imagenExamen);
                    CargarExamenPaciente();
                }
                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbExamen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //Ya no es necesario usar FileStream, pues provocaba dependencia directa con el label de la ruta, es decir, el label siempre debía estar lleno

                    ExamenV imagenExamen = new ExamenV(); //Instancia de la tabla Examen


                    imagenExamen.Imagen = ms.GetBuffer(); //Se le asigna la imagen seleccionada por el usuario
                    imagenExamen.IDExpediente = Convert.ToInt16(DatosComunesConsulta.expediente.Id);
                    imagenExamen.NombreImagen = tbxNombreExamen.Text;
                    imagenExamen.Notas = rbNotasExamen.Text;
                    imagenExamen.FechaQueSeRealizo = dtpFechaRealizacion.Value;
                    imagenExamen.FechaIngresoBD = DateTime.Today;
                    imagenExamen.Activo = true;

                    ValidarImagen vi = new ValidarImagen();

                    if (String.IsNullOrWhiteSpace(cadenita)) //Esto permite que el uso del lbl para la validación sea innecesario, además, es útil cuando el usuario desee modificar el registro, mas no la imagen
                                                             //En pocas palabras, si la variable está vacía, eso significa que no seleccione ninguna imagen, y por lo tanto no es necesario hacer alguna validación
                                                             //ya que la que está en pb es null (ya controlado), o bien si cumple con los parámetros   
                    {
                        var guardarImagen = new ExamenNegocio();
                        guardarImagen.ExamenInsertar(imagenExamen);
                        CargarExamenPaciente();
                    }

                    else
                    {
                        var validacion = vi.ValidarFormatoImagen(ms.Length / 1000, cadenita); //Le pasa como parámetros el tamaño del archivo y la ruta
                        if (validacion == true)
                        {
                            var guardarImagen = new ExamenNegocio();
                            guardarImagen.ExamenInsertar(imagenExamen);
                            CargarExamenPaciente();
                        }
                        else
                        {
                            MessageBox.Show("Es probable que la imagen seleccionada no se ajuste a los parámetros dado");
                        }

                    }

                }
            }
        }

        private void btnActualizarExamen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxNombreExamen.Text))
            {
                MessageBox.Show("Hay campos que deben rellenarse");
            }
            else
            {
                if (examenID == 0)
                {
                    MessageBox.Show("Debe seleccionar un registro!");
                }

                if (pbExamen.Image == null)
                {
                    ExamenV imagenExamen = new ExamenV(); //Instancia de la tabla Examen

                    imagenExamen.Id = examenID; //Obtiene el ID del examen seleccionado
                                                // imagenExamen.Imagen = ms.GetBuffer(); //Se le asigna la imagen seleccionada por el usuario
                    imagenExamen.IDExpediente = Convert.ToInt16(DatosComunesConsulta.expediente.Id);
                    imagenExamen.NombreImagen = tbxNombreExamen.Text;
                    imagenExamen.Notas = rbNotasExamen.Text;
                    imagenExamen.FechaQueSeRealizo = dtpFechaRealizacion.Value;
                    imagenExamen.FechaIngresoBD = DateTime.Today;
                    imagenExamen.Activo = true;

                    var examenNeg = new ExamenNegocio();
                    examenNeg.ExamenActualizar(imagenExamen);

                    LimpiarCamposExamenes();
                    CargarExamenPaciente();


                }

                else
                {

                    MemoryStream ms = new MemoryStream();
                    pbExamen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //Ya no es necesario usar FileStream, pues provocaba dependencia directa con el label de la ruta, es decir, el label siempre debía estar lleno

                    ExamenV imagenExamen = new ExamenV(); //Instancia de la tabla Examen

                    imagenExamen.Id = examenID; //Obtiene el ID del examen seleccionado
                    imagenExamen.Imagen = ms.GetBuffer(); //Se le asigna la imagen seleccionada por el usuario
                    imagenExamen.IDExpediente = Convert.ToInt16(DatosComunesConsulta.expediente.Id);
                    imagenExamen.NombreImagen = tbxNombreExamen.Text;
                    imagenExamen.Notas = rbNotasExamen.Text;
                    imagenExamen.FechaQueSeRealizo = dtpFechaRealizacion.Value;
                    imagenExamen.FechaIngresoBD = DateTime.Today;
                    imagenExamen.Activo = true;

                    ValidarImagen vi = new ValidarImagen();

                    if (String.IsNullOrWhiteSpace(cadenita)) //Esto permite que el uso del lbl para la validación sea innecesario, además, es útil cuando el usuario desee modificar el registro, mas no la imagen
                    {
                        var examenNeg = new ExamenNegocio();
                        examenNeg.ExamenActualizar(imagenExamen);
                        CargarExamenPaciente();
                    }

                    else
                    {
                        var validacion = vi.ValidarFormatoImagen(ms.Length / 1000, cadenita); //Le pasa como parámetros el tamaño del archivo y la ruta
                        if (validacion == true)
                        {
                            var examenNeg = new ExamenNegocio();
                            examenNeg.ExamenActualizar(imagenExamen);
                            CargarExamenPaciente();
                        }
                        else
                        {
                            MessageBox.Show("Es probable que la imagen seleccionada no se ajuste a los parámetros dado");
                        }

                    }

                }
            }
        }

        private void dgvConsultaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtFR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtPresionDiastolica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtPresionSistolica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtPesoNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtAlturaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtPerimetroCefalico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rbNotasExamen.Text = "";
            dtpFechaRealizacion.Value = DateTime.Now;
            tbxNombreExamen.Text = "";
            pbExamen.Image = null;

        }

        private void tabConsulta_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabConsulta.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabConsulta.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Microsoft Sans Serif", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void txtEdadGestacional_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txtPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }


}
//Para los problemas de repeticion de registros, se debe resetear la tabla, eliminar la vista del modelo, y volver a cargarla
//Las vistas se usan para que la visión al usuario sea mas coherente
