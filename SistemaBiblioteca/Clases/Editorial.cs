using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Clases
{
    class Editorial
    {
        private Conexion cnx = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        //METODO PARA LISTAR EDITORIALES EN EL DGV
        public DataTable ListarEditorial()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_LISTAREDITORIAL";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            cnx.CerrarConexion();
            return Tabla;
        }
        //METODO PARA AGREGAR EDITORIALES
        public void AgregarEditorial(string nom_edi, string telf_edi, string email_edi)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_AGREGAREDITORIAL";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@NOM", nom_edi);
            Comando.Parameters.AddWithValue("@TLF", telf_edi);
            Comando.Parameters.AddWithValue("@EMA", email_edi);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //METODO PARA EDITAR EDITORIALES
        public void EditarEditorial(int id_edi, string nom_edi, string telf_edi, string email_edi)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_MODIFICAREDITORIAL";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_edi);
            Comando.Parameters.AddWithValue("@NOM", nom_edi);
            Comando.Parameters.AddWithValue("@TLF", telf_edi);
            Comando.Parameters.AddWithValue("@EMA", email_edi);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
        //METODO PARA ELIMINAR EDITORIALES
        public void EliminarEditorial(int id_edi)
        {
            Comando.Connection = cnx.AbrirConexion();
            Comando.CommandText = "SP_ELIMINAREDITORIAL";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@IDE", id_edi);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }
    }
}
