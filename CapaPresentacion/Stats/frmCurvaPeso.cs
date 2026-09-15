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

namespace CapaPresentacion.Stats
{
    public partial class frmCurvaPeso : Form
    {
        public frmCurvaPeso()
        {
            InitializeComponent();
        }

        private void frmCurvaPeso_Load(object sender, EventArgs e)
        {

            ConsultaNegocio CN = new ConsultaNegocio();

            var consultas = CN.ConsultaPersonalizadaPorIdExpediente(3);
            for (var i = 0; i < consultas.Count; i++)
            {
                this.chart1.Series["Peso"].Points.AddXY(consultas[i].Fecha.Value.Year, consultas[i].Peso);
                
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
