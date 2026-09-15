using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
    public class CargarPacienteDataAccess
    {
        public List<CargarPacientesV> ObtenerTodos()
        {

            using (ConsultorioPediatricoBDEntities modelo = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = modelo.CargarPacientesV.ToList();
                return selectedEntities;
            }

        }

        public List<CargarPacientesV> ObtenerPorFiltro(String categoria, String texto)
        { 
           
            
              
            using (ConsultorioPediatricoBDEntities modelo = new ConsultorioPediatricoBDEntities())
            {
                 var q = (dynamic)null;
                var selectedEntities = modelo.CargarPacientesV.ToList(); //Permite obtener todos los registros de la tabla de exámenes sin filtro alguno

               
                    //Verificar cuál de las categorías del combobox fueron seleccionadas
                    switch (categoria)
                    {
                        //Sentencia linq que permite obtener los resultados que coincidan con el primer nombre, especificado en el textbox "Texto"
                        //Lo particular de esto, es que evalua todos los datos obtenidos de selectedEntities, para poder
                        //seleccionar solamente aquellos que cumplan con la condición where correspondiente al case
                        case "Primer Nombre":
                            q = (from item in selectedEntities
                                 where item.Nombre.ToLower().Contains(texto.ToLower().Trim())
                                 select item).ToList<CargarPacientesV>();
                            break;

                        case "Segundo Nombre":
                            q = (from item in selectedEntities
                                 //No diferenciar entre mayusculas y minusculas, y espacios
                                 where (item.Segundo_Nombre != null && item.Segundo_Nombre.ToLower().Contains(texto.ToLower().Trim()))  //Permite manejar valores nulos para los segundos apellidos
                                 select item).ToList<CargarPacientesV>();
                            break;

                        case "Primer Apellido":
                            q = (from item in selectedEntities
                                 where (item.Apellido.ToLower().Contains(texto.ToLower().Trim()) && item.Apellido.ToLower() != null)
                                 select item).ToList<CargarPacientesV>();
                            break;

                        case "Segundo Apellido":
                            q = (from item in selectedEntities
                                 where (item.Segundo_Apellido != null && item.Segundo_Apellido.ToLower().Contains(texto.ToLower().Trim())) 
                                 select item).ToList<CargarPacientesV>();
                            break;

                        case "Búsqueda por todo":
                            q = (from item in selectedEntities
                                 where (item.Id != null && item.Id.ToString().Contains(texto.ToLower().Trim())) || (item.Segundo_Nombre != null && item.Segundo_Nombre.ToLower().Contains(texto.ToLower().Trim())) ||
                                       (item.Apellido != null && item.Apellido.ToString().Contains(texto.ToLower().Trim())) || (item.Segundo_Apellido != null && item.Segundo_Apellido.ToLower().Contains(texto.ToLower().Trim())) ||
                                       (item.Tipo_de_Sangre != null && item.Tipo_de_Sangre.ToLower().Contains(texto.ToLower().Trim())) || (item.F__Nacimiento != null && item.F__Nacimiento.ToString().Contains(texto.ToLower().Trim())) ||
                                       (item.Ultima_Consulta != null && item.Ultima_Consulta.ToString().Contains(texto.ToLower().Trim())) || (item.Nombre != null && item.Nombre.ToLower().Contains(texto.ToLower().Trim())) 
                                 select item).ToList<CargarPacientesV>(); 
                            break;

                }
             
              return q; //retorna el item (registro o registros) que coincidan con el tipo de filtro realizado
            }
        }
        public List<CargarPacientesV> PacienteObtenerPorBit(bool bit)
        {
            using (var ermaga = new ConsultorioPediatricoBDEntities())
            {
                var selectedEntities = ermaga.CargarPacientesV.Where(er => er.Activo == bit).ToList();
                return selectedEntities;

            }

        }




    }
}
