using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Clases
{
    class Autor
    {
        private Conexion cnx = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //METODO PARA LISTAR AUTORES EN EL DGV
        public DataTable ListarAutor()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_LISTARAUTOR";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //METODO PARA AGREGAR AUTOR
        public void AgregarAutor(string nom_autor, string ape_autor, string nac_autor)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_AGREGARAUTOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@NOM", nom_autor);
            Comando.Parameters.AddWithValue("@APE", ape_autor);
            Comando.Parameters.AddWithValue("@NAC", nac_autor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //METODO PARA EDITAR AUTOR
        public void EditarAutor(int id_autor, string nom_autor, string ape_autor, string nac_autor)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_MODIFICARAUTOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_autor);
            Comando.Parameters.AddWithValue("@NOM", nom_autor);
            Comando.Parameters.AddWithValue("@APE", ape_autor);
            Comando.Parameters.AddWithValue("@NAC", nac_autor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //METODO PARA ELIMINAR AUTOR
        public void EliminarAutor(int id_autor)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_ELIMINARAUTOR";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_autor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
    }
}
