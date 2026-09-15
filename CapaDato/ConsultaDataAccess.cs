using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class ConsultaDataAccess
    {
        //Hola
        public bool ConsultaInsertar(ConsultaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.ConsultaV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool ConsultaActualizar(ConsultaV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.ConsultaV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDExpediente = from.IDExpediente;
                entity.Diagnostico = from.Diagnostico;
                entity.Observaciones = from.Observaciones;
                entity.HistoriaActual = from.HistoriaActual;
                entity.Fecha = from.Fecha;
             
                entity.Tratamiento = from.Tratamiento;
                
                entity.IDMedico = from.IDMedico;
                entity.Activo = from.Activo;

                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool ConsultaEliminar(int idConsulta)
        {

            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.VacunaV.SingleOrDefault(x => x.Id == idConsulta);
                modelo.VacunaV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }
       

        public ConsultaV ConsultaObtenerPorId(int idConsulta)
        {
            using (var modelo
                = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.ConsultaV.SingleOrDefault(x => x.Id == idConsulta);
                return selectedEntity;
            }
        }

        public List<ConsultaV> ConsultaObtenerTodos()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.ConsultaV.ToList();
                return selectedEntities;
            }
        }

        public List<CargarConsultaV> ConsultaPersonalizadaTodas()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.CargarConsultaV.ToList();
                return selectedEntities;
            }
        }
        


        public List<ConsultaV> ConsultaObtenerPorIdExpediente(int Id)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.ConsultaV.Where(x => x.IDExpediente == Id).ToList();
                return selectedEntities;
            }

        }

        public List<CargarConsultaV> ConsultaObtenerPorIdExpedienteBit(int idExpediente, bool bit)
        {
            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities =
                    ermaga.CargarConsultaV.Where(er => er.Activo == bit && er.IDExpediente == idExpediente).ToList();
                return selectedEntities;

            }

        }

        public List<CargarConsultaV> ConsultaPersonalizadaPorIdExpediente(int idExpediente)
        {
            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities =
                    ermaga.CargarConsultaV.Where(er => er.IDExpediente == idExpediente).ToList();
                return selectedEntities;

            }

        }

        public List<CargarConsultaV> ConsultaPersonalizadaPorDiagnostico(String diagnostico)
        {
            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities =
                    ermaga.CargarConsultaV.Where(er => er.Diagnostico == diagnostico).ToList();
                return selectedEntities;

            }

        }

        public String ObtenerEdadConsulta(int idPaciente, DateTime fechaConsulta)
        {

            using (var model = new ConsultorioPediatricoBDEntities())
            {
                return model.ObtenerEdadConsulta(idPaciente, fechaConsulta).First();
            }
        }
    }
}
