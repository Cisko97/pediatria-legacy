using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class AntecedentePersonalDataAccess
    {


        public bool AntecedentePersonalInsertar(AntecedentePersonalV from)
        {
            using (var modelo
                = new ConsultorioPediatricoBDEntities())
            {
                modelo.AntecedentePersonalV.Add(from);
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }


        public bool AntecedentePersonalActualizar(AntecedentePersonalV from)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var entity = modelo.AntecedentePersonalV.SingleOrDefault(x => x.Id == from.Id);
                entity.Id = from.Id;
                entity.IDPaciente = from.IDPaciente;
                entity.Padecimiento = from.Padecimiento;
                entity.EnfermedadCronica = from.EnfermedadCronica;
                entity.Alergias = from.Alergias;
                entity.Cirugias = from.Cirugias;
                entity.Transfusion = from.Transfusion;
                entity.Hospitalizacion = from.Hospitalizacion;
                entity.TipoVivienda = from.TipoVivienda;
                entity.HabitoHigiene = from.HabitoHigiene;
                entity.HabitoAlimentacion = from.HabitoAlimentacion;
                entity.DesarrolloSocial = from.DesarrolloSocial;
              
                entity.Activo = from.Activo;
                int affectedRows = modelo.SaveChanges();
                return affectedRows != 0;
            }
        }


        public AntecedentePersonalV AntecedenteObtenerPorIdPaciente(int idPaciente)
        {
            using (var modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntity = modelo.AntecedentePersonalV.FirstOrDefault(e => e.IDPaciente == idPaciente);
                return selectedEntity;
            }

        }

        //verifica si el paciente admitido tiene info de nacimiento registrada
        public bool VerificarRegistroAntecedente(int idPaciente)
        {


            using (ConsultorioPediatricoBDEntities modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.AntecedentePersonalV.ToList(); //Se extraen o cargan todos los usuarios de la tabla Usuarios, para luego evaluar si alguno coincide con los 
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
