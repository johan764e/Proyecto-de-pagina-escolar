using Microsoft.Data.SqlClient;
using ProyectoIntegrador.Datos;
using ProyectoIntegrador_JohanMode_.Forms.Login;

namespace ProyectoIntegrador_JohanMode_
{
    public partial class Form1 : Form
    {
        // coneccion con base de datos
        private void FormLogin_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();
                MessageBox.Show("Conexión exitosa");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtonOlvidoContra_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();

            // Le pasamos este login como su "propietario" o "dueño"
            registro.Owner = this;

            registro.Show();
            this.Hide();
        }

        private void BtonINISesion_Click(object sender, EventArgs e)
        {

        }

        private void TextCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraceña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
