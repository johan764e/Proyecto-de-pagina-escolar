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
            // Esta parte determina el rol primero
            string rolFinal = "Alumno";

            if (ProfesorCheck.Checked)
            {
                string claveIngresada = Microsoft.VisualBasic.Interaction.InputBox(
                    "Ingresa la clave de autorización de profesor:",
                    "Validación de Profesor",
                    ""
                );

                string claveSecreta = "1234";

                if (claveIngresada != claveSecreta)
                {
                    MessageBox.Show("La clave de profesor es incorrecta. No se completó el registro.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ProfesorCheck.Checked = false;
                    return;
                }

                rolFinal = "Profesor";
            }

            // Esta parte valida únicamente los campos requeridos según el rol
            // Si es Profesor, NO se valida que txtGrup tenga texto
            bool camposGeneralesVacios = string.IsNullOrWhiteSpace(textNMCM.Text) ||
                                         string.IsNullOrWhiteSpace(txtCorreo2.Text) ||
                                         string.IsNullOrWhiteSpace(txtContraceña.Text) ||
                                         string.IsNullOrWhiteSpace(txtConfContra.Text);

            bool grupoVacioSiEsAlumno = (rolFinal == "Alumno") && string.IsNullOrWhiteSpace(txtGrup.Text);

            if (camposGeneralesVacios || grupoVacioSiEsAlumno)
            {
                MessageBox.Show("Por favor, llena todos los campos obligatorios.", "Campos pendientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Esta parte valida que las contraseñas coincidan
            if (txtContraceña.Text != txtConfContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifícalas.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Esta parte asigna "N/A" si es profesor para guardarlo en la base de datos
            string grupoFinal = (rolFinal == "Profesor") ? "N/A" : txtGrup.Text.Trim();

            // Esta parte envía la información al UsuarioDAO
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            bool registroExitoso = usuarioDAO.RegistrarUsuario(
                textNMCM.Text.Trim(),
                txtCorreo2.Text.Trim(),
                txtContraceña.Text.Trim(),
                grupoFinal,
                rolFinal
            );

            if (registroExitoso)
            {
                MessageBox.Show($"¡Usuario registrado con éxito como {rolFinal}!", "¡Listo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ProfesorCheck_CheckedChanged(object sender, EventArgs e)
        {

            txtGrup.Enabled = !ProfesorCheck.Checked;
            label5.Visible = !ProfesorCheck.Checked;

            if (ProfesorCheck.Checked)
            {
                txtGrup.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
