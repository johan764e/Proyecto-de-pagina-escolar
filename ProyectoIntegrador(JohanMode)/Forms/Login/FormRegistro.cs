using ProyectoIntegrador_JohanMode_.Datos;
using ProyectoIntegrador_JohanMode_.Forms.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador_JohanMode_.Forms.Login
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        private void textNMCM_TextChanged(object sender, EventArgs e)
        {

        }
        private void FormRegistro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Chistepdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtContraceña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrup_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            // Pregunta si este formulario tiene un propietario asignado
            if (this.Owner != null)
            {
                // Vuelve a mostrar el formulario que nos abrió (el Login)
                this.Owner.Show();
            }

            // Cierra la ventana actual
            this.Close();
        }

        private void BtnRegistrar2_Click(object sender, EventArgs e)
        {
            // 1. Validamos que el usuario no deje campos vacíos usando tus nombres de TextBox reales
            if (string.IsNullOrWhiteSpace(textNMCM.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo2.Text) ||
                string.IsNullOrWhiteSpace(txtContraceña.Text) ||
                string.IsNullOrWhiteSpace(txtConfContra.Text) ||
                string.IsNullOrWhiteSpace(txtGrup.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campos pendientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validamos que la contraseña y la confirmación coincidan
            if (txtContraceña.Text != txtConfContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Instanciamos la clase de base de datos
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            // 4. Enviamos la información a registrar (pasando el grupo)
            bool registroExitoso = usuarioDAO.RegistrarUsuario(
                textNMCM.Text.Trim(),
                txtCorreo2.Text.Trim(),
                txtContraceña.Text.Trim(),
                txtGrup.Text.Trim()
            );

            // 5. Evaluamos la respuesta de la base de datos
            if (registroExitoso)
            {
                MessageBox.Show("¡Usuario registrado con éxito!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Redireccionamos limpiamente de vuelta al login usando la memoria de la aplicación
                // Esto evita errores de compilación por namespaces incorrectos
                bool loginAbierto = false;

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FormLogin")
                    {
                        frm.Show();
                        loginAbierto = true;
                        break;
                    }
                }

                // En caso extremo de que el Login no estuviera cargado en memoria, lo iniciamos de forma segura
                if (!loginAbierto)
                {
                    MessageBox.Show("Por favor, reinicie la aplicación para iniciar sesión.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Destruimos la pantalla de registro de la memoria RAM para evitar que el programa se ponga lento
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el usuario. Revisa tu conexión a la base de datos.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
