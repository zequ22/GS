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
using System.Text.RegularExpressions;

namespace GYMSTATS
{
    public partial class Miembros : Form
    {
        public Miembros()
        {
            InitializeComponent();
        }

        private void Miembros_Load(object sender, EventArgs e)
        {
            dgvMiembros.DataSource = llenar_grid();
            //
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM Miembros";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //aca

            if (ValidarNumeroEntero(txtCod) &&
                ValidarLetrasSinEspacios(txtNombre) &&
                ValidarLetrasSinEspacios(txtApellido) &&
                ValidarNumeroEntero(txtTel) &&
                ValidarFecha(txtNac) &&
                ValidarEmail(txtCorreo) &&
                ValidarNoVacio(txtEstado))
            {
                MessageBox.Show("Validaciones son exitosas");

                Conexion.Conectar();
                string insertar = "INSERT INTO Miembros (cod_mie,tipo_nro_doc,nombre_mie,apellido_mie,fecha_nac,tel,estado,correo)VALUES(@cod_mie,@tipo_nro_doc,@nombre_mie,@apellido_mie,@fecha_nac,@tel,@estado,@correo)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@cod_mie", txtCod.Text);
                cmd1.Parameters.AddWithValue("@tipo_nro_doc", txtDoc.Text);
                cmd1.Parameters.AddWithValue("@nombre_mie", txtNombre.Text);
                cmd1.Parameters.AddWithValue("@apellido_mie", txtApellido.Text);
                cmd1.Parameters.AddWithValue("@fecha_nac", txtNac.Text);
                cmd1.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd1.Parameters.AddWithValue("@estado", txtEstado.Text);
                cmd1.Parameters.AddWithValue("@correo", txtCorreo.Text);

                cmd1.ExecuteNonQuery();

                MessageBox.Show("Miembro agregado con exito");

                dgvMiembros.DataSource = llenar_grid();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void dgvMiembros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCod.Text = dgvMiembros.CurrentRow.Cells[0].Value.ToString();
                txtDoc.Text = dgvMiembros.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvMiembros.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvMiembros.CurrentRow.Cells[3].Value.ToString();
                txtNac.Text = dgvMiembros.CurrentRow.Cells[4].Value.ToString();
                txtTel.Text = dgvMiembros.CurrentRow.Cells[5].Value.ToString();
                txtEstado.Text = dgvMiembros.CurrentRow.Cells[6].Value.ToString();
                txtCorreo.Text = dgvMiembros.CurrentRow.Cells[7].Value.ToString();
            }
            catch { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarNumeroEntero(txtCod) &&
                ValidarLetrasSinEspacios(txtNombre) &&
                ValidarLetrasSinEspacios(txtApellido) &&
                ValidarNumeroEntero(txtTel) &&
                ValidarFecha(txtNac) &&
                ValidarEmail(txtCorreo) &&
                ValidarNoVacio(txtEstado))
            {
                MessageBox.Show("Validaciones son exitosas");

                Conexion.Conectar();
                string actualizar = "UPDATE Miembros SET tipo_nro_doc=@tipo_nro_doc, nombre_mie=@nombre_mie, apellido_mie=@apellido_mie, fecha_nac=@fecha_nac, tel=@tel, estado=@estado, correo=@correo WHERE cod_mie=@cod_mie";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@cod_mie", txtCod.Text);
                cmd2.Parameters.AddWithValue("@tipo_nro_doc", txtDoc.Text);
                cmd2.Parameters.AddWithValue("@nombre_mie", txtNombre.Text);
                cmd2.Parameters.AddWithValue("@apellido_mie", txtApellido.Text);
                cmd2.Parameters.AddWithValue("@fecha_nac", txtNac.Text);
                cmd2.Parameters.AddWithValue("@tel", txtTel.Text);
                cmd2.Parameters.AddWithValue("@estado", txtEstado.Text);
                cmd2.Parameters.AddWithValue("@correo", txtCorreo.Text);

                cmd2.ExecuteNonQuery();

                MessageBox.Show("Datos actualizados con exito");
                dgvMiembros.DataSource = llenar_grid();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarNumeroEntero(txtCod))
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Miembros WHERE cod_mie = @cod_mie";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@cod_mie", txtCod.Text);

                cmd3.ExecuteNonQuery();

                MessageBox.Show("Miembro eliminado con exito");
                dgvMiembros.DataSource = llenar_grid();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un miembro para ser eliminado");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCod.Clear();
            txtDoc.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtNac.Clear();
            txtTel.Clear();
            txtEstado.Clear();
            txtCorreo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region VALIDACIONES
        private bool ValidarNumeroEntero(TextBox textBox)
        {
            int numero;
            return int.TryParse(textBox.Text, out numero);
        }

        private bool ValidarLetrasSinEspacios(TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text) && Regex.IsMatch(textBox.Text, "^[a-zA-Z]+$");
        }

        private bool ValidarFecha(TextBox textBox)
        {
            DateTime fecha;
            if (DateTime.TryParse(textBox.Text, out fecha))
            {
                return fecha.Hour == 0 && fecha.Minute == 0;
            }
            return false;
        }

        private bool ValidarEmail(TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text) && Regex.IsMatch(textBox.Text, @"^\w+@\w+\.\w+$");
        }

        private bool ValidarNoVacio(TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
        #endregion
    }
}
