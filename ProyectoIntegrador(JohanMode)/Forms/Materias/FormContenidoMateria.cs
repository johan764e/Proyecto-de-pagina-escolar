using Microsoft.Data.SqlClient;
using ProyectoIntegrador_JohanMode_.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
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

        private int idMateria;
        private string nombreMateria;
        private string archivoImagen;
        private TareaDAO tareaDAO = new TareaDAO();
        private string rutaArchivoSeleccionado = "";

        private readonly string cadenaConexion = @"Server=JOHAN;Database=ProyectoIntegradorV1;Trusted_Connection=True;";
        private readonly string rutaDesarrollo = @"C:\Users\johan\Downloads\HarryParteIntegrador\HarryParteIntegrador\HarryParteIntegrador\Resources\";

        public FormContenidoMateria(int id, string nombre, string imagen)
        {
            InitializeComponent();

            this.idMateria = id;
            this.nombreMateria = nombre;
            this.archivoImagen = imagen;

            // Inicialización liviana de textos
            if (lblTituloMateria != null)
            {
                lblTituloMateria.Text = nombreMateria;
            }
            this.Text = "Contenido de - " + nombreMateria;

            if (lblArchivoAdjunto != null)
            {
                lblArchivoAdjunto.Text = "Ningún archivo seleccionado";
            }
        }

        private async void FormContenidoMateria_Load(object sender, EventArgs e)
        {
            // Carga asíncrona en segundo plano para no congelar la UI
            await Task.Run(() => CargarImagenDeMateria());
            await Task.Run(() => CargarActividadPendiente());
        }

        private void CargarActividadPendiente()
        {
            try
            {
                var tarea = tareaDAO.ObtenerTareaPendiente(idMateria, Sesion.IdGrupo);

                this.Invoke((MethodInvoker)delegate
                {
                    if (tarea != null)
                    {
                        txtTitulo.Text = tarea.Titulo;
                        txtDescripcion.Text = tarea.Descripcion;
                    }
                    else
                    {
                        txtTitulo.Text = "Sin tareas pendientes";
                        txtDescripcion.Text = "Tu docente no ha asignado actividades para este grupo todavía.";
                    }
                    txtTitulo.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                });
            }
            catch (Exception)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    txtTitulo.Text = "Avance de Proyecto Integrador";
                    txtDescripcion.Text = "Desarrollar la navegación principal de la aplicación Windows Forms.";
                    txtTitulo.ReadOnly = true;
                    txtDescripcion.ReadOnly = true;
                });
            }
        }

        private void CargarImagenDeMateria()
        {
            try
            {
                string rutaAbsoluta = Path.Combine(rutaDesarrollo, archivoImagen);
                string rutaLocal = Path.Combine(Application.StartupPath, "Resources", archivoImagen);
                string rutaFinal = File.Exists(rutaAbsoluta) ? rutaAbsoluta : (File.Exists(rutaLocal) ? rutaLocal : null);

                if (rutaFinal != null)
                {
                    // Lectura con MemoryStream para evitar bloqueos E/S de archivo
                    using (FileStream fs = new FileStream(rutaFinal, FileMode.Open, FileAccess.Read))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            Image img = Image.FromStream(ms);

                            this.Invoke((MethodInvoker)delegate
                            {
                                if (picMateria != null)
                                {
                                    picMateria.Image = img;
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen: " + ex.Message);
            }
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
                        lblArchivoAdjunto.ForeColor = Color.Green;
                    }

                    MessageBox.Show("Archivo cargado con éxito. Presiona 'Enviar' para subirlo a la base de datos.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void txtDescripcion_TextChanged(object sender, EventArgs e) { }
        private void picMateria_Click(object sender, EventArgs e) { }
    }
}