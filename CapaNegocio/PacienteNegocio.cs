using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
//using CapaEntidad;
using CapaDato;


namespace CapaNegocio
{
    public class PacienteNegocio
    {

        public bool PacienteExpedienteAdd(PacienteV paciente, ExpedienteV expediente)
        {

            bool exito = true;
            using (var transaccion = new TransactionScope())
            {
                try
                {

                    PacienteDataAccess PDA = new PacienteDataAccess();
                    PDA.PacienteInsertar(paciente);


                    
                    //Datos del expediente
                    
                    
                    ExpedienteDataAccess EDA = new ExpedienteDataAccess();
                    expediente.IDPaciente = paciente.Id;
                    EDA.ExpedienteInsertar(expediente);


                    transaccion.Complete();


                }

                catch (Exception ex)
                {

                  
                    
                }

            }
            return exito;
        }


        public bool PacienteActualizar(PacienteV paciente)
        {
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.PacienteActualizar(paciente);          
        }
        

        public void PacienteElimiarCascada(int idPaciente)
        {
            PacienteDataAccess PDA = new PacienteDataAccess();

            PDA.PacienteEliminarCascada(idPaciente);
            
        }

        public String ObtenerEdad(int idPaciente)
        {
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.ObtenerEdad(idPaciente);
        }

        public List<PacienteV> PacienteObtenerTodos()
        {
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.PacienteObtenerTodos();
        }

        public PacienteV PacienteObtenerPorId(int idPaciente)
        {
            //por cuestion de optimizacion, usamos el V en la capa de presentacion
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.PacienteObtenerPorId(idPaciente);
        }

        public bool VerificarPacienteDuplicado(PacienteV paciente)
        {
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.VerificarPacienteDuplicado(paciente);
        }
        public List<CargarPacientesV> PacienteObtenerPorBit(bool bit)
        {

            CargarPacienteDataAccess CPDA = new CargarPacienteDataAccess();
            return CPDA.PacienteObtenerPorBit(bit);
        }

        public List<PacienteV> PacienteObtenerNacimientoHospital()
        {
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.PacienteObtenerNacimientoHospital();
        }

        public List<PacienteV> PacienteObtenerNacimientoFueraHospital()
        {
            PacienteDataAccess PDA = new PacienteDataAccess();
            return PDA.PacienteObtenerNacimientoFueraHospital();
        }
    }
}
