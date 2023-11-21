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
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
        }

        private void Inscripciones_Load(object sender, EventArgs e)
        {
            dgvInscripciones.DataSource = llenar_grid();

            cbClase.DataSource = llenar_clases();
            cbClase.DisplayMember = "nombre";
            cbClase.ValueMember = "cod_clase";

            cbMiembro.DataSource = llenar_miembros();
            cbMiembro.DisplayMember = "nombre_mie";
            cbMiembro.ValueMember = "cod_mie";
        }

        public DataTable llenar_clases()
        {
            Conexion.Conectar();
            DataTable dt3 = new DataTable();
            string consulta = "SELECT * FROM Clases";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da3 = new SqlDataAdapter(cmd);

            da3.Fill(dt3);
            return dt3;
        }

        public DataTable llenar_miembros()
        {
            Conexion.Conectar();
            DataTable dt2 = new DataTable();
            string consulta = "SELECT * FROM Miembros";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da2 = new SqlDataAdapter(cmd);

            da2.Fill(dt2);
            return dt2;
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Clase_Miembro";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO Clase_Miembro (cod_clase,cod_mie)VALUES(@cod_clase,@cod_mie)";
            SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
            cmd1.Parameters.AddWithValue("@cod_clase", cbClase.SelectedValue.ToString());
            cmd1.Parameters.AddWithValue("@cod_mie", cbMiembro.SelectedValue.ToString());

            cmd1.ExecuteNonQuery();

            MessageBox.Show("Inscripción realizada con éxito");

            dgvInscripciones.DataSource = llenar_grid();
        }

        private void dgvInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbClase.Text = dgvInscripciones.CurrentRow.Cells[0].Value.ToString();
                cbMiembro.Text = dgvInscripciones.CurrentRow.Cells[1].Value.ToString();
            }
            catch { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string actualizar = "UPDATE Clase_Miembro SET cod_clase=@cod_clase, cod_mie=@cod_mie WHERE cod_clase=@cod_clase, cod_mie=@cod_mie";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@cod_clase", cbClase.SelectedValue.ToString());
            cmd2.Parameters.AddWithValue("@cod_mie", cbMiembro.SelectedValue.ToString());

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Datos actualizados con exito");
            dgvInscripciones.DataSource = llenar_grid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string eliminar = "DELETE FROM Clase_Miembro WHERE cod_clase = @cod_clase, cod_mie = @cod_mie";
            SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
            cmd3.Parameters.AddWithValue("@cod_clase", cbClase.SelectedValue.ToString());
            cmd3.Parameters.AddWithValue("@cod_mie", cbMiembro.SelectedValue.ToString());

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Clase eliminada con exito");
            dgvInscripciones.DataSource = llenar_grid();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            Clases clasesFormu = new Clases();
            clasesFormu.Show();
        }

        private void btnAM_Click(object sender, EventArgs e)
        {
            Miembros miembrosFormu = new Miembros();
            miembrosFormu.Show();
        }
    }
}
