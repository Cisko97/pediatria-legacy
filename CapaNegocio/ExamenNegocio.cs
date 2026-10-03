using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
//using CapaEntidad;

namespace CapaNegocio
{
    public class ExamenNegocio
    {

        public bool ExamenInsertar(ExamenV examen)
        {
            ExamenDataAccess EDA = new ExamenDataAccess();
            return EDA.ExamenInsertar(examen);
        }

        public bool ExamenActualizar(ExamenV examen)
        {
            ExamenDataAccess EDA = new ExamenDataAccess();
            return EDA.ExamenActualizar(examen);
        }

        public bool ExamenEliminar(int idExamen)
        {
            ExamenDataAccess EDA = new ExamenDataAccess();
            return EDA.ExamenEliminar(idExamen);
        }


        public ExamenV ExamenObtenerPorId(int idExamenV)
        {
            ExamenDataAccess EDA = new ExamenDataAccess();
            return EDA.ExamenObtenerPorId(idExamenV);
        }

        public List<CargarExamenPersonalizadoV> CargarExamenObtenerPorBit(bool bit, int IdExpediente)
        {
            ExamenDataAccess EDA = new ExamenDataAccess();
            return EDA.CargarExamenObtenerPorBit(bit, IdExpediente);

        }
    }
}
