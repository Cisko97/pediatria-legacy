using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class ParentescoDataAccess
    {
        public List<ParentescoV> ParentescoObtenerTodos()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.ParentescoV.ToList();
                return selectedEntities;
            }
        }
    }
}
