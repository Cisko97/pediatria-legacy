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

namespace CapaPresentacion.Stats
{
    public partial class testEstadistica : Form
    {
        public testEstadistica()
        {
            InitializeComponent();
        }

        private void testEstadistica_Load(object sender, EventArgs e)
        {
            PacienteNegocio PN = new PacienteNegocio();
            var nacimientos = PN.PacienteObtenerNacimientoHospital();
            var nacimientosfuera = PN.PacienteObtenerNacimientoFueraHospital();

            for (var i = 0; i < nacimientos.Count; i++)
            {
                this.chart1.Series["EnHospital"].Points.AddXY(nacimientos[i].NacimientoHospital, nacimientos.Count);
                this.chart1.Series["FueraHospital"].Points.AddXY(nacimientosfuera[i].NacimientoHospital, nacimientosfuera.Count);
            }
            //foreach(Object obj in nacimientos)
            //{
            //    this.chart1.Series["Series1"].Points.AddXY(nacimientos[].NacimientoHospital);

                //}

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
