using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using CapaEntidad;
using CapaDato;

namespace CapaNegocio
{
    public class GrupoSanguineoNegocio
    {
        public List<GrupoSanguineoV> GrupoSanguineoObtenerTodos()
        {
            GrupoSanguineoDataAccess GSDA = new GrupoSanguineoDataAccess();

            return GSDA.GrupoSanguineoObtenerTodos();
        }
    }
}
