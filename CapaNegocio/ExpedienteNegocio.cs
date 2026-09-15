using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class ExpedienteNegocio
    {

        public ExpedienteV ExpedienteObtenerPorIdPaciente(int idPaciente)
        {

            ExpedienteDataAccess EDA = new ExpedienteDataAccess();

            //recupera los objetos de tipo ExpedienteV
            return EDA.ExpedienteObtenerPorIdPaciente(idPaciente);
        }


        public bool VerificarExpedienteObtenerPorIdPaciente(int idPaciente)
        {

            ExpedienteDataAccess EDA = new ExpedienteDataAccess();
            return EDA.VerificarExpedienteObtenerPorIdPaciente(idPaciente);

        }
    }
}
