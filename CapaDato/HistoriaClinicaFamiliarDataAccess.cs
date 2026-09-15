using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class HistoriaClinicaFamiliarDataAccess
    {

        public bool HistoriaClinicaFamiliarInsertar(HistoriaClinicaFamiliarV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.HistoriaClinicaFamiliarV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool HistoriaClinicaFamiliarActualizar(HistoriaClinicaFamiliarV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.HistoriaClinicaFamiliarV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDInformacionFamiliar = from.IDInformacionFamiliar;
                entity.ObservacionesMedicas = from.ObservacionesMedicas;
                entity.IDGrupoSanguineo = from.IDGrupoSanguineo;
                
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool HistoriaClinicaFamiliarEliminar(int idHistoriaClinicaFamiliarV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.HistoriaClinicaFamiliarV.SingleOrDefault(x => x.Id == idHistoriaClinicaFamiliarV);
                modelo.HistoriaClinicaFamiliarV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public HistoriaClinicaFamiliarV HistoriaClinicaFamiliarObtenerPorId(int idHistoriaClinicaFamiliarV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.HistoriaClinicaFamiliarV.SingleOrDefault(x => x.Id == idHistoriaClinicaFamiliarV);
                return selectedEntity;
            }
        }

        public List<HistoriaClinicaFamiliarV> HistoriaClinicaFamiliarObtenerTodos()
        {
          using (var modelo = new ConsultorioPediatricoBDEntities() )
          {
              var selectedEntities = modelo.HistoriaClinicaFamiliarV.ToList();   
         return selectedEntities;
        }


      }

        
    }
}
