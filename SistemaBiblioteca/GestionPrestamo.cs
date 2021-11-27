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
    public partial class GestionPrestamo : Form
    {
        //LAMAMOS A LA CLASE LIBRO
        Prestamo objPrestamo = new Prestamo();
        //DECLARAMOS VARIABLE
        string OperacionP = "Insertar"; 

        public GestionPrestamo()
        {
            InitializeComponent();
        }
        //LLAMAMOS AL MÉTODO "ListarAlumnos" DE LA CLASE PRESTAMO PARA RELLENAR EL COMBOBOX DE ALUMNOS
        private void ListarComboAlumno()
        {
            cmbAlumnoPrestamo.DataSource = objPrestamo.ListarAlumnos();
            cmbAlumnoPrestamo.DisplayMember = "alumno";
            cmbAlumnoPrestamo.ValueMember = "id_alum";
        }
        //LLAMAMOS AL MÉTODO "ListarLibros" DE LA CLASE PRESTAMO PARA RELLENAR EL COMBOBOX DE LIBROS
        private void ListarComboLibros()
        {
            cmbLibroPrestamo.DataSource = objPrestamo.ListarLibros();
            cmbLibroPrestamo.DisplayMember = "nom_libro";
            cmbLibroPrestamo.ValueMember = "id_libro";
        }
        //LLAMAMOS AL METODO "ListarPrestamo" DE LA CLASE PRESTAMO PARA RELLENAR EN EL DGV
        private void ListPrestamo()
        {
            dgvPrestamo.DataSource = objPrestamo.ListarPrestamo();
        }
        //CARGAMOS LO MÉTODOS
        private void GestionPrestamo_Load(object sender, EventArgs e)
        {
            ListarComboAlumno();
            ListarComboLibros();
            ListPrestamo();
        }
        //BOTÓN GUARDAR
        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            if (OperacionP == "Insertar")
            {
                objPrestamo.AgregarPrestamo(Convert.ToInt32(cmbAlumnoPrestamo.SelectedValue), Convert.ToInt32(cmbLibroPrestamo.SelectedValue), Convert.ToDateTime(dtpFpPrestamo.Value), Convert.ToDateTime(dtpFdPrestamo.Value));
                MessageBox.Show("Agregado correctamente");
            }
            else if (OperacionP == "Modificar")
            {
                objPrestamo.EditarPrestamo(Convert.ToInt32(txtIDPrestamo.Text), Convert.ToInt32(cmbAlumnoPrestamo.SelectedValue), Convert.ToInt32(cmbLibroPrestamo.SelectedValue), Convert.ToDateTime(dtpFpPrestamo.Value), Convert.ToDateTime(dtpFdPrestamo.Value));
                OperacionP = "Insertar";
                MessageBox.Show("Modificado correctamente");
            }
            ListPrestamo();
            txtIDPrestamo.Clear();
        }
        //BOTÓN MODIFICAR
        private void btnModificarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamo.SelectedRows.Count > 0)
            {
                OperacionP = "Modificar";
                txtIDPrestamo.Text = dgvPrestamo.CurrentRow.Cells[0].Value.ToString();
                cmbAlumnoPrestamo.Text = dgvPrestamo.CurrentRow.Cells[1].Value.ToString();
                cmbLibroPrestamo.Text = dgvPrestamo.CurrentRow.Cells[2].Value.ToString();
                dtpFpPrestamo.Text = dgvPrestamo.CurrentRow.Cells[3].Value.ToString();
                dtpFdPrestamo.Text = dgvPrestamo.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTÓN ELIMINAR
        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamo.SelectedRows.Count > 0)
            {
                objPrestamo.EliminarPrestamo(Convert.ToInt32(dgvPrestamo.CurrentRow.Cells[0].Value));
                MessageBox.Show("Eliminado correctamente");
                ListPrestamo();
                txtIDPrestamo.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTÓN VOLVER DEL MENÚ
        private void tspVolverP_Click(object sender, EventArgs e)
        {
            Principal Principal = new Principal();
            Principal.Show();
            this.Close();
        }
    }
}
