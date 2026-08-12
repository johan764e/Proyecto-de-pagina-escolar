using Microsoft.Data.SqlClient;
using ProyectoIntegrador.Datos;
using ProyectoIntegrador_JohanMode_.Datos;
using ProyectoIntegrador_JohanMode_.Forms.Login;
using ProyectoIntegrador_JohanMode_.Forms.Principal;

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

            // Esta parte valida que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TextCorreoElectronico.Text) || string.IsNullOrWhiteSpace(textContraceña.Text))
            {
                MessageBox.Show("Por favor, introduce tu correo y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UsuarioDAO usuarioDAO = new UsuarioDAO();

            // Esta parte consulta la base de datos y asigna la sesión
            bool accesoConcedido = usuarioDAO.ValidarUsuario(TextCorreoElectronico.Text.Trim(), textContraceña.Text.Trim());

            if (accesoConcedido)
            {
                MessageBox.Show($"¡Bienvenido {Sesion.NombreUsuario}! (Rol: {Sesion.Rol})", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Esta parte crea la nueva ventana del menú principal
                FormInicio inicio = new FormInicio();

                // Muestra la pantalla principal primero
                inicio.Show();

                // Oculta la pantalla de login actual
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos. Intente de nuevo.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        
    }
}
