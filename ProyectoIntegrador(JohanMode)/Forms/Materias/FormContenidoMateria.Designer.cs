namespace ProyectoIntegrador_JohanMode_.Forms.Materias
{
    partial class FormContenidoMateria
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            btnAdjuntar = new Button();
            btnEnviar = new Button();
            btnEditar = new Button();
            btnBorrar = new Button();
            label6 = new Label();
            lblArchivoAdjunto = new Label();
            txtTitulo = new TextBox();
            lblTituloMateria = new Label();
            txtDescripcion = new TextBox();
            picMateria = new PictureBox();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMateria).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(535, 307);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 19;
            label3.Text = "Enviar Archivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 307);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 18;
            label2.Text = "Editar Archivos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 307);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 17;
            label1.Text = "Adjuntar Archivos";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(-64, -61);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 31);
            panel4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 8);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 0;
            label5.Text = "Notificaciones";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(332, -52);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 30);
            panel3.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 7);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 0;
            label4.Text = "Materia Nombre";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(12, 30);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(127, 275);
            panel1.TabIndex = 20;
            // 
            // btnAdjuntar
            // 
            btnAdjuntar.Location = new Point(295, 283);
            btnAdjuntar.Margin = new Padding(3, 2, 3, 2);
            btnAdjuntar.Name = "btnAdjuntar";
            btnAdjuntar.Size = new Size(82, 22);
            btnAdjuntar.TabIndex = 21;
            btnAdjuntar.Text = "button1";
            btnAdjuntar.UseVisualStyleBackColor = true;
            btnAdjuntar.Click += btnAdjuntar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(542, 283);
            btnEnviar.Margin = new Padding(3, 2, 3, 2);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 22);
            btnEnviar.TabIndex = 22;
            btnEnviar.Text = "button1";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(413, 283);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 23;
            btnEditar.Text = "button1";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(179, 283);
            btnBorrar.Margin = new Padding(3, 2, 3, 2);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(82, 22);
            btnBorrar.TabIndex = 24;
            btnBorrar.Text = "button1";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(179, 307);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 25;
            label6.Text = "Borrar Archivos";
            // 
            // lblArchivoAdjunto
            // 
            lblArchivoAdjunto.AutoSize = true;
            lblArchivoAdjunto.Location = new Point(325, 266);
            lblArchivoAdjunto.Name = "lblArchivoAdjunto";
            lblArchivoAdjunto.Size = new Size(161, 15);
            lblArchivoAdjunto.TabIndex = 26;
            lblArchivoAdjunto.Text = "Ningún archivo seleccionado";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(259, 52);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(216, 23);
            txtTitulo.TabIndex = 0;
            // 
            // lblTituloMateria
            // 
            lblTituloMateria.AutoSize = true;
            lblTituloMateria.Location = new Point(535, 55);
            lblTituloMateria.Name = "lblTituloMateria";
            lblTituloMateria.Size = new Size(109, 15);
            lblTituloMateria.TabIndex = 28;
            lblTituloMateria.Text = "Titulo de la materia";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(353, 95);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(335, 139);
            txtDescripcion.TabIndex = 27;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // picMateria
            // 
            picMateria.Location = new Point(145, 78);
            picMateria.Name = "picMateria";
            picMateria.Size = new Size(202, 174);
            picMateria.TabIndex = 0;
            picMateria.TabStop = false;
            picMateria.Click += picMateria_Click;
            // 
            // FormContenidoMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtDescripcion);
            Controls.Add(picMateria);
            Controls.Add(lblTituloMateria);
            Controls.Add(txtTitulo);
            Controls.Add(lblArchivoAdjunto);
            Controls.Add(label6);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnEnviar);
            Controls.Add(btnAdjuntar);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormContenidoMateria";
            Text = "Form1";
            Load += FormContenidoMateria_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMateria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Panel panel1;
        private Button btnAdjuntar;
        private Button btnEnviar;
        private Button btnEditar;
        private Button btnBorrar;
        private Label label6;
        private Label lblArchivoAdjunto;
        private TextBox txtTitulo;
        private Label lblTituloMateria;
        private TextBox txtDescripcion;
        private PictureBox picMateria;
    }
}