using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDato;
using CapaNegocio;
using CapaEntidad;

namespace AmbientePruebas
{
    [TestClass]
    public class PruebasUnitariasPacientes
    {
        //Esta prueba valida que el paciente seleccionado solo debe contar con un expediente asociado
        [TestMethod]
        public void VerificarUnicoExpediente()
        {
            //int idPaciente;
            //Console.WriteLine("Introduzca el id del paciente: ");
            
            ExpedienteNegocio EN = new ExpedienteNegocio();
            var resultado = EN.VerificarExpedienteObtenerPorIdPaciente(1);

            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void ValidarPacienteDuplicado()
        {
            PacienteV paciente = new PacienteV();
            paciente.Nombre1 = "David";
            paciente.Nombre2 = "Francisco";
            paciente.Apellido1 = "Bermúdez";
            paciente.Apellido2 = "López";
            paciente.FechaNacimiento = Convert.ToDateTime("26-05-1997");

            PacienteNegocio PN = new PacienteNegocio();
            var resultado = PN.VerificarPacienteDuplicado(paciente);

            Assert.IsTrue(resultado);


        }

        [TestMethod]
        public void ValidarPacienteDuplicadoLeo()
        {
            PacienteV paciente = new PacienteV();
            paciente.Nombre1 = "José";
            paciente.Nombre2 = "Martín";
            paciente.Apellido1 = "Smith";
            paciente.Apellido2 = "Jordan";
            paciente.FechaNacimiento = Convert.ToDateTime("2001-03-09");
           

            PacienteNegocio PN = new PacienteNegocio();
            var resultado = PN.VerificarPacienteDuplicado(paciente);

            Assert.IsTrue(resultado);
           // Assert.Inconclusive("Este Paciente ya existe");


        }
    }
}

