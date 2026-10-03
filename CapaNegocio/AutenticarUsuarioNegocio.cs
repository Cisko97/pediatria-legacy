using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
// using CapaEntidad;

namespace CapaNegocio
{
    public class AutenticarUsuarioNegocio
    {

        public bool ValidarUsuario(UsuarioV usuario) {

            UsuarioDataAccess UDA = new UsuarioDataAccess();

            return UDA.AutenticarUsuario(usuario);//se envía parámetro de tipo UsuarioV
        }

    }
}
