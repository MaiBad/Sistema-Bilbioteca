using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Clases
{
    class Libro
    {
        private Conexion cnx = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //METODO PARA AUTORES EN EL COMBOBOX
        public DataTable ListarAutores()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_AUTORCOMBO";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //METODO PARA EDITORIALES EN EL COMBOBOX
        public DataTable ListarEditoriales()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_EDITORIALCOMBO";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //METODO PARA LISTAR LIBROS EN EL DGV
        public DataTable ListarLibro()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_LISTARLIBRO";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //METODO PARA AGREGAR LIBRO
        public void AgregarLibro(string nom_libro, int id_autor, int id_edi, DateTime fech_lanz)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_AREGARLIBRO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@NOM", nom_libro);
            Comando.Parameters.AddWithValue("@AUT", id_autor);
            Comando.Parameters.AddWithValue("@EDI", id_edi);
            Comando.Parameters.AddWithValue("@LAN", fech_lanz);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //METODO PARA MODIFICAR LIBRO
        public void EditarLibro(int id_libro, string nom_libro, int id_autor, int id_edi, DateTime fech_lanz)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_MODIFICARLIBRO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_libro);
            Comando.Parameters.AddWithValue("@NOM", nom_libro);
            Comando.Parameters.AddWithValue("@AUT", id_autor);
            Comando.Parameters.AddWithValue("@EDI", id_edi);
            Comando.Parameters.AddWithValue("@LAN", fech_lanz);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //METODO PARA ELIMINAR LIBRO
        public void EliminarLibro(int id_libro)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_ELIMINARLIBRO";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_libro);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
    }
}
