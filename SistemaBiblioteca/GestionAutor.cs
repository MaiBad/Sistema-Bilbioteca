using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBiblioteca.Clases;

namespace SistemaBiblioteca
{
    public partial class GestionAutor : Form
    {
        //LLAMANOS A LA CLASE AUTOR
        Autor objAutor = new Autor();
        //CREAMOS LA VARIABLE
        string OperacionA = "Insertar";

        public GestionAutor()
        {
            InitializeComponent();
        }
        //LLAMAMOS AL METODO "ListarAutor" DE LA CLASE AUTOR PARA RELLENAR EN EL DGV
        private void ListAutor()
        {
            dgvAutor.DataSource = objAutor.ListarAutor();
        }
        //CARGAMOS EL MÉTODO
        private void GestionAutor_Load(object sender, EventArgs e)
        {
            ListAutor();
        }
        //BOTON GUARDAR
        private void btnGuardarAutor_Click(object sender, EventArgs e)
        {
            if (OperacionA == "Insertar")
            {
                objAutor.AgregarAutor(txtNombreAutor.Text, txtApellidoAutor.Text, txtNacionalidad.Text);
                MessageBox.Show("Agregado correctamente");
            }
            else if (OperacionA == "Modificar")
            {
                objAutor.EditarAutor(Convert.ToInt32(txtIDAutor.Text),txtNombreAutor.Text, txtApellidoAutor.Text, txtNacionalidad.Text);
                OperacionA = "Insertar";
                MessageBox.Show("Modificado correctamente");
            }
            ListAutor();
            txtNombreAutor.Clear();
            txtApellidoAutor.Clear();
            txtNacionalidad.Clear();
            txtIDAutor.Clear();
        }
        //BOTON MODIFICAR
        private void btnModificarAutor_Click(object sender, EventArgs e)
        {
            if (dgvAutor.SelectedRows.Count > 0)
            {
                OperacionA = "Modificar";
                txtIDAutor.Text = dgvAutor.CurrentRow.Cells[0].Value.ToString();
                txtNombreAutor.Text = dgvAutor.CurrentRow.Cells[1].Value.ToString();
                txtApellidoAutor.Text = dgvAutor.CurrentRow.Cells[2].Value.ToString();
                txtNacionalidad.Text = dgvAutor.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTON ELIMINAR
        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            if (dgvAutor.SelectedRows.Count > 0)
            {
                objAutor.EliminarAutor(Convert.ToInt32(dgvAutor.CurrentRow.Cells[0].Value));
                MessageBox.Show("Eliminado correctamente");
                ListAutor();
                txtNombreAutor.Clear();
                txtApellidoAutor.Clear();
                txtNacionalidad.Clear();
                txtIDAutor.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTON VOLVER DEL MENÚ
        private void tspVolverA_Click(object sender, EventArgs e)
        {
            Principal Principal = new Principal();
            Principal.Show();
            this.Close();
        }
    }
}
