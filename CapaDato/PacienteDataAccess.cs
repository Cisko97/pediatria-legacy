using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;


namespace CapaDato
{
    public class PacienteDataAccess
    {


        public bool PacienteInsertar(PacienteV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                modelo.PacienteV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool PacienteActualizar(PacienteV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.PacienteV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.Nombre1 = from.Nombre1;
                entity.Nombre2 = from.Nombre2;
                entity.Apellido1 = from.Apellido1;
                entity.Apellido2 = from.Apellido2;
                entity.FechaNacimiento = from.FechaNacimiento;
                entity.NacimientoHospital = from.NacimientoHospital;
                entity.CiudadNacimiento = from.CiudadNacimiento;
                entity.LugarNacimiento = from.LugarNacimiento;
                entity.Direccion = from.Direccion;
                entity.IDGrupoSanguineo = from.IDGrupoSanguineo;
                entity.EsNino = from.EsNino;
                entity.NombrePadre = from.NombrePadre;
                entity.CedulaPadre = from.CedulaPadre;
                entity.NombreMadre = from.NombreMadre;
                entity.CedulaMadre = from.CedulaMadre;
                entity.Religion = from.Religion;
                entity.Activo = true;
                entity.Notas = from.Notas;
                entity.Origen = from.Origen;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;

            }
        }

        public bool PacienteEliminar(int idPacienteV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.PacienteV.SingleOrDefault(x => x.Id == idPacienteV);
                modelo.PacienteV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public PacienteV PacienteObtenerPorId(int idPacienteV)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.PacienteV.SingleOrDefault(x => x.Id == idPacienteV);
                return selectedEntity;
            }
        }

        //todos los pacientes nacidos en hospitales
        public List<PacienteV> PacienteObtenerNacimientoHospital()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.PacienteV.Where(x => x.NacimientoHospital == true).ToList();
                return selectedEntity;
            }
        }


        public List<PacienteV> PacienteObtenerNacimientoFueraHospital()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.PacienteV.Where(x => x.NacimientoHospital == false).ToList();
                return selectedEntity;
            }
        }

        public List<PacienteV> PacienteObtenerTodos()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
          {
              var selectedEntities = modelo.PacienteV.ToList();   
         return selectedEntities;
        }
        }

       

        public List<PacienteV> PacienteBusqueda(string nombre1, string nombre2, string apellido1, string apellido2)
        {

            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var pacientes = modelo.PacienteV;
                IQueryable<PacienteV> consulta = pacientes;
                if (!string.IsNullOrWhiteSpace(nombre1))
                {
                    consulta = pacientes.Where(x => x.Nombre1.Contains(nombre1));
                }

            }


            return null;
        }

        public void PacienteEliminarCascada(int idPaciente)
        {


            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {

                ermaga.PacienteEliminarCascada(idPaciente);


            }


        }

        public String ObtenerEdad(int idPaciente) {

            using (var model = new ConsultorioPediatricoBDEntities())
            {
               return model.ObtenerEdad(idPaciente).First();
            }
        }


        public bool VerificarPacienteDuplicado(PacienteV paciente)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.PacienteV.ToList(); //Se extraen o cargan todos los usuarios de la tabla Usuarios, para luego evaluar si alguno coincide con los 
                                                                  //datos pasados como parámetros

                //declaramos la consulta en una variable, similar al sql client, pero directamente sin cmd o adapters :)
                var query = (from item in selectedEntities
                             where item.Nombre1.Equals(paciente.Nombre1.Trim()) &&
                                 item.Apellido1.Equals(paciente.Apellido1.Trim()) &&
                                 item.Apellido2.Equals(paciente.Apellido2.Trim()) &&
                                 item.Nombre2.Equals(paciente.Nombre2.Trim()) && item.FechaNacimiento.Equals(paciente.FechaNacimiento)
                             select item);

                //Ejecutamos la query, y establecemos un retorno para determinar:

                //Si hay algún resultado a menos, se válida como correcto, de lo contrario se manda un falso

                if (query.Any())
                {
                    return true; //Al menos una coincidencia, válido
                }

                else
                {
                    return false; //Ninguna coincidencia, inválido
                }
            }
        }
    }
}
