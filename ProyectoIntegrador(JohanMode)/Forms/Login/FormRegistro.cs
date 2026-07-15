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
            // 1. Validamos todos tus campos usando tus variables reales
            if (string.IsNullOrWhiteSpace(textNMCM.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo2.Text) ||
                string.IsNullOrWhiteSpace(txtContraceña.Text) ||
                string.IsNullOrWhiteSpace(txtConfContra.Text) ||
                string.IsNullOrWhiteSpace(txtGrup.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Campos pendientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validamos que ambas contraseñas coincidan antes de mandar a la BD
            if (txtContraceña.Text != txtConfContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Verifícalas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Instanciamos nuestra clase de datos
            UsuarioDAO usuarioDAO = new UsuarioDAO();

            // 4. Enviamos los datos a la base de datos (incluyendo el grupo)
            bool registroExitoso = usuarioDAO.RegistrarUsuario(
                textNMCM.Text.Trim(),
                txtCorreo2.Text.Trim(),
                txtContraceña.Text.Trim(),
                txtGrup.Text.Trim()
            );

            // 5. Evaluamos la respuesta
            if (registroExitoso)
            {
                MessageBox.Show("¡Usuario registrado con éxito!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Buscamos el formulario de Login de forma genérica en la memoria
                bool loginAbierto = false;

                foreach (Form frm in Application.OpenForms)
                {
                    // Buscamos cualquier formulario que se llame FormLogin
                    if (frm.Name == "FormLogin")
                    {
                        frm.Show();
                        loginAbierto = true;
                        break;
                    }
                }

                // Si por alguna razón el Login no estaba abierto en segundo plano
                if (!loginAbierto)
                {
                    MessageBox.Show("El registro fue exitoso. Por favor, reinicia la aplicación para iniciar sesión.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Destruimos la pantalla de registro para no acumular ventanas abiertas
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
