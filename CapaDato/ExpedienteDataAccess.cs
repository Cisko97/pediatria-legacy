using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
   public class ExpedienteDataAccess
    {

        public bool ExpedienteInsertar(ExpedienteV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.ExpedienteV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool ExpedienteActualizar(ExpedienteV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.ExpedienteV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDPaciente = from.IDPaciente;
                entity.Descripcion = from.Descripcion;
                entity.FechaCreacion = from.FechaCreacion;
               
                entity.Activo = from.Activo;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool ExpedienteEliminar(int idExpedienteV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.ExpedienteV.SingleOrDefault(x => x.Id == idExpedienteV);
                modelo.ExpedienteV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public ExpedienteV ExpedienteObtenerPorId(int idExpedienteV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.ExpedienteV.SingleOrDefault(x => x.Id == idExpedienteV);
                return selectedEntity;
            }
        }

        public List<ExpedienteV> ExpedienteObtenerTodos()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
          {
              var selectedEntities = modelo.ExpedienteV.ToList();  
         return selectedEntities;
        }
      }

        public ExpedienteV ExpedienteObtenerPorIdPaciente(int idPaciente)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.ExpedienteV.FirstOrDefault(e => e.IDPaciente == idPaciente);
                return selectedEntity;
            }

        }

        public bool VerificarExpedienteObtenerPorIdPaciente(int idPaciente)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var cantidad = modelo.ExpedienteV.Where(e => e.IDPaciente == idPaciente).Count();

                if (cantidad == 1)
                {
                    return true;
                }
                else return false;
                
            }

        }


    }
}
