using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CapaDato;
using CapaEntidad;

namespace AmbientePruebas
{
    [TestClass]
    public class PruebasUnitariasLogin
    {
        [TestMethod]
        public void AutenticarUsuario()
        {
            UsuarioV usuario = new UsuarioV();

            usuario.Username = "castanic";
            usuario.Password = "123";

            UsuarioDataAccess UDA = new UsuarioDataAccess();

            var resultado = UDA.AutenticarUsuario(usuario);
            Assert.IsTrue(resultado);
        }
    }
}
