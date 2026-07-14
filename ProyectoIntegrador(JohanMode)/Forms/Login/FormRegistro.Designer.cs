namespace ProyectoIntegrador_JohanMode_.Forms.Login
{
    partial class FormRegistro
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
            textNMCM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCorreo2 = new TextBox();
            label3 = new Label();
            txtContraceña = new TextBox();
            label4 = new Label();
            txtConfContra = new TextBox();
            label5 = new Label();
            txtGrup = new TextBox();
            BtnRegresar = new Button();
            BtnRegistrar2 = new Button();
            Chistepdf = new LinkLabel();
            SuspendLayout();
            // 
            // textNMCM
            // 
            textNMCM.Location = new Point(278, 156);
            textNMCM.Name = "textNMCM";
            textNMCM.Size = new Size(335, 27);
            textNMCM.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 133);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 201);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Correo:";
            label2.Click += label2_Click;
            // 
            // txtCorreo2
            // 
            txtCorreo2.Location = new Point(278, 224);
            txtCorreo2.Name = "txtCorreo2";
            txtCorreo2.Size = new Size(335, 27);
            txtCorreo2.TabIndex = 2;
            txtCorreo2.TextChanged += txtCorreo2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 261);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtContraceña
            // 
            txtContraceña.Location = new Point(278, 284);
            txtContraceña.Name = "txtContraceña";
            txtContraceña.Size = new Size(335, 27);
            txtContraceña.TabIndex = 4;
            txtContraceña.TextChanged += txtContraceña_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(278, 323);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 7;
            label4.Text = "Confirmar Contraseña";
            // 
            // txtConfContra
            // 
            txtConfContra.Location = new Point(278, 346);
            txtConfContra.Name = "txtConfContra";
            txtConfContra.Size = new Size(335, 27);
            txtConfContra.TabIndex = 6;
            txtConfContra.TextChanged += txtConfContra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(278, 382);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "Grupo";
            // 
            // txtGrup
            // 
            txtGrup.Location = new Point(278, 405);
            txtGrup.Name = "txtGrup";
            txtGrup.Size = new Size(335, 27);
            txtGrup.TabIndex = 8;
            txtGrup.TextChanged += txtGrup_TextChanged;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Location = new Point(40, 534);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(161, 47);
            BtnRegresar.TabIndex = 10;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnRegistrar2
            // 
            BtnRegistrar2.Location = new Point(718, 524);
            BtnRegistrar2.Name = "BtnRegistrar2";
            BtnRegistrar2.Size = new Size(161, 47);
            BtnRegistrar2.TabIndex = 11;
            BtnRegistrar2.Text = "Registrar";
            BtnRegistrar2.UseVisualStyleBackColor = true;
            BtnRegistrar2.Click += BtnRegistrar2_Click;
            // 
            // Chistepdf
            // 
            Chistepdf.AutoSize = true;
            Chistepdf.Font = new Font("Segoe UI", 13F);
            Chistepdf.LinkColor = Color.Black;
            Chistepdf.Location = new Point(402, 36);
            Chistepdf.Name = "Chistepdf";
            Chistepdf.Size = new Size(112, 30);
            Chistepdf.TabIndex = 12;
            Chistepdf.TabStop = true;
            Chistepdf.Text = "REGISTRO";
            Chistepdf.LinkClicked += Chistepdf_LinkClicked;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 609);
            Controls.Add(Chistepdf);
            Controls.Add(BtnRegistrar2);
            Controls.Add(BtnRegresar);
            Controls.Add(label5);
            Controls.Add(txtGrup);
            Controls.Add(label4);
            Controls.Add(txtConfContra);
            Controls.Add(label3);
            Controls.Add(txtContraceña);
            Controls.Add(label2);
            Controls.Add(txtCorreo2);
            Controls.Add(label1);
            Controls.Add(textNMCM);
            Name = "FormRegistro";
            Text = "Form1";
            Load += FormRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNMCM;
        private Label label1;
        private Label label2;
        private TextBox txtCorreo2;
        private Label label3;
        private TextBox txtContraceña;
        private Label label4;
        private TextBox txtConfContra;
        private Label label5;
        private TextBox txtGrup;
        private Button BtnRegresar;
        private Button BtnRegistrar2;
        private LinkLabel Chistepdf;
    }
}