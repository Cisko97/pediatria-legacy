using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
     public class InformacionNacimientoDataAccess
    {
       
       public bool InformacionNacimientoInsertar(InformacionNacimientoV from)
       {
          using (var model = new ConsultorioPediatricoBDEntities() ){     
         model.InformacionNacimientoV.Add(from);
         int affectedRows = model.SaveChanges();
         return affectedRows != 0;
       }
      }     

       public bool InformacionNacimientoActualizar(InformacionNacimientoV from)
        {
         using (var model = new ConsultorioPediatricoBDEntities() ){     
         var entity = model.InformacionNacimientoV.SingleOrDefault(x=> x.Id == from.Id);
         entity.Id = from.Id;
         entity.IDPaciente = from.IDPaciente;
         entity.Peso = from.Peso;
         entity.Altura = from.Altura;
         entity.PerimetroCefalico = from.PerimetroCefalico;
         entity.FueCesarea = from.FueCesarea;
         entity.Posicion = from.Posicion;
         entity.Observaciones = from.Observaciones;
         entity.CircularCordon = from.CircularCordon;
         entity.MotivoCesarea = from.MotivoCesarea;
         entity.ComplicacionEmbarazo = from.ComplicacionEmbarazo;
         entity.EnfermedadEmbarazo = from.EnfermedadEmbarazo;
         entity.MedicacionEmbarazo = from.MedicacionEmbarazo;
         entity.EdadGestacional = from.EdadGestacional;

         int affectedRows = model.SaveChanges();
         return affectedRows != 0;
        }
      }     

       public bool InformacionNacimientoEliminar(int ID)
        {
          using (var model = new ConsultorioPediatricoBDEntities() ){     
         var entity = model.InformacionNacimientoV.SingleOrDefault(x=> x.Id == ID);
         model.InformacionNacimientoV.Remove(entity);
         int affectedRows = model.SaveChanges();
         return affectedRows != 0;
        }
      }     

       public InformacionNacimientoV  InformacionNacimientoObtenerPorId(int ID)
        {
          using (var model = new ConsultorioPediatricoBDEntities() ){     
         var selectedEntity = model.InformacionNacimientoV.SingleOrDefault(x=> x.Id== ID);
         return selectedEntity;
        }
      }     

       public List<InformacionNacimientoV> InformacionNacimientoObtenerTodos()
        {
          using (var model = new ConsultorioPediatricoBDEntities() )
          {
              var selectedEntities = model.InformacionNacimientoV.ToList();    
         return selectedEntities;
        }
        }
       public InformacionNacimientoV NacimientoObtenerPorIdPaciente(int idPaciente)
       {
           using (var modelo = new ConsultorioPediatricoBDEntities())
           {
               var selectedEntity = modelo.InformacionNacimientoV.FirstOrDefault(e => e.IDPaciente == idPaciente);
               return selectedEntity;
           }

       }


        //verifica si el paciente admitido tiene info de nacimiento registrada
        public bool VerificarRegistroNacimiento(int idPaciente)
        {


            using (ConsultorioPediatricoBDEntities modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.InformacionNacimientoV.ToList(); //Se extraen o cargan todos los usuarios de la tabla Usuarios, para luego evaluar si alguno coincide con los 
                                                                               //datos pasados como parámetros

                //declaramos la consulta en una variable, similar al sql client, pero directamente sin cmd o adapters :)
                var query = (from item in selectedEntities
                             where item.IDPaciente.Equals(idPaciente)
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

