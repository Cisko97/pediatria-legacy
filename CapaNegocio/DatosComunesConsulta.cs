using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// Using CapaEntidad;
using CapaDato;

namespace CapaNegocio
{
    public class DatosComunesConsulta
    {
       public static int IdPacienteNuevo;
       public static int IdExpedienteNuevo;


       //trabajabamos con las entidades de EF, pero ahora con las de la capa ENTIDAD (tienen la misma implementacion). 
       public static PacienteV pacienteCargado = new PacienteV();
       public static ExpedienteV expediente = new ExpedienteV();
       public static InformacionNacimientoV nacimiento = new InformacionNacimientoV();

       public static string resultadoMessageBox;
       public static string resultadoContinuar = "Continuar";
       public static string resultadoAgregarNuevo = "Nuevo";
        

    }
}
