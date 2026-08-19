using Microsoft.Data.SqlClient;
using ProyectoIntegrador.Datos;
using ProyectoIntegrador_JohanMode_.Datos;
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

        private void TextCorreoElectronico_TextChanged(object sender, EventArgs e)
        {

        }

        private void textContraceña_TextChanged(object sender, EventArgs e)
        {

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
            // 1. Validamos usando los nuevos nombres de tus cuadros de texto
            if (string.IsNullOrWhiteSpace(TextCorreoElectronico.Text) || string.IsNullOrWhiteSpace(textContraceña.Text))
            {
                MessageBox.Show("Por favor, introduce tu correo y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Instanciamos la clase de datos (UsuarioDAO)
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            // 3. Consultamos la base de datos usando tus TextBox
            bool accesoConcedido = usuarioDAO.ValidarUsuario(TextCorreoElectronico.Text.Trim(), textContraceña.Text.Trim());

            if (accesoConcedido)
            {
                MessageBox.Show("¡Bienvenido al sistema!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí puedes abrir tu pantalla principal cuando la tengas lista
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos. Intente de nuevo.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        
    }
}
