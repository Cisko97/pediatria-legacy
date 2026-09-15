using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDato
{
    public class GrupoSanguineoDataAccess
    {


        public bool GrupoSanguineoInsertar(GrupoSanguineoV from)
        {
            using (var svln = new ConsultorioPediatricoBDEntities())
            {
                svln.GrupoSanguineoV.Add(from);
                int affectedRows = svln.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool GrupoSanguineoActualizar(GrupoSanguineoV from)
        {
            using (var model = new ConsultorioPediatricoBDEntities())
            {
                var entity = model.GrupoSanguineoV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.NombreGrupo = from.NombreGrupo;
                entity.Notas = from.Notas;
                int affectedRows = model.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool GrupoSanguineoEliminar(int idGrupoSanguineoV)
        {
            using (var model = new ConsultorioPediatricoBDEntities())
            {
                var entity = model.GrupoSanguineoV.SingleOrDefault(x => x.Id  == idGrupoSanguineoV);
                model.GrupoSanguineoV.Remove(entity);
                int affectedRows = model.SaveChanges();
                return affectedRows != 0;
            }
        }

        public GrupoSanguineoV GrupoSanguineoObtenerPorId(int idGrupoSanguineoV)
        {
            using (var svln = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = svln.GrupoSanguineoV.SingleOrDefault(x => x.Id  == idGrupoSanguineoV);
                return selectedEntity;
            }
        }

        public List<GrupoSanguineoV> GrupoSanguineoObtenerTodos()
        {
          using (var svln = new ConsultorioPediatricoBDEntities() )
          {
              var selectedEntities = svln.GrupoSanguineoV.ToList();   
         return selectedEntities;
        }
      }
       
    }
}
