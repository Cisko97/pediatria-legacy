using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDato
{
   public class UsuarioDataAccess
    {
            //Utilizaremos esta clase para validar el login de usuario
            //Se utilizará executequery().single para obtener un único registro, 
            //así como las sentencias linq para realizar las consultas

            //Sentencia LINQ
            public bool AutenticarUsuario(UsuarioV usuario)
            {
                using (ConsultorioPediatricoBDEntities modelo = new ConsultorioPediatricoBDEntities())
                {
                    var selectedEntities = modelo.UsuarioV.ToList(); //Se extraen o cargan todos los usuarios de la tabla Usuarios, para luego evaluar si alguno coincide con los 
                                                                      //datos pasados como parámetros

                    //declaramos la consulta en una variable, similar al sql client, pero directamente sin cmd o adapters :)
                    var query = (from item in selectedEntities
                                 where item.Username.Equals(usuario.Username.Trim()) &&
                                     item.Password.Equals(usuario.Password.Trim())
                                 select item);
                    if (query.Any())
                    {
                        return true; //Al menos una coincidencia, válido
                    }

                    else
                    {
                        return false; //Ninguna coincidencia, inválido
                    }

                    //Ahora solo lo mandamos a llamar en la capa de presentación

                }

            }
        
    }

    
}
