using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Clases
{
    class Prestamo
    {
        private Conexion cnx = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //MÉTODO PARA ALUMNOS EN EL COMBOBOX
        public DataTable ListarAlumnos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_ALUMNOCOMBO";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //MÉTODO PARA LIBROS EN EL COMBOBOX
        public DataTable ListarLibros()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_LIBROCOMBO";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //MÉTODO PARA LISTAR PRESTAMOS EN EL DGV
        public DataTable ListarPrestamo()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_LISTARPRESTAMO";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //MÉTODO PARA AGREGAR PRESTAMO
        public void AgregarPrestamo(int id_alum, int id_libro, DateTime fech_pres, DateTime fech_devo)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_AREGARPRESTAMO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ALU", id_alum);
            Comando.Parameters.AddWithValue("@LIB", id_libro);
            Comando.Parameters.AddWithValue("@PRE", fech_pres);
            Comando.Parameters.AddWithValue("@DEV", fech_devo);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //MÉTODO PARA MODIFICAR PRESTAMO
        public void EditarPrestamo(int id_pres, int id_alum, int id_libro, DateTime fech_pres, DateTime fech_devo)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_MODIFICARPRESTAMO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_pres);
            Comando.Parameters.AddWithValue("@ALU", id_alum);
            Comando.Parameters.AddWithValue("@LIB", id_libro);
            Comando.Parameters.AddWithValue("@PRE", fech_pres);
            Comando.Parameters.AddWithValue("@DEV", fech_devo);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //MÉTODO PARA ELIMINAR PRESTAMO
        public void EliminarPrestamo(int id_pres)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_ELIMINARPRESTAMO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_pres);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
    }
}
