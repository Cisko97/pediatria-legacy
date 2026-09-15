using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class ConsultaNegocio
    {
        public List<CargarConsultaV> ConsultaObtenerPorIdExpedienteBit(int idExpediente, bool bit)
        {
            ConsultaDataAccess CDA = new ConsultaDataAccess();
            return CDA.ConsultaObtenerPorIdExpedienteBit(idExpediente, bit);

        }

        public List<CargarConsultaV> ConsultaPersonalizadaPorIdExpediente(int idExpediente)
        {
            ConsultaDataAccess CDA = new ConsultaDataAccess();
            return CDA.ConsultaPersonalizadaPorIdExpediente(idExpediente);

        }

        public List<CargarConsultaV> ConsultaPersonalizadaPorDiagnostico(String diagnostico)
        {
            ConsultaDataAccess CDA = new ConsultaDataAccess();
            return CDA.ConsultaPersonalizadaPorDiagnostico(diagnostico);

        }

        public List<CargarConsultaV> ConsultaPersonalizadaTodas()
        {
            ConsultaDataAccess CDA = new ConsultaDataAccess();
            return CDA.ConsultaPersonalizadaTodas();

        }

        public String ObtenerEdadConsulta(int idPaciente, DateTime fechaConsulta) {
            ConsultaDataAccess CDA = new ConsultaDataAccess();

            return CDA.ObtenerEdadConsulta(idPaciente, fechaConsulta);

        }


        public List<ConsultaV> ConsultaObtenerPorIdExpediente(int Id)
        {
            ConsultaDataAccess CDA = new ConsultaDataAccess();

            return CDA.ConsultaObtenerPorIdExpediente(Id);

        }

        public ConsultaV ConsultaObtenerPorId(int idConsulta)
        {
            ConsultaDataAccess CDA = new ConsultaDataAccess();
            return CDA.ConsultaObtenerPorId(idConsulta);
        }

    }
}
