using System;
using System.Windows.Forms;
using ProyectoIntegrador_JohanMode_.Modelos;

namespace ProyectoIntegrador_JohanMode_.Forms.Avisos
{
    public partial class FormDetalleAviso : Form
    {
        private readonly Aviso _aviso; // Almacena el aviso
        private readonly Form _formPadre; // Almacena la ventana previa

        // aviso: datos a mostrar | formPadre: ventana para regresar
        public FormDetalleAviso(Aviso aviso, Form formPadre)
        {
            InitializeComponent();
            _aviso = aviso;
            _formPadre = formPadre;
        }

        // Carga los datos del aviso en la interfaz
        private void FormDetalleAviso_Load(object sender, EventArgs e)
        {
            if (_aviso != null)
            {
                lblTituloAviso.Text = _aviso.Titulo; // Asigna el título
                lblFechaAviso.Text = _aviso.Fecha.ToString("dd/MM/yyyy HH:mm"); // Asigna la fecha
                txtContenido.Text = _aviso.Contenido; // Asigna el contenido
            }
        }

        // Clic en botón regresar 
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            RegresarPantallaAnterior();
        }

        // Cierre por la "X"
        private void FormDetalleAviso_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegresarPantallaAnterior();
        }

        // Muestra la ventana anterior y libera la memoria de la actual
        private void RegresarPantallaAnterior()
        {
            if (_formPadre != null && !_formPadre.IsDisposed)
            {
                _formPadre.Show();
            }
            this.Dispose();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}