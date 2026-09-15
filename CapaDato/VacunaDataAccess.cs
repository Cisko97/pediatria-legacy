using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class VacunaDataAccess
    {

        public bool VacunaInsertar(VacunaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.VacunaV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool VacunaActualizar(VacunaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.VacunaV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.Nombre = from.Nombre;
                entity.NumeroDosis = from.NumeroDosis;
                entity.Observacion = from.Observacion;
                entity.Activo = from.Activo;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool VacunaEliminar(int idVacunaV)
        {

            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.VacunaV.SingleOrDefault(x => x.Id == idVacunaV);
                modelo.VacunaV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public VacunaV VacunaObtenerPorId(int idVacunaV)
        {
            using (var modelo
                = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.VacunaV.SingleOrDefault(x => x.Id == idVacunaV);
                return selectedEntity;
            }
        }

        public List<VacunaV> VacunaObtenerTodos()
        {
          using (var modelo = new ConsultorioPediatricoBDEntities() )
          {
              var selectedEntities = modelo.VacunaV.ToList();  
         return selectedEntities;
        }

      }

        //Obtener las vacunas con una vista de campos personalizados
        public List<CargarDosisVacunaPersonalizadaV> ObtenerDosisVacunaPersonalizada(int Id)
        {

            var modelito = new ConsultorioPediatricoBDEntities();

            var selectedEntity = modelito.CargarDosisVacunaPersonalizadaV.Where(x => x.IDExpediente == Id).ToList(); //Para estos casos es mejor usar WHERE que single or default, ya que necesitamos el tolist (varios elementos)
            return selectedEntity;

        }

        
    }
}
