using Microsoft.Data.SqlClient;
using ProyectoIntegrador_JohanMode_.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador_JohanMode_.Forms.Materias
{
    public partial class FormContenidoMateria : Form
    {
        public FormContenidoMateria()
        {
            InitializeComponent();
        }
        // Variables internas para los datos de la materia
        private int idMateria;
        private string nombreMateria;
        private string archivoImagen;
        private TareaDAO tareaDAO = new TareaDAO();

        // Variable para guardar la ruta del archivo seleccionado temporalmente antes de subirlo
        private string rutaArchivoSeleccionado = "";

        // Cadena de conexión a tu base de datos local
        private readonly string cadenaConexion = @"Server=JOHAN;Database=ProyectoIntegradorV1;Trusted_Connection=True;";
        private readonly string rutaDesarrollo = @"C:\Users\johan\Downloads\HarryParteIntegrador\HarryParteIntegrador\HarryParteIntegrador\Resources\";

        public FormContenidoMateria(int id, string nombre, string imagen)
        {
            InitializeComponent();

            this.idMateria = id;
            this.nombreMateria = nombre;
            this.archivoImagen = imagen;

            // Inicializar textos en pantalla
            if (lblTituloMateria != null)
            {
                lblTituloMateria.Text = nombreMateria;
            }
            this.Text = "Contenido de - " + nombreMateria;

            // Inicializar estado del archivo adjunto
            if (lblArchivoAdjunto != null)
            {
                lblArchivoAdjunto.Text = "Ningún archivo seleccionado";
            }
            // Cargar la imagen de la materia al iniciar el formulario
            CargarImagenDeMateria();
            CargarActividadPendiente();
        }
        private void CargarActividadPendiente()
        {
            try
            {
                // Llamamos al DAO en lugar de hacer la consulta SQL aquí
                var tarea = tareaDAO.ObtenerTareaPendiente(idMateria, Sesion.IdGrupo);

                if (tarea != null)
                {
                    txtTitulo.Text = tarea.Titulo;
                    txtDescripcion.Text = tarea.Descripcion;
                    txtTitulo.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                }
                else
                {
                    txtTitulo.Text = "Sin tareas pendientes";
                    txtDescripcion.Text = "Tu docente no ha asignado actividades para este grupo todavía.";
                    txtTitulo.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                // Si no hay conexión, usamos el Plan B de seguridad
                txtTitulo.Text = "Avance de Proyecto Integrador";
                txtDescripcion.Text = "Desarrollar la navegación principal de la aplicación Windows Forms.";
            }
        }
        private void CargarImagenDeMateria()
        {
            try
            {
                PictureBox picContenido = this.picMateria;

                if (picContenido != null)
                {
                    string rutaAbsoluta = Path.Combine(rutaDesarrollo, archivoImagen);
                    if (File.Exists(rutaAbsoluta))
                    {
                        picContenido.Image = Image.FromFile(rutaAbsoluta);
                        return;
                    }

                    string rutaLocal = Path.Combine(Application.StartupPath, "Resources", archivoImagen);
                    if (File.Exists(rutaLocal))
                    {
                        picContenido.Image = Image.FromFile(rutaLocal);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen de la materia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormContenidoMateria_Load(object sender, EventArgs e)
        {

        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar entrega para " + nombreMateria;
                ofd.Filter = "Documentos (*.pdf;*.docx)|*.pdf;*.docx|Imágenes (*.jpg;*.png)|*.jpg;*.png|Todos los archivos (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoSeleccionado = ofd.FileName;

                    if (lblArchivoAdjunto != null)
                    {
                        lblArchivoAdjunto.Text = Path.GetFileName(rutaArchivoSeleccionado);
                        lblArchivoAdjunto.ForeColor = Color.Green; // Visualmente indica que hay algo listo
                    }

                    MessageBox.Show("Archivo cargado con éxito. Presiona 'Enviar' para subirlo a la base de datos.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || txtTitulo.Text == "Sin tareas pendientes")
            {
                MessageBox.Show("No hay una actividad válida para entregar.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Enviamos usando el método del DAO
                bool exito = tareaDAO.InsertarEntrega(
                    idMateria,
                    Sesion.IdUsuario,
                    txtTitulo.Text.Trim(),
                    txtDescripcion.Text.Trim(),
                    rutaArchivoSeleccionado
                );

                if (exito)
                {
                    MessageBox.Show($"¡Felicidades {Sesion.NombreUsuario}! Tu entrega ha sido registrada con éxito.",
                                    "Envío Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un problema: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoSeleccionado))
            {
                MessageBox.Show("No has seleccionado ningún archivo todavía. Usa el botón 'Adjuntar' primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simplemente volvemos a abrir el explorador de archivos para sustituir el actual
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Reemplazar archivo de entrega";
                ofd.Filter = "Documentos (*.pdf;*.docx)|*.pdf;*.docx|Imágenes (*.jpg;*.png)|*.jpg;*.png|Todos los archivos (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoSeleccionado = ofd.FileName;

                    if (lblArchivoAdjunto != null)
                    {
                        lblArchivoAdjunto.Text = Path.GetFileName(rutaArchivoSeleccionado) + " (Modificado)";
                        lblArchivoAdjunto.ForeColor = Color.DarkOrange;
                    }

                    MessageBox.Show("El archivo anterior fue reemplazado por: " + Path.GetFileName(rutaArchivoSeleccionado), "Archivo Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoSeleccionado))
            {
                MessageBox.Show("No hay ningún archivo adjunto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Seguro que quieres quitar el archivo seleccionado?", "Eliminar adjunto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                rutaArchivoSeleccionado = "";

                if (lblArchivoAdjunto != null)
                {
                    lblArchivoAdjunto.Text = "Ningún archivo seleccionado";
                    lblArchivoAdjunto.ForeColor = Color.Black;
                }

                MessageBox.Show("El archivo adjunto fue removido correctamente.", "Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarFormulario()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            rutaArchivoSeleccionado = "";
            if (lblArchivoAdjunto != null)
            {
                lblArchivoAdjunto.Text = "Ningún archivo seleccionado";
                lblArchivoAdjunto.ForeColor = Color.Black;
            }
        }

        private void picMateria_Click(object sender, EventArgs e)
        {

        }
    }
}
