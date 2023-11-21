namespace GYMSTATS
{
    partial class Principal
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
            this.btnMiembros = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnSalones = new System.Windows.Forms.Button();
            this.btnClases = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMiembros
            // 
            this.btnMiembros.Location = new System.Drawing.Point(12, 12);
            this.btnMiembros.Name = "btnMiembros";
            this.btnMiembros.Size = new System.Drawing.Size(75, 23);
            this.btnMiembros.TabIndex = 0;
            this.btnMiembros.Text = "Miembros";
            this.btnMiembros.UseVisualStyleBackColor = true;
            this.btnMiembros.Click += new System.EventHandler(this.btnMiembros_Click);
            // 
            // btnProfesores
            // 
            this.btnProfesores.Location = new System.Drawing.Point(12, 41);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(75, 23);
            this.btnProfesores.TabIndex = 1;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnSalones
            // 
            this.btnSalones.Location = new System.Drawing.Point(12, 70);
            this.btnSalones.Name = "btnSalones";
            this.btnSalones.Size = new System.Drawing.Size(75, 23);
            this.btnSalones.TabIndex = 2;
            this.btnSalones.Text = "Salones";
            this.btnSalones.UseVisualStyleBackColor = true;
            this.btnSalones.Click += new System.EventHandler(this.btnSalones_Click);
            // 
            // btnClases
            // 
            this.btnClases.Location = new System.Drawing.Point(12, 99);
            this.btnClases.Name = "btnClases";
            this.btnClases.Size = new System.Drawing.Size(75, 23);
            this.btnClases.TabIndex = 3;
            this.btnClases.Text = "Clases";
            this.btnClases.UseVisualStyleBackColor = true;
            this.btnClases.Click += new System.EventHandler(this.btnClases_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Location = new System.Drawing.Point(12, 128);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(75, 23);
            this.btnInscripciones.TabIndex = 5;
            this.btnInscripciones.Text = "Inscripciones";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.btnInscripciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnClases);
            this.Controls.Add(this.btnSalones);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnMiembros);
            this.Name = "Principal";
            this.Text = "GYMSTATS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMiembros;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnSalones;
        private System.Windows.Forms.Button btnClases;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInscripciones;
    }
}

