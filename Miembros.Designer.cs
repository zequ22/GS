namespace GYMSTATS
{
    partial class Miembros
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
            this.gYMSTATSDataSet = new GYMSTATS.GYMSTATSDataSet();
            this.gYMSTATSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMiembros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).BeginInit();
            this.SuspendLayout();
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
            // dgvMiembros
            // 
            this.dgvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembros.Location = new System.Drawing.Point(12, 12);
            this.dgvMiembros.Name = "dgvMiembros";
            this.dgvMiembros.Size = new System.Drawing.Size(240, 150);
            this.dgvMiembros.TabIndex = 0;
            // 
            // Miembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMiembros);
            this.Name = "Miembros";
            this.Text = "Miembros";
            this.Load += new System.EventHandler(this.Miembros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMSTATSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource gYMSTATSDataSetBindingSource;
        private GYMSTATSDataSet gYMSTATSDataSet;
        private System.Windows.Forms.DataGridView dgvMiembros;
    }
}