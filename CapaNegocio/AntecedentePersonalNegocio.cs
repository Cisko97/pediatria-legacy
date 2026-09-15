using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDato;

namespace CapaNegocio
{

    public class AntecedentePersonalNegocio
    {
        public bool AntecedentePersonalInsertar(AntecedentePersonalV from)
        {
            AntecedentePersonalDataAccess APDA = new AntecedentePersonalDataAccess();

            return APDA.AntecedentePersonalInsertar(from);
            
        }


        public bool AntecedentePersonalActualizar(AntecedentePersonalV from)
        {
            AntecedentePersonalDataAccess APDA = new AntecedentePersonalDataAccess();

            return APDA.AntecedentePersonalActualizar(from);

        }

        public AntecedentePersonalV AntecedenteObtenerPorIdPaciente(int idPaciente)
        {
            AntecedentePersonalDataAccess APDA = new AntecedentePersonalDataAccess();

            return APDA.AntecedenteObtenerPorIdPaciente(idPaciente);
        }

        public bool VerificarRegistroAntecedente(int idPaciente)
        {

            AntecedentePersonalDataAccess apda = new AntecedentePersonalDataAccess();

            return apda.VerificarRegistroAntecedente(idPaciente);
        }
    }

    

}
