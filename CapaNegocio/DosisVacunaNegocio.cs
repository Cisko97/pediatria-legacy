using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
//using CapaEntidad;

namespace CapaNegocio
{
    public class DosisVacunaNegocio
    {

        public bool DosisVacunaInsertar(DosisVacunaV dosis)
        {
            DosisVacunaDataAccess DVDA = new DosisVacunaDataAccess();
            return DVDA.DosisVacunaInsertar(dosis);
        }


        public bool DosisVacunaActualizar(DosisVacunaV  dosis)
        {

            DosisVacunaDataAccess DVDA = new DosisVacunaDataAccess();
            return DVDA.DosisVacunaActualizar(dosis);
        }


        public List<CargarDosisVacunaPersonalizadaV> CargarDosisPorBit(bool bit, int IdExpediente)
        {
            DosisVacunaDataAccess DVDA = new DosisVacunaDataAccess();
            return DVDA.CargarDosisPorBit(bit, IdExpediente);
        }
    }
}
