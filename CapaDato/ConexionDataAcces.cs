using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDato
{
    class ConexionDataAcces
    {
        string cadena = "Data Source=LEONARDO-HP\\SQLEXPRESS;Initial Catalog=ConsultorioPediatricoBD;" +
            "Integrated Security=True";

        public SqlConnection conectarBD = new SqlConnection();

        public ConexionDataAcces()
        {
            conectarBD.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarBD.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Conexion fallo", ex.Message);
            }
        }

        public void cerrar()
        {
            conectarBD.Close();
        }
    }
}
