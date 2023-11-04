﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYMSTATS
{
    public partial class Clases : Form
    {
        public Clases()
        {
            InitializeComponent();
        }

        private void Clases_Load(object sender, EventArgs e)
        {
            dgvClases.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Clases";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Clases (cod_clase,nombre,descripcion,hora,cod_profe)VALUES(@cod_clase,@nombre,@descripcion,@hora,@cod_profe)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_clase", txtCod.Text);
            cmd1.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@descripcion", txtDesc.Text);
            cmd1.Parameters.AddWithValue("@hora", txtHora.Text);
            cmd1.Parameters.AddWithValue("@cod_profe", txtCodprofe.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Clase agregada con exito");

            dgvClases.DataSource = llenar_grid();
        }

        private void dgvClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCod.Text = dgvClases.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClases.CurrentRow.Cells[1].Value.ToString();
                txtDesc.Text = dgvClases.CurrentRow.Cells[2].Value.ToString();
                txtHora.Text = dgvClases.CurrentRow.Cells[3].Value.ToString();
                txtCodprofe.Text = dgvClases.CurrentRow.Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE Salones SET nombre=@nombre, descripcion=@descripcion, hora=@hora, cod_profe=@cod_profe WHERE cod_clase=@cod_clase";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_clase", txtCod.Text);
            cmd2.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd2.Parameters.AddWithValue("@descripcion", txtDesc.Text);
            cmd2.Parameters.AddWithValue("@hora", txtHora.Text);
            cmd2.Parameters.AddWithValue("@cod_profe", txtCodprofe.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Datos actualizados con exito");
            dgvClases.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM Clases WHERE cod_clase = @cod_clase";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_clase", txtCod.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Clase eliminada con exito");
            dgvClases.DataSource = llenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtNombre.Clear();
            txtDesc.Clear();
            txtHora.Clear();
            txtCodprofe.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            Profesores profesoresFormu = new Profesores();
            profesoresFormu.Show();
        }
    }
}