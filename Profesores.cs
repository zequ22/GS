using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace GYMSTATS
{
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void Profesores_Load(object sender, EventArgs e)
        {
            dgvProfesores.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Profesores";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Profesores (cod_prof,tipo_nro_doc,nombre_prof,apellido_prof,fecha_nac,tel,cbu,cargo)VALUES(@cod_prof,@tipo_nro_doc,@nombre_prof,@apellido_prof,@fecha_nac,@tel,@cbu,@cargo)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_prof", txtCod.Text);
            cmd1.Parameters.AddWithValue("@tipo_nro_doc", txtDoc.Text);
            cmd1.Parameters.AddWithValue("@nombre_prof", txtNombre.Text);
            cmd1.Parameters.AddWithValue("@apellido_prof", txtApellido.Text);
            cmd1.Parameters.AddWithValue("@fecha_nac", txtNac.Text);
            cmd1.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd1.Parameters.AddWithValue("@cbu", txtCbu.Text);
            cmd1.Parameters.AddWithValue("@cargo", txtCargo.Text);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Profesor agregado con exito");

            dgvProfesores.DataSource = llenar_grid();
        }

        private void dgvProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCod.Text = dgvProfesores.CurrentRow.Cells[0].Value.ToString();
                txtDoc.Text = dgvProfesores.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvProfesores.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvProfesores.CurrentRow.Cells[3].Value.ToString();
                txtNac.Text = dgvProfesores.CurrentRow.Cells[4].Value.ToString();
                txtTel.Text = dgvProfesores.CurrentRow.Cells[5].Value.ToString();
                txtCbu.Text = dgvProfesores.CurrentRow.Cells[6].Value.ToString();
                txtCargo.Text = dgvProfesores.CurrentRow.Cells[7].Value.ToString();
            }
            catch { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE Profesores SET tipo_nro_doc=@tipo_nro_doc, nombre_prof=@nombre_prof, apellido_prof=@apellido_prof, fecha_nac=@fecha_nac, tel=@tel, cbu=@cbu, cargo=@cargo WHERE cod_prof=@cod_prof";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_prof", txtCod.Text);
            cmd2.Parameters.AddWithValue("@tipo_nro_doc", txtDoc.Text);
            cmd2.Parameters.AddWithValue("@nombre_prof", txtNombre.Text);
            cmd2.Parameters.AddWithValue("@apellido_prof", txtApellido.Text);
            cmd2.Parameters.AddWithValue("@fecha_nac", txtNac.Text);
            cmd2.Parameters.AddWithValue("@tel", txtTel.Text);
            cmd2.Parameters.AddWithValue("@cbu", txtCbu.Text);
            cmd2.Parameters.AddWithValue("@cargo", txtCargo.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Datos actualizados con exito");
            dgvProfesores.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM Profesores WHERE cod_prof = @cod_prof";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_prof", txtCod.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Profesor eliminado con exito");
            dgvProfesores.DataSource = llenar_grid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtDoc.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNac.Clear();
            txtTel.Clear();
            txtCbu.Clear();
            txtCargo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
