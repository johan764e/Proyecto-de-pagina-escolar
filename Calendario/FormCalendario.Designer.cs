namespace ProyectoIntegrador_JohanMode_.Forms.Calendario
{
    partial class FrmCalendario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelPrincipal = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            panel1 = new Panel();
            lblMes = new Label();
            tblCalendario = new TableLayoutPanel();
            lblDomingo = new Label();
            lblSabado = new Label();
            lblViernes = new Label();
            lblMiercoles = new Label();
            lblJueves = new Label();
            lblMartes = new Label();
            lblLunes = new Label();
            gbEventos = new GroupBox();
            lstEventos = new ListBox();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnRegresar = new Button();
            panelPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            gbEventos.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BorderStyle = BorderStyle.FixedSingle;
            panelPrincipal.Controls.Add(btnEliminar);
            panelPrincipal.Controls.Add(btnEditar);
            panelPrincipal.Controls.Add(btnAgregar);
            panelPrincipal.Controls.Add(panel1);
            panelPrincipal.Controls.Add(tblCalendario);
            panelPrincipal.Controls.Add(lblDomingo);
            panelPrincipal.Controls.Add(lblSabado);
            panelPrincipal.Controls.Add(lblViernes);
            panelPrincipal.Controls.Add(lblMiercoles);
            panelPrincipal.Controls.Add(lblJueves);
            panelPrincipal.Controls.Add(lblMartes);
            panelPrincipal.Controls.Add(lblLunes);
            panelPrincipal.Controls.Add(gbEventos);
            panelPrincipal.Controls.Add(btnSiguiente);
            panelPrincipal.Controls.Add(btnAnterior);
            panelPrincipal.Controls.Add(btnRegresar);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(0, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(982, 653);
            panelPrincipal.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(749, 586);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar Evento";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(548, 586);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar Evento";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(349, 586);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar Evento";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lblMes);
            panel1.Location = new Point(521, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 35);
            panel1.TabIndex = 13;
            // 
            // lblMes
            // 
            lblMes.Dock = DockStyle.Fill;
            lblMes.Font = new Font("Microsoft Sans Serif", 8.25F);
            lblMes.Location = new Point(0, 0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(180, 35);
            lblMes.TabIndex = 1;
            lblMes.Text = "Julio 2026";
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            lblMes.Click += lblMes_Click;
            // 
            // tblCalendario
            // 
            tblCalendario.ColumnCount = 7;
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblCalendario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tblCalendario.Location = new Point(260, 160);
            tblCalendario.Name = "tblCalendario";
            tblCalendario.RowCount = 6;
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCalendario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblCalendario.Size = new Size(700, 420);
            tblCalendario.TabIndex = 12;
            tblCalendario.Paint += tblCalendario_Paint;
            // 
            // lblDomingo
            // 
            lblDomingo.AutoSize = true;
            lblDomingo.Location = new Point(874, 132);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(72, 20);
            lblDomingo.TabIndex = 11;
            lblDomingo.Text = "Domingo";
            lblDomingo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSabado
            // 
            lblSabado.AutoSize = true;
            lblSabado.Location = new Point(780, 132);
            lblSabado.Name = "lblSabado";
            lblSabado.Size = new Size(60, 20);
            lblSabado.TabIndex = 10;
            lblSabado.Text = "Sabado";
            lblSabado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblViernes
            // 
            lblViernes.AutoSize = true;
            lblViernes.Location = new Point(682, 132);
            lblViernes.Name = "lblViernes";
            lblViernes.Size = new Size(57, 20);
            lblViernes.TabIndex = 9;
            lblViernes.Text = "Viernes";
            lblViernes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMiercoles
            // 
            lblMiercoles.AutoSize = true;
            lblMiercoles.Location = new Point(473, 132);
            lblMiercoles.Name = "lblMiercoles";
            lblMiercoles.Size = new Size(73, 20);
            lblMiercoles.TabIndex = 8;
            lblMiercoles.Text = "Miercoles";
            lblMiercoles.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJueves
            // 
            lblJueves.AutoSize = true;
            lblJueves.Location = new Point(586, 132);
            lblJueves.Name = "lblJueves";
            lblJueves.Size = new Size(51, 20);
            lblJueves.TabIndex = 7;
            lblJueves.Text = "Jueves";
            lblJueves.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMartes
            // 
            lblMartes.AutoSize = true;
            lblMartes.Location = new Point(381, 132);
            lblMartes.Name = "lblMartes";
            lblMartes.Size = new Size(54, 20);
            lblMartes.TabIndex = 6;
            lblMartes.Text = "Martes";
            lblMartes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLunes
            // 
            lblLunes.AutoSize = true;
            lblLunes.Location = new Point(287, 132);
            lblLunes.Name = "lblLunes";
            lblLunes.Size = new Size(46, 20);
            lblLunes.TabIndex = 5;
            lblLunes.Text = "Lunes";
            lblLunes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbEventos
            // 
            gbEventos.Controls.Add(lstEventos);
            gbEventos.Location = new Point(20, 80);
            gbEventos.Name = "gbEventos";
            gbEventos.Size = new Size(220, 500);
            gbEventos.TabIndex = 4;
            gbEventos.TabStop = false;
            gbEventos.Text = "Notificaciones";
            // 
            // lstEventos
            // 
            lstEventos.Dock = DockStyle.Fill;
            lstEventos.FormattingEnabled = true;
            lstEventos.Location = new Point(3, 23);
            lstEventos.Name = "lstEventos";
            lstEventos.Size = new Size(214, 474);
            lstEventos.TabIndex = 0;
            lstEventos.SelectedIndexChanged += lstEventos_SelectedIndexChanged;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(717, 59);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(40, 40);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = ">";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(462, 59);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(40, 40);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "<";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(15, 15);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(55, 45);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "←";
            btnRegresar.TextAlign = ContentAlignment.TopCenter;
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // FrmCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FrmCalendario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calendario";
            Load += FrmCalendario_Load;
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            gbEventos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button btnRegresar;
        private Label lblMes;
        private GroupBox gbEventos;
        private Button btnSiguiente;
        private Button btnAnterior;
        private TableLayoutPanel tblCalendario;
        private Label lblDomingo;
        private Label lblSabado;
        private Label lblViernes;
        private Label lblMiercoles;
        private Label lblJueves;
        private Label lblMartes;
        private Label lblLunes;
        private ListBox lstEventos;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
    }
}