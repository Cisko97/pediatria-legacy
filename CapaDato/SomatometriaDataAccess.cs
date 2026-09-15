using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class SomatometriaDataAccess
    {

        public bool SomatometriaInsertar(SomatometriaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.SomatometriaV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool SomatometriaActualizar(SomatometriaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.SomatometriaV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDConsulta = from.IDConsulta;
                entity.Peso = from.Peso;
                entity.Estatura = from.Estatura;
                entity.PerimetroCefalico = from.PerimetroCefalico;
                entity.PerimetroAbdominal = from.PerimetroAbdominal;
                entity.PerimetroToracico = from.PerimetroToracico;
            
                entity.FrecuenciaCardiaca = from.FrecuenciaCardiaca;
                entity.FrecuenciaRespiratoria = from.FrecuenciaRespiratoria;
                entity.PresionSistolica = from.PresionSistolica;
                entity.PresionDiastolica = from.PresionDiastolica;
                entity.Temperatura = from.Temperatura;
               
                entity.Exploratorio = from.Exploratorio;

               
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool SomatometriaEliminar(int idSomatometriaV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.SomatometriaV.SingleOrDefault(x => x.Id == idSomatometriaV);
                modelo.SomatometriaV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public SomatometriaV SomatometriaObtenerPorId(int idSomatometriaV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.SomatometriaV.SingleOrDefault(x => x.Id == idSomatometriaV);
                return selectedEntity;
            }
        }

        public List<SomatometriaV> SomatometriaObtenerTodos()
        {
          using (var modelo = new ConsultorioPediatricoBDEntities() )
          {
              var selectedEntities = modelo.SomatometriaV.ToList();
         return selectedEntities;
        }
      }

        public SomatometriaV SomatometriaObtenerPorIdConsulta(int id)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities() )
          {
                var selectedEntities = modelo.SomatometriaV.FirstOrDefault(ermaga=> ermaga.IDConsulta==id);
                return selectedEntities;

        }

        
    }
    
    }
}
