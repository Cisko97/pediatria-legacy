using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
   public class InformacionFamiliarDataAccess
    {

        public bool InformacionFamiliarInsertar(InformacionFamiliarV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.InformacionFamiliarV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool InformacionFamiliarActualizar(InformacionFamiliarV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.InformacionFamiliarV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.Nombre = from.Nombre;
                entity.IDPaciente = from.IDPaciente; //id del paciente cargado va a la tabla puente
                entity.IDParentesco = from.IDParentesco;
                entity.TelContacto = from.TelContacto;    
                entity.Observaciones = from.Observaciones;
                entity.Activo = from.Activo;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool InformacionFamiliarEliminar(int idInformacionFamiliarV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.InformacionFamiliarV.SingleOrDefault(x => x.Id == idInformacionFamiliarV);
                modelo.InformacionFamiliarV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public InformacionFamiliarV InformacionFamiliarObtenerPorId(int idInformacionFamiliarV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
             
                var selectedEntity = modelo.InformacionFamiliarV.SingleOrDefault(x => x.Id == idInformacionFamiliarV);
                return selectedEntity;
            }
        }

        public List<InformacionFamiliarV> InformacionFamiliarObtenerTodos()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
          {
              var selectedEntities = modelo.InformacionFamiliarV.ToList();  
         return selectedEntities;
        }



      }

        public List<CargarInformacionFamiliarV> CargarInformacionFamiliarObtenerTodos()
        {
            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = ermaga.CargarInformacionFamiliarV.ToList();
                return selectedEntities;
            }

        }

        //Obtiene los registros en base al valor del bit que se le pase como parámetro, por tanto, si obtiene
        //false, les muestra solo los inactivos, si le pasa true, les muestra solo los activo
        public List<CargarInformacionFamiliarV> CargarInformacionFamiliarObtenerPorBit(bool bit, int idPaciente)
        {
            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = ermaga.CargarInformacionFamiliarV.Where(er => er.Activo == bit && er.IdPaciente == idPaciente).ToList();
                return selectedEntities;
            }

        }


        
    }
}
