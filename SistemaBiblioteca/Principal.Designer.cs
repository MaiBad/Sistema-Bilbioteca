namespace SistemaBiblioteca
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tspPrincipal = new System.Windows.Forms.ToolStrip();
            this.tspAutores = new System.Windows.Forms.ToolStripButton();
            this.tspEditoriales = new System.Windows.Forms.ToolStripButton();
            this.tspLibros = new System.Windows.Forms.ToolStripButton();
            this.tspPrestamos = new System.Windows.Forms.ToolStripButton();
            this.tspSalir = new System.Windows.Forms.ToolStripButton();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblCerrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tspPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspPrincipal
            // 
            this.tspPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tspPrincipal.Dock = System.Windows.Forms.DockStyle.None;
            this.tspPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAutores,
            this.tspEditoriales,
            this.tspLibros,
            this.tspPrestamos,
            this.tspSalir});
            this.tspPrincipal.Location = new System.Drawing.Point(2, 33);
            this.tspPrincipal.Name = "tspPrincipal";
            this.tspPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspPrincipal.Size = new System.Drawing.Size(368, 25);
            this.tspPrincipal.TabIndex = 0;
            this.tspPrincipal.Text = "toolStrip1";
            // 
            // tspAutores
            // 
            this.tspAutores.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.tspAutores.BackColor = System.Drawing.Color.LemonChiffon;
            this.tspAutores.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspAutores.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tspAutores.Image = ((System.Drawing.Image)(resources.GetObject("tspAutores.Image")));
            this.tspAutores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspAutores.Name = "tspAutores";
            this.tspAutores.Size = new System.Drawing.Size(72, 22);
            this.tspAutores.Text = "Autores";
            this.tspAutores.Click += new System.EventHandler(this.tspAutores_Click);
            // 
            // tspEditoriales
            // 
            this.tspEditoriales.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.tspEditoriales.BackColor = System.Drawing.Color.LemonChiffon;
            this.tspEditoriales.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspEditoriales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tspEditoriales.Image = ((System.Drawing.Image)(resources.GetObject("tspEditoriales.Image")));
            this.tspEditoriales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspEditoriales.Name = "tspEditoriales";
            this.tspEditoriales.Size = new System.Drawing.Size(90, 22);
            this.tspEditoriales.Text = "Editoriales";
            this.tspEditoriales.Click += new System.EventHandler(this.tspEditoriales_Click);
            // 
            // tspLibros
            // 
            this.tspLibros.BackColor = System.Drawing.Color.LemonChiffon;
            this.tspLibros.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspLibros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tspLibros.Image = ((System.Drawing.Image)(resources.GetObject("tspLibros.Image")));
            this.tspLibros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspLibros.Name = "tspLibros";
            this.tspLibros.Size = new System.Drawing.Size(63, 22);
            this.tspLibros.Text = "Libros";
            this.tspLibros.Click += new System.EventHandler(this.tspLibros_Click);
            // 
            // tspPrestamos
            // 
            this.tspPrestamos.BackColor = System.Drawing.Color.LemonChiffon;
            this.tspPrestamos.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspPrestamos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tspPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("tspPrestamos.Image")));
            this.tspPrestamos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspPrestamos.Name = "tspPrestamos";
            this.tspPrestamos.Size = new System.Drawing.Size(84, 22);
            this.tspPrestamos.Text = "Prestamos";
            this.tspPrestamos.Click += new System.EventHandler(this.tspPrestamos_Click);
            // 
            // tspSalir
            // 
            this.tspSalir.BackColor = System.Drawing.Color.LemonChiffon;
            this.tspSalir.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tspSalir.Image = ((System.Drawing.Image)(resources.GetObject("tspSalir.Image")));
            this.tspSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSalir.Name = "tspSalir";
            this.tspSalir.Size = new System.Drawing.Size(56, 22);
            this.tspSalir.Text = "Salir";
            this.tspSalir.Click += new System.EventHandler(this.tspSalir_Click);
            // 
            // lblEstilo
            // 
            this.lblEstilo.BackColor = System.Drawing.Color.Black;
            this.lblEstilo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEstilo.Location = new System.Drawing.Point(-1, 0);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(802, 33);
            this.lblEstilo.TabIndex = 43;
            this.lblEstilo.Text = "BIBLIOTECA";
            this.lblEstilo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstilo.Click += new System.EventHandler(this.lblEstilo_Click);
            // 
            // lblCerrar
            // 
            this.lblCerrar.BackColor = System.Drawing.Color.Red;
            this.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCerrar.Location = new System.Drawing.Point(763, 0);
            this.lblCerrar.Name = "lblCerrar";
            this.lblCerrar.Size = new System.Drawing.Size(38, 33);
            this.lblCerrar.TabIndex = 44;
            this.lblCerrar.Text = "X";
            this.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCerrar.Click += new System.EventHandler(this.lblCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(203, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 98);
            this.label1.TabIndex = 45;
            this.label1.Text = "00:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(325, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 98);
            this.label2.TabIndex = 46;
            this.label2.Text = "00  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(442, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(441, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "AM";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCerrar);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.tspPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.tspPrincipal.ResumeLayout(false);
            this.tspPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspPrincipal;
        private System.Windows.Forms.ToolStripButton tspAutores;
        private System.Windows.Forms.ToolStripButton tspEditoriales;
        private System.Windows.Forms.ToolStripButton tspSalir;
        private System.Windows.Forms.ToolStripButton tspLibros;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblCerrar;
        private System.Windows.Forms.ToolStripButton tspPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}