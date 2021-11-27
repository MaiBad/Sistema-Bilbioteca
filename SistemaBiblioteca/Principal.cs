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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void tspAutores_Click(object sender, EventArgs e)
        {
            GestionAutor Autores = new GestionAutor();
            Autores.Show();
            this.Close();
        }

        private void tspEditoriales_Click(object sender, EventArgs e)
        {
            GestionEditorial Editoriales = new GestionEditorial();
            Editoriales.Show();
            this.Close();
        }
        private void tspLibros_Click(object sender, EventArgs e)
        {
            GestionLibro Libros = new GestionLibro();
            Libros.Show();
            this.Close();
        }
        private void tspPrestamos_Click(object sender, EventArgs e)
        {
            GestionPrestamo Prestamos = new GestionPrestamo();
            Prestamos.Show();
            this.Close();
        }
        private void tspSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblEstilo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            label1.Text = hoy.ToString("hh:");
            label2.Text = hoy.ToString("mm   ");
            label3.Text = hoy.ToString("tt");
            label4.Text = hoy.ToString("ss");
        }
    }
}
