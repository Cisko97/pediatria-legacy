using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using CapaEntidad;
using CapaDato;

namespace CapaNegocio
{
    public class InformacionNacimientoNegocio
    {


        public bool InformacionNacimientoInsertar(InformacionNacimientoV nacimiento)
        {
            InformacionNacimientoDataAccess INDA = new InformacionNacimientoDataAccess();
            return INDA.InformacionNacimientoInsertar(nacimiento);
        }


        public bool InformacionNacimientoActualizar(InformacionNacimientoV nacimiento)
        {
            InformacionNacimientoDataAccess INDA = new InformacionNacimientoDataAccess();
            return INDA.InformacionNacimientoActualizar(nacimiento);

        }
        public InformacionNacimientoV NacimientoObtenerPorIdPaciente(int idPaciente)
        {

            InformacionNacimientoDataAccess INDA = new InformacionNacimientoDataAccess();

            //Recupera el objeto InformacionNacimientoV
            return INDA.NacimientoObtenerPorIdPaciente(idPaciente);
        }


        public bool VerificarRegistroNacimiento(int idPaciente) {

            InformacionNacimientoDataAccess INDA = new InformacionNacimientoDataAccess();

            return INDA.VerificarRegistroNacimiento(idPaciente);
        }
    }
}
