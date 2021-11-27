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
    public partial class GestionEditorial : Form
    {
        //LLAMANOS A LA CLASE EDITORIAL
        Editorial objEditorial = new Editorial();
        //CREAMOS LA VARIABLE
        string OperacionE = "Insertar";

        public GestionEditorial()
        {
            InitializeComponent();
        }
        //LLAMAMOS AL METODO "ListEditorial" DE LA CLASE EDITORIAL PARA RELLENAR EN EL DGV
        private void ListEditorial()
        {
            dgvEditorial.DataSource = objEditorial.ListarEditorial();
        }
        //CARGAMOS EL MÉTODO
        private void GestionEditorial_Load(object sender, EventArgs e)
        {
            ListEditorial();
        }
        //BOTÓN GUARDAR
        private void btnGuardarEditorial_Click(object sender, EventArgs e)
        {
            if (OperacionE == "Insertar")
            {
                objEditorial.AgregarEditorial(txtNombreEditorial.Text, txtTlfEditorial.Text, txtCorreoEditorial.Text);
                MessageBox.Show("Agregado correctamente");
            }
            else if (OperacionE == "Modificar")
            {
                objEditorial.EditarEditorial(Convert.ToInt32(txtIDEditorial.Text), txtNombreEditorial.Text, txtTlfEditorial.Text, txtCorreoEditorial.Text);
                OperacionE = "Insertar";
                MessageBox.Show("Modificado correctamente");
            }
            ListEditorial();
            txtNombreEditorial.Clear();
            txtTlfEditorial.Clear();
            txtCorreoEditorial.Clear();
            txtIDEditorial.Clear();
        }
        //BOTÓN MODFICAR
        private void btnModificarEditorial_Click(object sender, EventArgs e)
        {
            if (dgvEditorial.SelectedRows.Count > 0)
            {
                OperacionE = "Modificar";
                txtIDEditorial.Text = dgvEditorial.CurrentRow.Cells[0].Value.ToString();
                txtNombreEditorial.Text = dgvEditorial.CurrentRow.Cells[1].Value.ToString();
                txtTlfEditorial.Text = dgvEditorial.CurrentRow.Cells[2].Value.ToString();
                txtCorreoEditorial.Text = dgvEditorial.CurrentRow.Cells[3].Value.ToString();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTÓN ELIMINAR
        private void btnEliminarEditorial_Click(object sender, EventArgs e)
        {
            if (dgvEditorial.SelectedRows.Count > 0)
            {
                objEditorial.EliminarEditorial(Convert.ToInt32(dgvEditorial.CurrentRow.Cells[0].Value));
                MessageBox.Show("Eliminado correctamente");
                ListEditorial();
                txtNombreEditorial.Clear();
                txtTlfEditorial.Clear();
                txtCorreoEditorial.Clear();
                txtIDEditorial.Clear();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila");
            }
        }
        //BOTÓN VOLVER DEL MENÚ
        private void tspVolverE_Click(object sender, EventArgs e)
        {
            Principal Principal = new Principal();
            Principal.Show();
            this.Close();
        }
    }
}
