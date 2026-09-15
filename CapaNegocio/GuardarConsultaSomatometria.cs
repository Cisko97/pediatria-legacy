using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CapaEntidad;
using CapaDato;

namespace CapaNegocio
{
    public class GuardarConsultaSomatometria
    {
        public bool ConsultaSomatometriaAdd(ConsultaV consulta, SomatometriaV somatometria)
        {
            bool exito = false;
            using (var transaccion = new TransactionScope())
            {
                try
                {

                    var consultaAccess = new ConsultaDataAccess();
                    consultaAccess.ConsultaInsertar(consulta);

                    var somatometriaAcess = new SomatometriaDataAccess();
                    somatometria.IDConsulta = consulta.Id;
                    somatometriaAcess.SomatometriaInsertar(somatometria);

                    transaccion.Complete();

                    exito = true;
                    
                }
                catch (Exception)
                {
                    exito= false;
                    
                }

                return exito;

            }

        }

        //En caso de que quiera eliminar alguna consulta y no pretende restaurarla nunca xD
        public bool ConsultaSomatometriaEliminar(int idConsulta, int idSomatometria)
        {
            bool exito = false;
            using (var transaccion = new TransactionScope())
            {
                try
                {
                    //Primero va la tabla hija, luego se elimina la tabla padre.
                    var accesoSomatometria = new SomatometriaDataAccess();
                    accesoSomatometria.SomatometriaEliminar(idSomatometria);

                    var accesoConsulta = new ConsultaDataAccess();
                    accesoConsulta.ConsultaEliminar(idConsulta);

                    transaccion.Complete();
                    exito = true;

                }
                catch (NullReferenceException)
                {

                    exito = false;
                    throw;
                }
            }
            return exito;
        }


        public bool ConsultaSomatometriaActualizar(ConsultaV cons, SomatometriaV soma)
        {
            bool exito = false;
            

            using (var transaccion = new TransactionScope())
            {
                try
                {
                    var accesoConsulta = new ConsultaDataAccess();
                    accesoConsulta.ConsultaActualizar(cons);

                    var accesoSoma = new SomatometriaDataAccess();
                    accesoSoma.SomatometriaActualizar(soma);

                    transaccion.Complete();
                    exito = true;

                }
                catch (NullReferenceException)
                {
                    exito = false;
                    
                }
            }
            return exito;

        }
    }
}
