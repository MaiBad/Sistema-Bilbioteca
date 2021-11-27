
namespace SistemaBiblioteca
{
    partial class GestionLibro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLibro));
            this.lblTituloLibro = new System.Windows.Forms.Label();
            this.lblIDLibro = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblAutorLibro = new System.Windows.Forms.Label();
            this.lblEditorialLibro = new System.Windows.Forms.Label();
            this.lblFechaLibro = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtIDLibro = new System.Windows.Forms.TextBox();
            this.cmbAutorLibro = new System.Windows.Forms.ComboBox();
            this.cmbEditorialLibro = new System.Windows.Forms.ComboBox();
            this.dtpFechaLibro = new System.Windows.Forms.DateTimePicker();
            this.tspMLibro = new System.Windows.Forms.ToolStrip();
            this.tspVolverL = new System.Windows.Forms.ToolStripButton();
            this.dgvLibro = new System.Windows.Forms.DataGridView();
            this.btnModificarLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnGuardarLibro = new System.Windows.Forms.Button();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.tspMLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloLibro
            // 
            this.lblTituloLibro.AutoSize = true;
            this.lblTituloLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituloLibro.Location = new System.Drawing.Point(12, 58);
            this.lblTituloLibro.Name = "lblTituloLibro";
            this.lblTituloLibro.Size = new System.Drawing.Size(307, 31);
            this.lblTituloLibro.TabIndex = 25;
            this.lblTituloLibro.Text = "GESTIONAR LIBROS:";
            // 
            // lblIDLibro
            // 
            this.lblIDLibro.AutoSize = true;
            this.lblIDLibro.Location = new System.Drawing.Point(14, 105);
            this.lblIDLibro.Name = "lblIDLibro";
            this.lblIDLibro.Size = new System.Drawing.Size(21, 13);
            this.lblIDLibro.TabIndex = 26;
            this.lblIDLibro.Text = "ID:";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(12, 134);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(47, 13);
            this.lblNombreLibro.TabIndex = 27;
            this.lblNombreLibro.Text = "Nombre:";
            // 
            // lblAutorLibro
            // 
            this.lblAutorLibro.AutoSize = true;
            this.lblAutorLibro.Location = new System.Drawing.Point(12, 167);
            this.lblAutorLibro.Name = "lblAutorLibro";
            this.lblAutorLibro.Size = new System.Drawing.Size(35, 13);
            this.lblAutorLibro.TabIndex = 28;
            this.lblAutorLibro.Text = "Autor:";
            // 
            // lblEditorialLibro
            // 
            this.lblEditorialLibro.AutoSize = true;
            this.lblEditorialLibro.Location = new System.Drawing.Point(12, 201);
            this.lblEditorialLibro.Name = "lblEditorialLibro";
            this.lblEditorialLibro.Size = new System.Drawing.Size(47, 13);
            this.lblEditorialLibro.TabIndex = 29;
            this.lblEditorialLibro.Text = "Editorial:";
            // 
            // lblFechaLibro
            // 
            this.lblFechaLibro.AutoSize = true;
            this.lblFechaLibro.Location = new System.Drawing.Point(101, 105);
            this.lblFechaLibro.Name = "lblFechaLibro";
            this.lblFechaLibro.Size = new System.Drawing.Size(70, 13);
            this.lblFechaLibro.TabIndex = 30;
            this.lblFechaLibro.Text = "Lanzamiento:";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(65, 131);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(232, 20);
            this.txtNombreLibro.TabIndex = 31;
            // 
            // txtIDLibro
            // 
            this.txtIDLibro.Enabled = false;
            this.txtIDLibro.Location = new System.Drawing.Point(41, 102);
            this.txtIDLibro.Name = "txtIDLibro";
            this.txtIDLibro.ReadOnly = true;
            this.txtIDLibro.Size = new System.Drawing.Size(54, 20);
            this.txtIDLibro.TabIndex = 32;
            // 
            // cmbAutorLibro
            // 
            this.cmbAutorLibro.FormattingEnabled = true;
            this.cmbAutorLibro.Location = new System.Drawing.Point(65, 164);
            this.cmbAutorLibro.Name = "cmbAutorLibro";
            this.cmbAutorLibro.Size = new System.Drawing.Size(232, 21);
            this.cmbAutorLibro.TabIndex = 33;
            // 
            // cmbEditorialLibro
            // 
            this.cmbEditorialLibro.FormattingEnabled = true;
            this.cmbEditorialLibro.Location = new System.Drawing.Point(65, 198);
            this.cmbEditorialLibro.Name = "cmbEditorialLibro";
            this.cmbEditorialLibro.Size = new System.Drawing.Size(232, 21);
            this.cmbEditorialLibro.TabIndex = 34;
            // 
            // dtpFechaLibro
            // 
            this.dtpFechaLibro.Location = new System.Drawing.Point(177, 102);
            this.dtpFechaLibro.Name = "dtpFechaLibro";
            this.dtpFechaLibro.Size = new System.Drawing.Size(120, 20);
            this.dtpFechaLibro.TabIndex = 35;
            // 
            // tspMLibro
            // 
            this.tspMLibro.Dock = System.Windows.Forms.DockStyle.None;
            this.tspMLibro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspMLibro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspVolverL});
            this.tspMLibro.Location = new System.Drawing.Point(3, 33);
            this.tspMLibro.Name = "tspMLibro";
            this.tspMLibro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMLibro.Size = new System.Drawing.Size(62, 25);
            this.tspMLibro.TabIndex = 36;
            this.tspMLibro.Text = "toolStrip1";
            // 
            // tspVolverL
            // 
            this.tspVolverL.Image = ((System.Drawing.Image)(resources.GetObject("tspVolverL.Image")));
            this.tspVolverL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspVolverL.Name = "tspVolverL";
            this.tspVolverL.Size = new System.Drawing.Size(59, 22);
            this.tspVolverL.Text = "Volver";
            this.tspVolverL.Click += new System.EventHandler(this.tspVolverL_Click);
            // 
            // dgvLibro
            // 
            this.dgvLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibro.Location = new System.Drawing.Point(12, 234);
            this.dgvLibro.Name = "dgvLibro";
            this.dgvLibro.Size = new System.Drawing.Size(373, 187);
            this.dgvLibro.TabIndex = 37;
            // 
            // btnModificarLibro
            // 
            this.btnModificarLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificarLibro.Location = new System.Drawing.Point(311, 182);
            this.btnModificarLibro.Name = "btnModificarLibro";
            this.btnModificarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnModificarLibro.TabIndex = 40;
            this.btnModificarLibro.Text = "Modificar";
            this.btnModificarLibro.UseVisualStyleBackColor = true;
            this.btnModificarLibro.Click += new System.EventHandler(this.btnModificarLibro_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminarLibro.Location = new System.Drawing.Point(311, 147);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLibro.TabIndex = 39;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnGuardarLibro
            // 
            this.btnGuardarLibro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarLibro.Location = new System.Drawing.Point(311, 115);
            this.btnGuardarLibro.Name = "btnGuardarLibro";
            this.btnGuardarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLibro.TabIndex = 38;
            this.btnGuardarLibro.Text = "Guardar";
            this.btnGuardarLibro.UseVisualStyleBackColor = true;
            this.btnGuardarLibro.Click += new System.EventHandler(this.btnGuardarLibro_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEstilo.Location = new System.Drawing.Point(0, 0);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(400, 33);
            this.lblEstilo.TabIndex = 41;
            this.lblEstilo.Text = "   Gestion de Libros";
            this.lblEstilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GestionLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 434);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.btnModificarLibro);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnGuardarLibro);
            this.Controls.Add(this.dgvLibro);
            this.Controls.Add(this.tspMLibro);
            this.Controls.Add(this.dtpFechaLibro);
            this.Controls.Add(this.cmbEditorialLibro);
            this.Controls.Add(this.cmbAutorLibro);
            this.Controls.Add(this.txtIDLibro);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblFechaLibro);
            this.Controls.Add(this.lblEditorialLibro);
            this.Controls.Add(this.lblAutorLibro);
            this.Controls.Add(this.lblNombreLibro);
            this.Controls.Add(this.lblIDLibro);
            this.Controls.Add(this.lblTituloLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Libro";
            this.Load += new System.EventHandler(this.GestionLibro_Load);
            this.tspMLibro.ResumeLayout(false);
            this.tspMLibro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLibro;
        private System.Windows.Forms.Label lblIDLibro;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblAutorLibro;
        private System.Windows.Forms.Label lblEditorialLibro;
        private System.Windows.Forms.Label lblFechaLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtIDLibro;
        private System.Windows.Forms.ComboBox cmbAutorLibro;
        private System.Windows.Forms.ComboBox cmbEditorialLibro;
        private System.Windows.Forms.DateTimePicker dtpFechaLibro;
        private System.Windows.Forms.ToolStrip tspMLibro;
        private System.Windows.Forms.ToolStripButton tspVolverL;
        private System.Windows.Forms.DataGridView dgvLibro;
        private System.Windows.Forms.Button btnModificarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnGuardarLibro;
        private System.Windows.Forms.Label lblEstilo;
    }
}