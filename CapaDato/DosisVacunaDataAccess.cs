using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
   public class DosisVacunaDataAccess
    {

        public bool DosisVacunaInsertar(DosisVacunaV from)
        {
            using (var modelo
                = new ConsultorioPediatricoBDEntities())
            {
                modelo.DosisVacunaV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool DosisVacunaActualizar(DosisVacunaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.DosisVacunaV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDExpediente = from.IDExpediente;
                entity.NumeroDosis = from.NumeroDosis;
                entity.IDVacuna = from.IDVacuna;
                entity.FechaAplicacion = from.FechaAplicacion;
                entity.Notas = from.Notas;
                entity.enConsultorio = from.enConsultorio;

                entity.Activo = from.Activo;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool DosisVacunaEliminar(int idDosisVacunaV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.DosisVacunaV.SingleOrDefault(x => x.Id == idDosisVacunaV);
                modelo.DosisVacunaV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public DosisVacunaV DosisVacunaObtenerPorId(int idDosisVacunaV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.DosisVacunaV.SingleOrDefault(x => x.Id == idDosisVacunaV);
                return selectedEntity;
            }
        }

        public List<DosisVacunaV> DosisVacunaObtenerTodos()
        {
          using (var modelo = new ConsultorioPediatricoBDEntities() )
          {
              var selectedEntities = modelo.DosisVacunaV.ToList();    
         return selectedEntities;
        }
      }


        public List<CargarDosisVacunaPersonalizadaV> CargarDosisPorBit(bool bit, int IdExpediente)
        {
            using (var examencito = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = examencito.CargarDosisVacunaPersonalizadaV.Where(er => er.Activo == bit && er.IDExpediente == IdExpediente).ToList();
                return selectedEntities;
            }

        }
        
    }
}
