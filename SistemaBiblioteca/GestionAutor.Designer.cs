namespace SistemaBiblioteca
{
    partial class GestionAutor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionAutor));
            this.dgvAutor = new System.Windows.Forms.DataGridView();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.lblApellidoAutor = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.btnGuardarAutor = new System.Windows.Forms.Button();
            this.btnEliminarAutor = new System.Windows.Forms.Button();
            this.btnModificarAutor = new System.Windows.Forms.Button();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.txtApellidoAutor = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.lblTituloAutor = new System.Windows.Forms.Label();
            this.lblIDAutor = new System.Windows.Forms.Label();
            this.txtIDAutor = new System.Windows.Forms.TextBox();
            this.tspMAutor = new System.Windows.Forms.ToolStrip();
            this.tspVolverA = new System.Windows.Forms.ToolStripButton();
            this.lblEstilo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
            this.tspMAutor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAutor
            // 
            this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutor.Location = new System.Drawing.Point(12, 231);
            this.dgvAutor.Name = "dgvAutor";
            this.dgvAutor.Size = new System.Drawing.Size(373, 187);
            this.dgvAutor.TabIndex = 0;

            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.Location = new System.Drawing.Point(14, 135);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(47, 13);
            this.lblNombreAutor.TabIndex = 1;
            this.lblNombreAutor.Text = "Nombre:";

            // 
            // lblApellidoAutor
            // 
            this.lblApellidoAutor.AutoSize = true;
            this.lblApellidoAutor.Location = new System.Drawing.Point(14, 167);
            this.lblApellidoAutor.Name = "lblApellidoAutor";
            this.lblApellidoAutor.Size = new System.Drawing.Size(52, 13);
            this.lblApellidoAutor.TabIndex = 2;
            this.lblApellidoAutor.Text = "Apellidos:";

            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(14, 202);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.lblNacionalidad.TabIndex = 3;
            this.lblNacionalidad.Text = "Nacionalidad:";

            // 
            // btnGuardarAutor
            // 
            this.btnGuardarAutor.Location = new System.Drawing.Point(310, 112);
            this.btnGuardarAutor.Name = "btnGuardarAutor";
            this.btnGuardarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAutor.TabIndex = 4;
            this.btnGuardarAutor.Text = "Guardar";
            this.btnGuardarAutor.UseVisualStyleBackColor = true;
            this.btnGuardarAutor.Click += new System.EventHandler(this.btnGuardarAutor_Click);
            // 
            // btnEliminarAutor
            // 
            this.btnEliminarAutor.Location = new System.Drawing.Point(310, 144);
            this.btnEliminarAutor.Name = "btnEliminarAutor";
            this.btnEliminarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAutor.TabIndex = 5;
            this.btnEliminarAutor.Text = "Eliminar";
            this.btnEliminarAutor.UseVisualStyleBackColor = true;
            this.btnEliminarAutor.Click += new System.EventHandler(this.btnEliminarAutor_Click);
            // 
            // btnModificarAutor
            // 
            this.btnModificarAutor.Location = new System.Drawing.Point(310, 179);
            this.btnModificarAutor.Name = "btnModificarAutor";
            this.btnModificarAutor.Size = new System.Drawing.Size(75, 23);
            this.btnModificarAutor.TabIndex = 6;
            this.btnModificarAutor.Text = "Modificar";
            this.btnModificarAutor.UseVisualStyleBackColor = true;
            this.btnModificarAutor.Click += new System.EventHandler(this.btnModificarAutor_Click);
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.Location = new System.Drawing.Point(67, 132);
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(210, 20);
            this.txtNombreAutor.TabIndex = 7;

            // 
            // txtApellidoAutor
            // 
            this.txtApellidoAutor.Location = new System.Drawing.Point(72, 164);
            this.txtApellidoAutor.Name = "txtApellidoAutor";
            this.txtApellidoAutor.Size = new System.Drawing.Size(205, 20);
            this.txtApellidoAutor.TabIndex = 8;

            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(92, 199);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(185, 20);
            this.txtNacionalidad.TabIndex = 9;

            // 
            // lblTituloAutor
            // 
            this.lblTituloAutor.AutoSize = true;
            this.lblTituloAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAutor.Location = new System.Drawing.Point(6, 54);
            this.lblTituloAutor.Name = "lblTituloAutor";
            this.lblTituloAutor.Size = new System.Drawing.Size(340, 31);
            this.lblTituloAutor.TabIndex = 10;
            this.lblTituloAutor.Text = "GESTIONAR AUTORES:";

            // 
            // lblIDAutor
            // 
            this.lblIDAutor.AutoSize = true;
            this.lblIDAutor.Location = new System.Drawing.Point(14, 102);
            this.lblIDAutor.Name = "lblIDAutor";
            this.lblIDAutor.Size = new System.Drawing.Size(21, 13);
            this.lblIDAutor.TabIndex = 12;
            this.lblIDAutor.Text = "ID:";

            // 
            // txtIDAutor
            // 
            this.txtIDAutor.Enabled = false;
            this.txtIDAutor.Location = new System.Drawing.Point(41, 99);
            this.txtIDAutor.Name = "txtIDAutor";
            this.txtIDAutor.ReadOnly = true;
            this.txtIDAutor.Size = new System.Drawing.Size(236, 20);
            this.txtIDAutor.TabIndex = 13;
            this.txtIDAutor.TabStop = false;

            // 
            // tspMAutor
            // 
            this.tspMAutor.Dock = System.Windows.Forms.DockStyle.None;
            this.tspMAutor.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspMAutor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspVolverA});
            this.tspMAutor.Location = new System.Drawing.Point(2, 32);
            this.tspMAutor.Name = "tspMAutor";
            this.tspMAutor.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspMAutor.Size = new System.Drawing.Size(62, 25);
            this.tspMAutor.TabIndex = 14;
            this.tspMAutor.Text = "toolStrip1";
            // 
            // tspVolverA
            // 
            this.tspVolverA.Image = ((System.Drawing.Image)(resources.GetObject("tspVolverA.Image")));
            this.tspVolverA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspVolverA.Name = "tspVolverA";
            this.tspVolverA.Size = new System.Drawing.Size(59, 22);
            this.tspVolverA.Text = "Volver";
            this.tspVolverA.Click += new System.EventHandler(this.tspVolverA_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblEstilo.Location = new System.Drawing.Point(-1, -1);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(400, 33);
            this.lblEstilo.TabIndex = 42;
            this.lblEstilo.Text = "   Gestion de Autores";
            this.lblEstilo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GestionAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 430);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.tspMAutor);
            this.Controls.Add(this.txtIDAutor);
            this.Controls.Add(this.lblIDAutor);
            this.Controls.Add(this.lblTituloAutor);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtApellidoAutor);
            this.Controls.Add(this.txtNombreAutor);
            this.Controls.Add(this.btnModificarAutor);
            this.Controls.Add(this.btnEliminarAutor);
            this.Controls.Add(this.btnGuardarAutor);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblApellidoAutor);
            this.Controls.Add(this.lblNombreAutor);
            this.Controls.Add(this.dgvAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Autores";
            this.Load += new System.EventHandler(this.GestionAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
            this.tspMAutor.ResumeLayout(false);
            this.tspMAutor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutor;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Label lblApellidoAutor;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.Button btnGuardarAutor;
        private System.Windows.Forms.Button btnEliminarAutor;
        private System.Windows.Forms.Button btnModificarAutor;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.TextBox txtApellidoAutor;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label lblTituloAutor;
        private System.Windows.Forms.Label lblIDAutor;
        private System.Windows.Forms.TextBox txtIDAutor;
        private System.Windows.Forms.ToolStrip tspMAutor;
        private System.Windows.Forms.ToolStripButton tspVolverA;
        private System.Windows.Forms.Label lblEstilo;
    }
}

