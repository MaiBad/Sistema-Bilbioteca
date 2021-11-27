using SistemaBiblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class GestionLibro : Form
    {
        //LAMAMOS A LA CLASE LIBRO
        Libro objLibro = new Libro();
        //DECLARAMOS VARIABLE
        string OperacionL = "Insertar";
        public GestionLibro()
        {
            InitializeComponent();
        }
        //LLAMAMOS AL MÉTODO "ListarAutores" DE LA CLASE LIBRO PARA RELLENAR EL COMBOBOX DE AUTORES
        private void ListarComboAutor()
        {
            cmbAutorLibro.DataSource = objLibro.ListarAutores();
            cmbAutorLibro.DisplayMember = "autor";
            cmbAutorLibro.ValueMember = "id_autor";
        }
        //LLAMAMOS AL MÉTODO "ListarEditoriales" DE LA CLASE LIBRO PARA RELLENAR EL COMBOBOX DE EDITORIALES
        private void ListarComboEditorial()
        {
            cmbEditorialLibro.DataSource = objLibro.ListarEditoriales();
            cmbEditorialLibro.DisplayMember = "nom_edi";
            cmbEditorialLibro.ValueMember = "id_edi";
        }
        //LLAMAMOS AL METODO "ListarLibro" DE LA CLASE LIBRO PARA RELLENAR EN EL DGV
        private void ListLibro()
        {
            dgvLibro.DataSource = objLibro.ListarLibro();
        }
        //CARGAMOS LOS MÉTODOS
        private void GestionLibro_Load(object sender, EventArgs e)
        {
            ListLibro();
            ListarComboAutor();
            ListarComboEditorial();
        }
        //BOTÓN GUARDAR
        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            if (OperacionL == "Insertar")
            {
                objLibro.AgregarLibro(txtNombreLibro.Text, Convert.ToInt32(cmbAutorLibro.SelectedValue), Convert.ToInt32(cmbEditorialLibro.SelectedValue), Convert.ToDateTime(dtpFechaLibro.Value));
                MessageBox.Show("Agregado correctamente");
            }
            else if (OperacionL == "Modificar")
            {
                objLibro.EditarLibro(Convert.ToInt32(txtIDLibro.Text), txtNombreLibro.Text, Convert.ToInt32(cmbAutorLibro.SelectedValue), Convert.ToInt32(cmbEditorialLibro.SelectedValue), Convert.ToDateTime(dtpFechaLibro.Value));
                OperacionL = "Insertar";
                MessageBox.Show("Modificado correctamente");
            }
            ListLibro();
            txtNombreLibro.Clear();
            txtIDLibro.Clear();
        }
        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count > 0)
            {
                OperacionL = "Modificar";
                txtIDLibro.Text = dgvLibro.CurrentRow.Cells[0].Value.ToString();
                txtNombreLibro.Text = dgvLibro.CurrentRow.Cells[1].Value.ToString();
                cmbAutorLibro.Text = dgvLibro.CurrentRow.Cells[2].Value.ToString();
                cmbEditorialLibro.Text = dgvLibro.CurrentRow.Cells[3].Value.ToString();
                dtpFechaLibro.Text = dgvLibro.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count > 0)
            {
                objLibro.EliminarLibro(Convert.ToInt32(dgvLibro.CurrentRow.Cells[0].Value));
                MessageBox.Show("Eliminado correctamente");
                ListLibro();
                txtNombreLibro.Clear();
                txtIDLibro.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTÓN VOLVER DEL MENÚ
        private void tspVolverL_Click(object sender, EventArgs e)
        {
            Principal Principal = new Principal();
            Principal.Show();
            this.Close();
        }
    }
}
