using ProyectoIntegrador_JohanMode_.Datos;
using ProyectoIntegrador_JohanMode_.Forms.Login;
using ProyectoIntegrador_JohanMode_.Forms.Calendario;
using ProyectoIntegrador_JohanMode_.Forms.Materias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoIntegrador_JohanMode_.Forms.Avisos;
using ProyectoIntegrador_JohanMode_.Forms.Asesorias;


namespace ProyectoIntegrador_JohanMode_.Forms.Principal
{
    public partial class FormInicio : Form
    {
        private bool menuCerrado = true;    // El menú inicia cerrado
        private const int AnchoMinimo = 60;  // Ancho del panel cuando solo se ve el botón ☰
        private readonly string rutaDesarrollo = @"C:\Users\johan\Downloads\HarryParteIntegrador\HarryParteIntegrador\HarryParteIntegrador\Resources\";
        private async void FormInicio_Load(object sender, EventArgs e)
        {
            NombredeUsuario.Text = Sesion.NombreUsuario;

            if (Sesion.FotoPerfil != null)
            {
                imgPerfil.Image = Sesion.FotoPerfil;
            }

            // Carga asíncrona de recursos
            await CargarImagenesMateriasAsync();
        }

        private async Task CargarImagenesMateriasAsync()
        {
            // Ejecución en hilo secundario
            Image img1 = await Task.Run(() => ObtenerImagenReal("MateriaProgramacion.png"));
            Image img2 = await Task.Run(() => ObtenerImagenReal("MateriaBasededatos.png"));
            Image img3 = await Task.Run(() => ObtenerImagenReal("MateriaDiseñoGFC.jpg"));
            Image img4 = await Task.Run(() => ObtenerImagenReal("MateriaIntegradora.png"));

            picMateria1.Image = img1;
            picMateria2.Image = img2;
            picMateria3.Image = img3;
            picMateria4.Image = img4;
        }
        public FormInicio()
        {
            InitializeComponent();

            // Nos aseguramos de que empiece cerrado al cargar la pantalla
            pnlMenu.Width = AnchoMinimo;
            // carga las imágenes de las materias al iniciar el formulario
            CargarImagenesMaterias();


        }
        private bool menuAbierto = false;
        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            menuAbierto = !menuAbierto;

            // Botones del menú: aparecen o desaparecen de golpe
            BtnInicio.Visible = menuAbierto;
            BtnPerfil.Visible = menuAbierto;
            BtnCalendario.Visible = menuAbierto;
            BtnAsesorias.Visible = menuAbierto;
            BtonAvisos.Visible = menuAbierto;
            BtnCerrarSesion.Visible = menuAbierto;

            // Panel de notificaciones: comportamiento inverso
            panelnotificasiones.Visible = !menuAbierto;
            panel4.Visible = !menuAbierto;

            pnlMenu.Width = menuAbierto ? 220 : 60;
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
                string rutaFinal = null;
                string rutaAbsoluta = Path.Combine(rutaDesarrollo, nombreArchivo);
                string rutaLocal = Path.Combine(Application.StartupPath, "Resources", nombreArchivo);

                if (File.Exists(rutaAbsoluta))
                {
                    rutaFinal = rutaAbsoluta;
                }
                else if (File.Exists(rutaLocal))
                {
                    rutaFinal = rutaLocal;
                }

                if (rutaFinal != null)
                {
                    // Lectura en MemoryStream para evitar bloqueos de E/S
                    using (FileStream fs = new FileStream(rutaFinal, FileMode.Open, FileAccess.Read))
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            fs.CopyTo(ms);
                            ms.Position = 0;
                            return Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar {nombreArchivo}: {ex.Message}");
            }

            return null;
        }

        private void AbrirMateria(int idMateria, string nombreMateria, string archivoImagen)
        {
            FormContenidoMateria pantallaMateria = new FormContenidoMateria(idMateria, nombreMateria, archivoImagen);

            this.Hide();
            pantallaMateria.ShowDialog();
            this.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
        }

        private void BtonAvisos_Click(object sender, EventArgs e)
        {
            FormListaAvisos formAvisos = new FormListaAvisos();
            formAvisos.Show();
        }

        private void BtnAsesorias_Click(object sender, EventArgs e)
        {
            FormAsesorias formAsesorias = new FormAsesorias();
            formAsesorias.Show();
        }

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            FrmCalendario formCalendario = new FrmCalendario();
            formCalendario.Show();
        }

        private void BtnPerfil_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            //Confirma si el usuario realmente desea salir
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Confirmar Cierre de Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                // Limpia las variables de la sesión global
                Sesion.IdUsuario = 0;
                Sesion.NombreUsuario = string.Empty;
                Sesion.IdGrupo = 0;
                Sesion.FotoPerfil = null;

                //Crear e instanciar la pantalla de Login
                ProyectoIntegrador_JohanMode_.Form1 login = new ProyectoIntegrador_JohanMode_.Form1();
                login.Show();


                //Cerrar el formulario actual
                this.Close();
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgPerfil_Click(object sender, EventArgs e)
        {

        }

        private void NombredeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notificaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
