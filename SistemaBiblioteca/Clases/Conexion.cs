using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Clases
{
    class Conexion
    {
        static private string cn = "server=.;database=bd_biblioteca;integrated security = true";
        private SqlConnection cnx = new SqlConnection(cn);

        public SqlConnection AbrirConexion()
        {
            if (cnx.State == ConnectionState.Closed)
            {
                cnx.Open();
            }
            return cnx;
        }
        public SqlConnection CerrarConexion()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            return cnx;
        }
    }
}
