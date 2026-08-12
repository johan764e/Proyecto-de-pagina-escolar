namespace ProyectoIntegrador_JohanMode_.Forms.Avisos
{
    partial class FormDetalleAviso
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
            panel1 = new Panel();
            lblFechaAviso = new Label();
            lblTituloAviso = new Label();
            btnRegresar = new Button();
            panelFondoGris = new Panel();
            txtContenido = new TextBox();
            panel1.SuspendLayout();
            panelFondoGris.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblFechaAviso);
            panel1.Controls.Add(lblTituloAviso);
            panel1.Controls.Add(btnRegresar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 80);
            panel1.TabIndex = 0;
            // 
            // lblFechaAviso
            // 
            lblFechaAviso.AutoSize = true;
            lblFechaAviso.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaAviso.Location = new Point(272, 16);
            lblFechaAviso.Name = "lblFechaAviso";
            lblFechaAviso.Size = new Size(133, 20);
            lblFechaAviso.TabIndex = 1;
            lblFechaAviso.Text = "Fecha del anuncio";
            // 
            // lblTituloAviso
            // 
            lblTituloAviso.AutoSize = true;
            lblTituloAviso.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloAviso.Location = new Point(79, 12);
            lblTituloAviso.Name = "lblTituloAviso";
            lblTituloAviso.Size = new Size(142, 25);
            lblTituloAviso.TabIndex = 1;
            lblTituloAviso.Text = "Título del aviso";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(12, 12);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(50, 50);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "←";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panelFondoGris
            // 
            panelFondoGris.BackColor = Color.DimGray;
            panelFondoGris.Controls.Add(txtContenido);
            panelFondoGris.Dock = DockStyle.Fill;
            panelFondoGris.Location = new Point(0, 80);
            panelFondoGris.Margin = new Padding(20);
            panelFondoGris.Name = "panelFondoGris";
            panelFondoGris.Size = new Size(432, 423);
            panelFondoGris.TabIndex = 1;
            // 
            // txtContenido
            // 
            txtContenido.BackColor = Color.LightGray;
            txtContenido.BorderStyle = BorderStyle.FixedSingle;
            txtContenido.Dock = DockStyle.Fill;
            txtContenido.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContenido.Location = new Point(0, 0);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ReadOnly = true;
            txtContenido.Size = new Size(432, 423);
            txtContenido.TabIndex = 0;
            txtContenido.TextChanged += txtContenido_TextChanged;
            // 
            // FormDetalleAviso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 503);
            Controls.Add(panelFondoGris);
            Controls.Add(panel1);
            Name = "FormDetalleAviso";
            Text = "FormDetalleAviso";
            Load += FormDetalleAviso_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFondoGris.ResumeLayout(false);
            panelFondoGris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegresar;
        private Label lblFechaAviso;
        private Label lblTituloAviso;
        private Panel panelFondoGris;
        private TextBox txtContenido;
    }
}