using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ProyectoIntegrador_JohanMode_.Forms.Calendario
{
    public partial class FrmCalendario : Form
    {
        // Lista donde se almacenan todos los eventos creados por el usuario.
        private List<Evento> eventos = new List<Evento>();

        // Guarda el mes y año que se está mostrando en el calendario.
        private DateTime fechaActual = DateTime.Today;

        // Guarda la fecha que el usuario seleccionó en el calendario.
        private DateTime fechaSeleccionada = DateTime.Today;

        public FrmCalendario()
        {
            InitializeComponent();
        }

        // Se ejecuta al abrir el formulario y genera el calendario del mes actual.
        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            CrearCalendario();
        }

        // Genera el calendario del mes seleccionado.
        // Crea automáticamente los botones de cada día y los coloca
        // en la posición correcta según el día de la semana.
        private void CrearCalendario()
        {
            tblCalendario.Controls.Clear();

            // Mostrar el nombre del mes y el año.
            lblMes.Text = fechaActual.ToString("MMMM yyyy");

            // Obtiene el primer día del mes.
            DateTime primerDia = new DateTime(fechaActual.Year, fechaActual.Month, 1);

            // Obtiene la cantidad de días que tiene el mes.
            int diasMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);

            // Convierte el día de inicio para que el calendario comience en lunes.
            int columnaInicio = ((int)primerDia.DayOfWeek + 6) % 7;

            int fila = 0;
            int columna = columnaInicio;

            for (int dia = 1; dia <= diasMes; dia++)
            {
                Button btn = new Button();

                // Fecha correspondiente al botón que se está creando.
                DateTime fechaBoton = new DateTime(fechaActual.Year, fechaActual.Month, dia);

                // Si existe un evento en esa fecha, cambia el color del botón.
                if (eventos.Any(x => x.Fecha.Date == fechaBoton.Date))
                {
                    btn.BackColor = Color.LightGreen;
                }

                btn.Text = dia.ToString();
                btn.Dock = DockStyle.Fill;
                btn.Margin = new Padding(1);
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.Gainsboro;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // Asigna el evento de clic al botón.
                btn.Click += Dia_Click;

                tblCalendario.Controls.Add(btn, columna, fila);

                columna++;

                // Cuando termina la semana pasa a la siguiente fila.
                if (columna > 6)
                {
                    columna = 0;
                    fila++;
                }

                // Resalta el día actual con un color diferente.
                DateTime hoy = DateTime.Today;

                if (dia == hoy.Day &&
                    fechaActual.Month == hoy.Month &&
                    fechaActual.Year == hoy.Year)
                {
                    btn.BackColor = Color.LightSkyBlue;
                }
            }
        }

        // Se ejecuta cuando el usuario hace clic sobre un día del calendario.
        // Guarda la fecha seleccionada y muestra los eventos registrados para ese día.
        private void Dia_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            int dia = Convert.ToInt32(boton.Text);

            fechaSeleccionada = new DateTime(fechaActual.Year, fechaActual.Month, dia);

            MessageBox.Show("Fecha seleccionada: " + fechaSeleccionada.ToShortDateString());

            lstEventos.Items.Clear();

            MostrarEvento();
        }

        // Evento del ListBox (actualmente sin funcionalidad).
        private void lstEventos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Evento Paint del calendario (actualmente sin funcionalidad).
        private void tblCalendario_Paint(object sender, PaintEventArgs e)
        {

        }

        // Cambia al siguiente mes y vuelve a generar el calendario.
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(1);
            CrearCalendario();
        }

        // Regresa al mes anterior y actualiza el calendario.
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            fechaActual = fechaActual.AddMonths(-1);
            CrearCalendario();
        }

        // Evento del Label del mes (actualmente sin funcionalidad).
        private void lblMes_Click(object sender, EventArgs e)
        {

        }

        // Agrega un nuevo evento a la fecha seleccionada.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = Microsoft.VisualBasic.Interaction.InputBox("Título del evento");

            if (titulo == "")
                return;

            string descripcion = Microsoft.VisualBasic.Interaction.InputBox("Descripción");

            eventos.Add(new Evento()
            {
                Fecha = fechaSeleccionada,
                Titulo = titulo,
                Descripcion = descripcion
            });

            MostrarEvento();
            CrearCalendario();
        }

        // Muestra en el ListBox el evento correspondiente a la fecha seleccionada.
        private void MostrarEvento()
        {
            lstEventos.Items.Clear();

            Evento evento = eventos.FirstOrDefault(x => x.Fecha.Date == fechaSeleccionada.Date);

            if (evento != null)
            {
                lstEventos.Items.Add(evento.Titulo);
                lstEventos.Items.Add(evento.Descripcion);
            }
            else
            {
                lstEventos.Items.Add("No hay eventos registrados.");
            }
        }

        // Elimina el evento asociado a la fecha seleccionada.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Evento evento = eventos.FirstOrDefault(x => x.Fecha.Date == fechaSeleccionada.Date);

            if (evento == null)
            {
                MessageBox.Show("No existe un evento en esta fecha.");
                return;
            }

            eventos.Remove(evento);

            MostrarEvento();

            CrearCalendario();
        }

        // Permite modificar el título y la descripción del evento
        // correspondiente a la fecha seleccionada.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Evento evento = eventos.FirstOrDefault(x => x.Fecha.Date == fechaSeleccionada.Date);

            if (evento == null)
            {
                MessageBox.Show("Esta fecha no tiene evento.");
                return;
            }

            evento.Titulo = Microsoft.VisualBasic.Interaction.InputBox(
                "Editar título",
                "",
                evento.Titulo);

            evento.Descripcion = Microsoft.VisualBasic.Interaction.InputBox(
                "Editar descripción",
                "",
                evento.Descripcion);

            MostrarEvento();
        }

        // Clase que representa un evento del calendario.
        // Contiene la fecha, el título y la descripción del evento.
        public class Evento
        {
            public DateTime Fecha { get; set; }
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
