using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ProyectoIntegrador_JohanMode_.Datos;
using ProyectoIntegrador_JohanMode_.Modelos;

namespace ProyectoIntegrador_JohanMode_.Forms.Avisos
{
    public partial class FormListaAvisos : Form
    {
        public FormListaAvisos()
        {
            InitializeComponent();
        }

        private void FormListaAvisos_Load(object sender, EventArgs e)
        {
            CargarAvisos();
        }

        private void CargarAvisos()
        {
            // Consultamos la capa de Datos
            List<Aviso> listaAvisos = AvisoRepository.ObtenerAvisos();

            flpAvisos.Controls.Clear();

            foreach (Aviso aviso in listaAvisos)
            {
                Button btnAviso = new Button
                {
                    Text = aviso.Titulo,
                    Size = new Size(flpAvisos.Width - 35, 65),
                    Margin = new Padding(10),
                    BackColor = Color.LightGray,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Tag = aviso // Guardamos el modelo dentro de la propiedad Tag
                };

                btnAviso.Click += BtnAviso_Click;
                flpAvisos.Controls.Add(btnAviso);
            }
        }

        private void BtnAviso_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Aviso avisoSeleccionado)
            {
                // Pasamos el aviso Y pasamos 'this' (esta ventana actual)
                FormDetalleAviso detalle = new FormDetalleAviso(avisoSeleccionado, this);
                detalle.Show();

                // Ocultamos la lista para que no quede estorbando de fondo
                this.Hide();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}