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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
        }

        private void btnMiembros_Click(object sender, EventArgs e)
        {
            Miembros miembrosFormu = new Miembros();
            miembrosFormu.Show();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            Profesores profesoresFormu = new Profesores();
            profesoresFormu.Show();
        }

        private void btnSalones_Click(object sender, EventArgs e)
        {
            Salones salonesFormu = new Salones();
            salonesFormu.Show();
        }

        private void btnClases_Click(object sender, EventArgs e)
        {
            Clases clasesFormu = new Clases();
            clasesFormu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
