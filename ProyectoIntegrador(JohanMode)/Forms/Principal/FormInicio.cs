using ProyectoIntegrador_JohanMode_.Forms.Materias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador_JohanMode_.Forms.Principal
{
    public partial class FormInicio : Form
    {
        private bool menuCerrado = true;    // El menú inicia cerrado
        private const int AnchoMinimo = 60;  // Ancho del panel cuando solo se ve el botón ☰
        private readonly string rutaDesarrollo = @"C:\Users\johan\Downloads\HarryParteIntegrador\HarryParteIntegrador\HarryParteIntegrador\Resources\";
        public FormInicio()
        {
            InitializeComponent();

            // Nos aseguramos de que empiece cerrado al cargar la pantalla
            pnlMenu.Width = AnchoMinimo;
            // carga las imágenes de las materias al iniciar el formulario
            CargarImagenesMaterias();
        }
        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }
        // 2. Evento Tick del Timer (se ejecuta repetidamente para animar)
        private void timerMenu_Tick_1(object sender, EventArgs e)
        {
            // Calculamos dinámicamente el 25% (un cuarto) del ancho actual de tu ventana
            int anchoMaximo = this.ClientSize.Width / 4;

            if (menuCerrado)
            {
                // Si está cerrado, lo estiramos hacia la derecha (+ ancho)
                pnlMenu.Width += 25; // Velocidad de apertura (puedes aumentarlo o disminuirlo)

                // Si alcanza o supera el cuarto de pantalla, detenemos la animación
                if (pnlMenu.Width >= anchoMaximo)
                {
                    pnlMenu.Width = anchoMaximo;
                    menuCerrado = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                // Si está abierto, lo encogemos hacia la izquierda (- ancho)
                pnlMenu.Width -= 25;

                // Si vuelve a su tamaño mínimo, detenemos la animación
                if (pnlMenu.Width <= AnchoMinimo)
                {
                    pnlMenu.Width = AnchoMinimo;
                    menuCerrado = true;
                    timerMenu.Stop();
                }
            }
        }

        private void CargarImagenesMaterias()
        {
            // Asignamos a cada uno de tus 4 PictureBox su respectiva imagen real
            picMateria1.Image = ObtenerImagenReal("MateriaProgramacion.png");
            picMateria2.Image = ObtenerImagenReal("MateriaBasededatos.png");
            picMateria3.Image = ObtenerImagenReal("MateriaDiseñoGFC.jpg");
            picMateria4.Image = ObtenerImagenReal("MateriaIntegradora.png");
        }

        private Image BuscarImagen(string rutaCarpeta, string nombreArchivo)
        {
            string rutaPng = Path.Combine(rutaCarpeta, nombreArchivo + ".png");
            string rutaJpg = Path.Combine(rutaCarpeta, nombreArchivo + ".jpg");

            if (File.Exists(rutaPng))
            {
                return Image.FromFile(rutaPng);
            }
            else if (File.Exists(rutaJpg))
            {
                return Image.FromFile(rutaJpg);
            }

            string rutaLogoDefecto = Path.Combine(rutaCarpeta, "LogoSample_ByTailorBrands.jpg");
            if (File.Exists(rutaLogoDefecto))
            {
                return Image.FromFile(rutaLogoDefecto);
            }

            return null;
        }
        // busca la imagen en la carpeta de desarrollo y si no la encuentra, busca en la carpeta local del proyecto
        private Image ObtenerImagenReal(string nombreArchivo)
        {
            try
            {
                // 1. Buscamos primero en tu carpeta absoluta de descargas
                string rutaAbsoluta = Path.Combine(rutaDesarrollo, nombreArchivo);
                if (File.Exists(rutaAbsoluta))
                {
                    return Image.FromFile(rutaAbsoluta);
                }

                // 2. Buscamos en la carpeta local del proyecto si lo corres en otra PC
                string rutaLocal = Path.Combine(Application.StartupPath, "Resources", nombreArchivo);
                if (File.Exists(rutaLocal))
                {
                    return Image.FromFile(rutaLocal);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar la imagen " + nombreArchivo + ": " + ex.Message);
            }

            return null; // Si no la encuentra, se queda el espacio en gris sin crashear
        }
       
        private void AbrirMateria(int idMateria, string nombreMateria, string archivoImagen)
        {
            FormContenidoMateria pantallaMateria = new FormContenidoMateria(idMateria, nombreMateria, archivoImagen);

            this.Hide();
            pantallaMateria.ShowDialog();
            this.Show();
        }
        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void picMateria2_Click_1(object sender, EventArgs e)
        {
            AbrirMateria(2, "Bases de Datos", "MateriaBasededatos.png");
        }

        private void picMateria1_Click_1(object sender, EventArgs e)
        {
            AbrirMateria(1, "Programación", "MateriaProgramacion.png");
        }

        private void picMateria3_Click_1(object sender, EventArgs e)
        {
            AbrirMateria(3, "Diseño GFC", "MateriaDiseñoGFC.jpg");
        }

        private void picMateria4_Click_1(object sender, EventArgs e)
        {
            AbrirMateria(4, "Integradora", "MateriaIntegradora.png");
        }
    }
}
