using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CapaDato;
using CapaEntidad;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class InformacionFamiliarHistorialClinico
    {
        //Se realiza una transaccion que permite el almacenamiento de un mismo formulario en dos tablas distintas
        //pero con registros relacionados mediante un id foráneo (idinfofamiliar)
        //Se mandan a guardar en ambas tablas, pero se deja indicado además. que el valor que tomará el id foráneo
        //"idinfofamiliar" de la tabla hcf, será el id que se genere, cuando el registro de info familiar esté creado,
        //Considerando que este será el primero en registrarse en la bd, para evitar los errores de consistencia.
        public bool InfoFamiliarHistorialClinico(InformacionFamiliarV infoFamiliar, HistoriaClinicaFamiliarV historialClinico)
        {
            using (var transaccion = new TransactionScope())
            {
                bool exito = false;
                try
                {


                    try
                    {
                        var informacionFamiliarAccess = new InformacionFamiliarDataAccess();
                        informacionFamiliarAccess.InformacionFamiliarInsertar(infoFamiliar);

                        historialClinico.IDInformacionFamiliar = infoFamiliar.Id;

                        var historialClinicoAccess = new HistoriaClinicaFamiliarDataAccess();
                        historialClinicoAccess.HistoriaClinicaFamiliarInsertar(historialClinico);



                        transaccion.Complete();

                        exito = true;
                    }
                     catch (Exception ex) {
                        MessageBox.Show(ex.InnerException.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        exito = false;
                    }
                    
                }
                catch (Exception ex)
                {
                    exito= false;
                    MessageBox.Show(ex.ToString());
                }

                return exito;

            }

        }

        public bool InformacionFamiliarHistorialClinicoEditar(InformacionFamiliarV info, HistoriaClinicaFamiliarV historia)
        {
            using (var transaccion = new TransactionScope())
            {
                bool ermaga = false;
                try
                {
                    
                    var informacionFamiliarAccess = new InformacionFamiliarDataAccess();
                    informacionFamiliarAccess.InformacionFamiliarActualizar(info);

                    

                    var historialClinicoAccess = new HistoriaClinicaFamiliarDataAccess();
                    historialClinicoAccess.HistoriaClinicaFamiliarActualizar(historia);
                    
                    transaccion.Complete();

                    ermaga = true;

                }
                catch (Exception ex)
                {
                    ermaga = false;
                    MessageBox.Show(ex.ToString());
                }

                return ermaga;

            }

        }

        public bool InformacionFamiliarHistorialClinicoEliminar(int idInfo, int idHistoria)
        {

            bool exito=false;
            try
            {

            
            using (var transaccion = new TransactionScope())
            {
                
                var historiaAccess = new HistoriaClinicaFamiliarDataAccess();
                historiaAccess.HistoriaClinicaFamiliarEliminar(idHistoria);

                var familiarAccess = new InformacionFamiliarDataAccess();
                familiarAccess.InformacionFamiliarEliminar(idInfo);

                transaccion.Complete();
                exito = true;

            }
            }
            catch (EntityCommandExecutionException e)
            {
                MessageBox.Show(e.InnerException.Message);
                exito = false;
            }
            return exito;
        }

        
    }
}

