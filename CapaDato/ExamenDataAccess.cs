using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaDato
{
    public class ExamenDataAccess
    {

        public bool ExamenInsertar(ExamenV objetoQueViene)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())//Nombre de la BD
            {
                try
                {
                    modelo.ExamenV.Add(objetoQueViene); //Trae el modelo creado por el DataSet prueba
                    int affectedRows = modelo.SaveChanges();    //retorna las filas afectadas
                    return affectedRows != 0;
                }
                catch (DbEntityValidationException ex)
                {
                    // Retrieve the error messages as a list of strings.
                    var errorMessages = ex.EntityValidationErrors
                            .SelectMany(x => x.ValidationErrors)
                            .Select(x => x.ErrorMessage);

                    // Join the list to a single string.
                    var fullErrorMessage = string.Join("; ", errorMessages);
                    MessageBox.Show(fullErrorMessage);
                    // Combine the original exception message with the new one.

                    var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                    // Throw a new DbEntityValidationException with the improved exception message.
                    throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
                }
            }
        }

        public bool ExamenActualizar(ExamenV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.ExamenV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDExpediente = from.IDExpediente;
                entity.NombreImagen = from.NombreImagen;
                entity.FechaQueSeRealizo = from.FechaQueSeRealizo;
                entity.FechaIngresoBD = from.FechaIngresoBD;
                entity.Imagen = from.Imagen;
                entity.Notas = from.Notas;
                entity.Activo = from.Activo;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public bool ExamenEliminar(int idExamen)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.ExamenV.SingleOrDefault(x => x.Id == idExamen);
                modelo.ExamenV.Remove(entity);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }

        public ExamenV ExamenObtenerPorId(int idExamenV)
        {
            using (var svln = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = svln.ExamenV.SingleOrDefault(x => x.Id == idExamenV);
                return selectedEntity;
            }
        }

        public List<ExamenV> ExamenObtenerTodos()
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
          {
              var selectedEntities = modelo.ExamenV.ToList();
         return selectedEntities;
        }
      }     

        //No hacemos uso de la BD como tal para hacer la consulta. Sino una sentencia LINQ  
        public List<ExamenV> ObtenerListaExamen(int ID)
        {
            var modelito = new ConsultorioPediatricoBDEntities();

            //Con esta sentencia LINQ le indicamos que busque aquellos registros cuyo IDExpediente sea igual al parámetro indicado
            //y luego los posibles resultados son detallados en DGV a través de la propiedad List, la cual servirá
            //como DataSource según los resultados que arroje la consulta.
            //A diferencia del FillTabla, se debe usar WHERE para trabajar con varios resultados.
            //ToList almacena todos los resultados de la consulta
            var selectedEntity = modelito.ExamenV.Where(X => X.IDExpediente == ID).ToList(); //Para estos casos es mejor usar WHERE que single or default, ya que necesitamos el tolist (varios elementos)
            return selectedEntity;

        }

        public List<CargarExamenPersonalizadoV> ObtenerListaExamenPersonalizado(int ID)
        {
            var modelito = new ConsultorioPediatricoBDEntities();

            
            var selectedEntity = modelito.CargarExamenPersonalizadoV.Where(X => X.IDExpediente == ID).ToList(); //Para estos casos es mejor usar WHERE que single or default, ya que necesitamos el tolist (varios elementos)
            return selectedEntity;

        }

        public List<CargarExamenPersonalizadoV> CargarExamenObtenerPorBit(bool bit, int IdExpediente)
        {
            using (var examencito = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = examencito.CargarExamenPersonalizadoV.Where(er => er.Activo == bit && er.IDExpediente == IdExpediente).ToList();
                return selectedEntities;
            }

        }



    }
}
