namespace GYMSTATS
{
    partial class Clases
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClases = new System.Windows.Forms.DataGridView();
            this.btnAP = new System.Windows.Forms.Button();
            this.gYMSTATSDataSet = new GYMSTATS.GYMSTATSDataSet();
            this.gYMSTATSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSalon = new System.Windows.Forms.ComboBox();
            this.btnAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(417, 330);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(129, 23);
            this.btnLimpiar.TabIndex = 65;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(552, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 23);
            this.btnSalir.TabIndex = 64;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(282, 330);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 23);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(147, 330);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 23);
            this.btnModificar.TabIndex = 62;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 330);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 23);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Profesor:";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(374, 64);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Hora:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(374, 25);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(268, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(268, 25);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Codigo:";
            // 
            // dgvClases
            // 
            this.dgvClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClases.Location = new System.Drawing.Point(12, 91);
            this.dgvClases.Name = "dgvClases";
            this.dgvClases.Size = new System.Drawing.Size(669, 233);
            this.dgvClases.TabIndex = 44;
            this.dgvClases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClases_CellContentClick);
            // 
            // btnAP
            // 
            this.btnAP.Location = new System.Drawing.Point(586, 62);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(95, 23);
            this.btnAP.TabIndex = 66;
            this.btnAP.Text = "Agregar profesor";
            this.btnAP.UseVisualStyleBackColor = true;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // gYMSTATSDataSet
            // 
            this.gYMSTATSDataSet.DataSetName = "GYMSTATSDataSet";
            this.gYMSTATSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gYMSTATSDataSetBindingSource
            // 
            this.gYMSTATSDataSetBindingSource.DataSource = this.gYMSTATSDataSet;
            this.gYMSTATSDataSetBindingSource.Position = 0;
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(480, 63);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(100, 21);
            this.cbProfesor.TabIndex = 67;
            this.cbProfesor.Text = "Seleccione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Salon:";
            // 
            // cbSalon
            // 
            this.cbSalon.FormattingEnabled = true;
            this.cbSalon.Location = new System.Drawing.Point(480, 24);
            this.cbSalon.Name = "cbSalon";
            this.cbSalon.Size = new System.Drawing.Size(100, 21);
            this.cbSalon.TabIndex = 69;
            this.cbSalon.Text = "Seleccione";
            // 
            // btnAS
            // 
            this.btnAS.Location = new System.Drawing.Point(586, 22);
            this.btnAS.Name = "btnAS";
            this.btnAS.Size = new System.Drawing.Size(95, 23);
            this.btnAS.TabIndex = 70;
            this.btnAS.Text = "Agregar Salon";
            this.btnAS.UseVisualStyleBackColor = true;
            this.btnAS.Click += new System.EventHandler(this.btnAS_Click);
            // 
            // Clases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 377);
            this.Controls.Add(this.btnAS);
            this.Controls.Add(this.cbSalon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClases);
            this.Name = "Clases";
            this.Text = "Clases";
            this.Load += new System.EventHandler(this.Clases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClases;
        private System.Windows.Forms.Button btnAP;
        private GYMSTATSDataSet gYMSTATSDataSet;
        private System.Windows.Forms.BindingSource gYMSTATSDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSalon;
        private System.Windows.Forms.Button btnAS;
    }
}