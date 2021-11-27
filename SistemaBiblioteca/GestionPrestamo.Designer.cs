
namespace SistemaBiblioteca
{
    partial class GestionPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPrestamo));
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.cmbAlumnoPrestamo = new System.Windows.Forms.ComboBox();
            this.cmbLibroPrestamo = new System.Windows.Forms.ComboBox();
            this.lblIDPrestamo = new System.Windows.Forms.Label();
            this.lblAlumnoPrestamo = new System.Windows.Forms.Label();
            this.lblLibroPrestamo = new System.Windows.Forms.Label();
            this.lblFpPrestamo = new System.Windows.Forms.Label();
            this.dtpFpPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFdPrestamo = new System.Windows.Forms.DateTimePicker();
            this.lblFdPrestamo = new System.Windows.Forms.Label();
            this.txtIDPrestamo = new System.Windows.Forms.TextBox();
            this.tspPrestamo = new System.Windows.Forms.ToolStrip();
            this.tspVolverP = new System.Windows.Forms.ToolStripButton();
            this.lblTituloPrestamo = new System.Windows.Forms.Label();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.btnModificarPrestamo = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnGuardarPrestamo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.tspPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Location = new System.Drawing.Point(12, 278);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.Size = new System.Drawing.Size(431, 207);
            this.dgvPrestamo.TabIndex = 0;
            // 
            // cmbAlumnoPrestamo
            // 
            this.cmbAlumnoPrestamo.FormattingEnabled = true;
            this.cmbAlumnoPrestamo.Location = new System.Drawing.Point(63, 135);
            this.cmbAlumnoPrestamo.Name = "cmbAlumnoPrestamo";
            this.cmbAlumnoPrestamo.Size = new System.Drawing.Size(254, 21);
            this.cmbAlumnoPrestamo.TabIndex = 1;
            // 
            // cmbLibroPrestamo
            // 
            this.cmbLibroPrestamo.FormattingEnabled = true;
            this.cmbLibroPrestamo.Location = new System.Drawing.Point(63, 174);
            this.cmbLibroPrestamo.Name = "cmbLibroPrestamo";
            this.cmbLibroPrestamo.Size = new System.Drawing.Size(254, 21);
            this.cmbLibroPrestamo.TabIndex = 2;
            // 
            // lblIDPrestamo
            // 
            this.lblIDPrestamo.AutoSize = true;
            this.lblIDPrestamo.Location = new System.Drawing.Point(12, 99);
            this.lblIDPrestamo.Name = "lblIDPrestamo";
            this.lblIDPrestamo.Size = new System.Drawing.Size(109, 13);
            this.lblIDPrestamo.TabIndex = 3;
            this.lblIDPrestamo.Text = "Número de Prestamo:";
            // 
            // lblAlumnoPrestamo
            // 
            this.lblAlumnoPrestamo.AutoSize = true;
            this.lblAlumnoPrestamo.Location = new System.Drawing.Point(12, 138);
            this.lblAlumnoPrestamo.Name = "lblAlumnoPrestamo";
            this.lblAlumnoPrestamo.Size = new System.Drawing.Size(45, 13);
            this.lblAlumnoPrestamo.TabIndex = 4;
            this.lblAlumnoPrestamo.Text = "Alumno:";
            // 
            // lblLibroPrestamo
            // 
            this.lblLibroPrestamo.AutoSize = true;
            this.lblLibroPrestamo.Location = new System.Drawing.Point(12, 177);
            this.lblLibroPrestamo.Name = "lblLibroPrestamo";
            this.lblLibroPrestamo.Size = new System.Drawing.Size(33, 13);
            this.lblLibroPrestamo.TabIndex = 5;
            this.lblLibroPrestamo.Text = "Libro:";
            // 
            // lblFpPrestamo
            // 
            this.lblFpPrestamo.AutoSize = true;
            this.lblFpPrestamo.Location = new System.Drawing.Point(12, 216);
            this.lblFpPrestamo.Name = "lblFpPrestamo";
            this.lblFpPrestamo.Size = new System.Drawing.Size(101, 13);
            this.lblFpPrestamo.TabIndex = 6;
            this.lblFpPrestamo.Text = "Fecha de préstamo:";
            // 
            // dtpFpPrestamo
            // 
            this.dtpFpPrestamo.Location = new System.Drawing.Point(127, 210);
            this.dtpFpPrestamo.Name = "dtpFpPrestamo";
            this.dtpFpPrestamo.Size = new System.Drawing.Size(190, 20);
            this.dtpFpPrestamo.TabIndex = 7;
            this.dtpFpPrestamo.Value = new System.DateTime(2021, 11, 26, 0, 0, 0, 0);
            // 
            // dtpFdPrestamo
            // 
            this.dtpFdPrestamo.Location = new System.Drawing.Point(128, 249);
            this.dtpFdPrestamo.Name = "dtpFdPrestamo";
            this.dtpFdPrestamo.Size = new System.Drawing.Size(189, 20);
            this.dtpFdPrestamo.TabIndex = 8;
            this.dtpFdPrestamo.Value = new System.DateTime(2021, 11, 26, 17, 48, 34, 0);
            // 
            // lblFdPrestamo
            // 
            this.lblFdPrestamo.AutoSize = true;
            this.lblFdPrestamo.Location = new System.Drawing.Point(12, 255);
            this.lblFdPrestamo.Name = "lblFdPrestamo";
            this.lblFdPrestamo.Size = new System.Drawing.Size(110, 13);
            this.lblFdPrestamo.TabIndex = 9;
            this.lblFdPrestamo.Text = "Fecha de devolución:";
            // 
            // txtIDPrestamo
            // 
            this.txtIDPrestamo.Location = new System.Drawing.Point(127, 96);
            this.txtIDPrestamo.Name = "txtIDPrestamo";
            this.txtIDPrestamo.Size = new System.Drawing.Size(190, 20);
            this.txtIDPrestamo.TabIndex = 10;
            // 
            // tspPrestamo
            // 
            this.tspPrestamo.Dock = System.Windows.Forms.DockStyle.None;
            this.tspPrestamo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspPrestamo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspVolverP});
            this.tspPrestamo.Location = new System.Drawing.Point(2, 32);
            this.tspPrestamo.Name = "tspPrestamo";
            this.tspPrestamo.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspPrestamo.Size = new System.Drawing.Size(93, 25);
            this.tspPrestamo.TabIndex = 11;
            this.tspPrestamo.Text = "toolStrip1";
            // 
            // tspVolverP
            // 
            this.tspVolverP.Image = ((System.Drawing.Image)(resources.GetObject("tspVolverP.Image")));
            this.tspVolverP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspVolverP.Name = "tspVolverP";
            this.tspVolverP.Size = new System.Drawing.Size(59, 22);
            this.tspVolverP.Text = "Volver";
            this.tspVolverP.Click += new System.EventHandler(this.tspVolverP_Click);
            // 
            // lblTituloPrestamo
            // 
            this.lblTituloPrestamo.AutoSize = true;
            this.lblTituloPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTituloPrestamo.Location = new System.Drawing.Point(12, 57);
            this.lblTituloPrestamo.Name = "lblTituloPrestamo";
            this.lblTituloPrestamo.Size = new System.Drawing.Size(380, 31);
            this.lblTituloPrestamo.TabIndex = 25;
            this.lblTituloPrestamo.Text = "GESTIONAR PRESTAMOS:";
            // 
            // lblEstilo
            // 
            this.lblEstilo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEstilo.Location = new System.Drawing.Point(-1, -1);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(458, 33);
            this.lblEstilo.TabIndex = 42;
            this.lblEstilo.Text = "   Gestion de Prestamos";
            this.lblEstilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificarPrestamo
            // 
            this.btnModificarPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnModificarPrestamo.Location = new System.Drawing.Point(351, 195);
            this.btnModificarPrestamo.Name = "btnModificarPrestamo";
            this.btnModificarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPrestamo.TabIndex = 45;
            this.btnModificarPrestamo.Text = "Modificar";
            this.btnModificarPrestamo.UseVisualStyleBackColor = true;
            this.btnModificarPrestamo.Click += new System.EventHandler(this.btnModificarPrestamo_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(351, 160);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPrestamo.TabIndex = 44;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnGuardarPrestamo
            // 
            this.btnGuardarPrestamo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGuardarPrestamo.Location = new System.Drawing.Point(351, 128);
            this.btnGuardarPrestamo.Name = "btnGuardarPrestamo";
            this.btnGuardarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarPrestamo.TabIndex = 43;
            this.btnGuardarPrestamo.Text = "Guardar";
            this.btnGuardarPrestamo.UseVisualStyleBackColor = true;
            this.btnGuardarPrestamo.Click += new System.EventHandler(this.btnGuardarPrestamo_Click);
            // 
            // GestionPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 497);
            this.Controls.Add(this.btnModificarPrestamo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnGuardarPrestamo);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.lblTituloPrestamo);
            this.Controls.Add(this.tspPrestamo);
            this.Controls.Add(this.txtIDPrestamo);
            this.Controls.Add(this.lblFdPrestamo);
            this.Controls.Add(this.dtpFdPrestamo);
            this.Controls.Add(this.dtpFpPrestamo);
            this.Controls.Add(this.lblFpPrestamo);
            this.Controls.Add(this.lblLibroPrestamo);
            this.Controls.Add(this.lblAlumnoPrestamo);
            this.Controls.Add(this.lblIDPrestamo);
            this.Controls.Add(this.cmbLibroPrestamo);
            this.Controls.Add(this.cmbAlumnoPrestamo);
            this.Controls.Add(this.dgvPrestamo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Prestamo";
            this.Load += new System.EventHandler(this.GestionPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.tspPrestamo.ResumeLayout(false);
            this.tspPrestamo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.ComboBox cmbAlumnoPrestamo;
        private System.Windows.Forms.ComboBox cmbLibroPrestamo;
        private System.Windows.Forms.Label lblIDPrestamo;
        private System.Windows.Forms.Label lblAlumnoPrestamo;
        private System.Windows.Forms.Label lblLibroPrestamo;
        private System.Windows.Forms.Label lblFpPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFpPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFdPrestamo;
        private System.Windows.Forms.Label lblFdPrestamo;
        private System.Windows.Forms.TextBox txtIDPrestamo;
        private System.Windows.Forms.ToolStrip tspPrestamo;
        private System.Windows.Forms.ToolStripButton tspVolverP;
        private System.Windows.Forms.Label lblTituloPrestamo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Button btnModificarPrestamo;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnGuardarPrestamo;
    }
}