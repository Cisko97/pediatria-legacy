using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CapaNegocio
{
    public class ValidarImagen
    {
        
        public bool ValidarFormatoImagen(double tamaño, string ruta)

        {
            //Obtener tamaño
            
            bool resultado;

            if (tamaño <= 100.00 && Path.GetExtension(ruta) == ".jpg")
            {
                resultado = true;
                Console.WriteLine(tamaño);
                Console.WriteLine("true");
            }
            else
            {
                resultado = false;
            }

            return resultado;
          
        }
    }
}
