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
        private void FormInicio_Load(object sender, EventArgs e)
        {
            if (Sesion.FotoPerfil != null)
            {
                imgPerfil.Image = Sesion.FotoPerfil;
                MessageBox.Show("¡Foto de perfil asignada correctamente!", "Prueba");
            }
            else
            {
                MessageBox.Show("Sesion.FotoPerfil es NULL. La imagen no se leyó bien en el Login.", "Error de Diagnóstico");
            }

            imgPerfil.Image = Sesion.FotoPerfil;
            NombredeUsuario.Text = Sesion.NombreUsuario;

            if (Sesion.FotoPerfil != null)
            {
                imgPerfil.Image = Sesion.FotoPerfil;
            }
        }
        public FormInicio()
        {
            InitializeComponent();
            // carga las imágenes de las materias al iniciar el formulario
            CargarImagenesMaterias();

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
        private void btnHamburguesa_Click(object sender, EventArgs e)
        {
            menuCerrado = !menuCerrado;

            // Cambiamos la visibilidad de los botones directamente
            BtnInicio.Visible = !menuCerrado;
            BtnPerfil.Visible = !menuCerrado;
            BtnCalendario.Visible = !menuCerrado;
            BtnAsesorias.Visible = !menuCerrado;
            BtonAvisos.Visible = !menuCerrado;
            BtnCerrarSesion.Visible = !menuCerrado;

            // Paneles secundarios
            panelnotificasiones.Visible = menuCerrado;
            panel4.Visible = menuCerrado;

        }



        // Método auxiliar para limpiar tu código y evitar repeticiones
        private void AlternarVisibilidadBotones(bool mostrar)
        {
            menuCerrado = !menuCerrado;

            // Cambiamos la visibilidad de los botones directamente
            BtnInicio.Visible = !menuCerrado;
            BtnPerfil.Visible = !menuCerrado;
            BtnCalendario.Visible = !menuCerrado;
            BtnAsesorias.Visible = !menuCerrado;
            BtonAvisos.Visible = !menuCerrado;
            BtnCerrarSesion.Visible = !menuCerrado;

            // Paneles secundarios
            panelnotificasiones.Visible = menuCerrado;
            panel4.Visible = menuCerrado;
        }


        private void CargarImagenesMaterias()
        {
            // Asigna a cada uno de tus 4 PictureBox su respectiva imagen real
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
                // 1. Busca primero en tu carpeta absoluta de descargas
                string rutaAbsoluta = Path.Combine(rutaDesarrollo, nombreArchivo);
                if (File.Exists(rutaAbsoluta))
                {
                    return Image.FromFile(rutaAbsoluta);
                }

                // 2. Busca en la carpeta local del proyecto si lo corres en otra PC
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

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
