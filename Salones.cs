using System;
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
    public partial class Salones : Form
    {
        public Salones()
        {
            InitializeComponent();
        }

        private void Salones_Load(object sender, EventArgs e)
        {
            dgvSalones.DataSource = llenar_grid();
        }
        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Salones";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Salones (cod_salon,descripcion)VALUES(@cod_salon,@descripcion)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_salon", txtCod.Text);
            cmd1.Parameters.AddWithValue("@descripcion", txtDesc.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Salon agregado con exito");

            dgvSalones.DataSource = llenar_grid();
        }

        private void dgvSalones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCod.Text = dgvSalones.CurrentRow.Cells[0].Value.ToString();
                txtDesc.Text = dgvSalones.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE Salones SET descripcion=@descripcion WHERE cod_salon=@cod_salon";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_salon", txtCod.Text);
            cmd2.Parameters.AddWithValue("@descripcion", txtDesc.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Datos actualizados con exito");
            dgvSalones.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM Salones WHERE cod_salones = @cod_salones";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_salones", txtCod.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Salon eliminado con exito");
            dgvSalones.DataSource = llenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtDesc.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
