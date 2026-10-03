using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
// using CapaEntidad;

namespace CapaNegocio
{
    public class VacunaNegocio
    {

        public bool VacunaInsertar(VacunaV vacuna)
        {
            VacunaDataAccess VDA = new VacunaDataAccess();
            return VDA.VacunaInsertar(vacuna);
        }

        public bool VacunaActualizar(VacunaV vacuna)
        {
            VacunaDataAccess VDA = new VacunaDataAccess();
            return VDA.VacunaActualizar(vacuna);
        }


        public List<VacunaV> VacunaObtenerTodos()
        {
            VacunaDataAccess VDA = new VacunaDataAccess();
            return VDA.VacunaObtenerTodos();

        }

    }
}