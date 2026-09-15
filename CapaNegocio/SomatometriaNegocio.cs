using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class SomatometriaNegocio
    {
        public SomatometriaV SomatometriaObtenerPorIdConsulta(int id)
        {
            SomatometriaDataAccess SDA = new SomatometriaDataAccess();
            return SDA.SomatometriaObtenerPorIdConsulta(id);
        }
    }
}
