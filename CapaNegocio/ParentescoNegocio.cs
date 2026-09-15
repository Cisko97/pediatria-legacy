using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;


namespace CapaNegocio
{
    public class ParentescoNegocio
    {
        public List<ParentescoV> ParentescoObtenerTodos()
        {
            ParentescoDataAccess PDA = new ParentescoDataAccess();
            return PDA.ParentescoObtenerTodos().OrderBy(e => e.Nombre).ToList(); ;
        }

    }
}
