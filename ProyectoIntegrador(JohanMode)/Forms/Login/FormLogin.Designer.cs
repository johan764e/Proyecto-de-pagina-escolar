namespace ProyectoIntegrador_JohanMode_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            TextCorreoElectronico = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textContraceña = new TextBox();
            label3 = new Label();
            BtnRegistro = new Button();
            BtonINISesion = new Button();
            BtonOlvidoContra = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoSample_ByTailorBrands;
            pictureBox1.Location = new Point(257, 53);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 75);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TextCorreoElectronico
            // 
            TextCorreoElectronico.Location = new Point(257, 247);
            TextCorreoElectronico.Margin = new Padding(3, 4, 3, 4);
            TextCorreoElectronico.Name = "TextCorreoElectronico";
            TextCorreoElectronico.Size = new Size(356, 27);
            TextCorreoElectronico.TabIndex = 1;
            TextCorreoElectronico.TextChanged += TextCorreoElectronico_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 211);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingresé su Correo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 309);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingresar Contraseña:";
            // 
            // textContraceña
            // 
            textContraceña.Location = new Point(257, 345);
            textContraceña.Margin = new Padding(3, 4, 3, 4);
            textContraceña.Name = "textContraceña";
            textContraceña.Size = new Size(356, 27);
            textContraceña.TabIndex = 5;
            textContraceña.UseSystemPasswordChar = true;
            textContraceña.TextChanged += textContraceña_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 413);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            label3.Click += label3_Click;
            // 
            // BtnRegistro
            // 
            BtnRegistro.Location = new Point(257, 441);
            BtnRegistro.Margin = new Padding(3, 4, 3, 4);
            BtnRegistro.Name = "BtnRegistro";
            BtnRegistro.Size = new Size(171, 44);
            BtnRegistro.TabIndex = 7;
            BtnRegistro.Text = "Registrarse";
            BtnRegistro.UseVisualStyleBackColor = true;
            BtnRegistro.Click += BtnRegistro_Click;
            // 
            // BtonINISesion
            // 
            BtonINISesion.Location = new Point(435, 441);
            BtonINISesion.Margin = new Padding(3, 4, 3, 4);
            BtonINISesion.Name = "BtonINISesion";
            BtonINISesion.Size = new Size(178, 44);
            BtonINISesion.TabIndex = 8;
            BtonINISesion.Text = "Iniciar Sesión";
            BtonINISesion.UseVisualStyleBackColor = true;
            BtonINISesion.Click += BtonINISesion_Click;
            // 
            // BtonOlvidoContra
            // 
            BtonOlvidoContra.FlatAppearance.BorderSize = 0;
            BtonOlvidoContra.FlatStyle = FlatStyle.Flat;
            BtonOlvidoContra.Location = new Point(248, 401);
            BtonOlvidoContra.Margin = new Padding(3, 4, 3, 4);
            BtonOlvidoContra.Name = "BtonOlvidoContra";
            BtonOlvidoContra.Size = new Size(189, 32);
            BtonOlvidoContra.TabIndex = 9;
            BtonOlvidoContra.Text = "¿Olvidó su contraseña?";
            BtonOlvidoContra.UseVisualStyleBackColor = true;
            BtonOlvidoContra.Click += BtonOlvidoContra_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(BtonOlvidoContra);
            Controls.Add(BtonINISesion);
            Controls.Add(BtnRegistro);
            Controls.Add(label3);
            Controls.Add(textContraceña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextCorreoElectronico);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox TextCorreoElectronico;
        private Label label1;
        private Label label2;
        private TextBox textContraceña;
        private Label label3;
        private Button BtnRegistro;
        private Button BtonINISesion;
        private Button BtonOlvidoContra;
    }
}
