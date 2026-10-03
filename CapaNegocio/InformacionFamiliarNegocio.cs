using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
//using CapaEntidad;

namespace CapaNegocio
{
    public class InformacionFamiliarNegocio
    {

        public bool InformacionFamiliarActualizar(InformacionFamiliarV from)
        {
            InformacionFamiliarDataAccess IFDA = new InformacionFamiliarDataAccess();
            return IFDA.InformacionFamiliarActualizar(from);
        }

        public InformacionFamiliarV InformacionFamiliarObtenerPorId(int idInformacionFamiliarV)
        {
            InformacionFamiliarDataAccess IFDA = new InformacionFamiliarDataAccess();
            return IFDA.InformacionFamiliarObtenerPorId(idInformacionFamiliarV);
        }

        public List<CargarInformacionFamiliarV> CargarInformacionFamiliarObtenerPorBit(bool bit, int idPaciente)
        {

            InformacionFamiliarDataAccess IFDA = new InformacionFamiliarDataAccess();
            return IFDA.CargarInformacionFamiliarObtenerPorBit(bit, idPaciente);
        }
    }
}
