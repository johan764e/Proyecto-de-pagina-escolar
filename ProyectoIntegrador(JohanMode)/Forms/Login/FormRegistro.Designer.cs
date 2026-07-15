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
            textNMCM.Font = new Font("Segoe UI", 12F);
            textNMCM.Location = new Point(264, 119);
            textNMCM.Margin = new Padding(3, 2, 3, 2);
            textNMCM.Name = "textNMCM";
            textNMCM.Size = new Size(294, 29);
            textNMCM.TabIndex = 0;
            textNMCM.TextChanged += textNMCM_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(264, 96);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre Completo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(264, 147);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Correo:";
            label2.Click += label2_Click;
            // 
            // txtCorreo2
            // 
            txtCorreo2.Font = new Font("Segoe UI", 12F);
            txtCorreo2.Location = new Point(264, 170);
            txtCorreo2.Margin = new Padding(3, 2, 3, 2);
            txtCorreo2.Name = "txtCorreo2";
            txtCorreo2.Size = new Size(294, 29);
            txtCorreo2.TabIndex = 2;
            txtCorreo2.TextChanged += txtCorreo2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(264, 198);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtContraceña
            // 
            txtContraceña.Font = new Font("Segoe UI", 12F);
            txtContraceña.Location = new Point(264, 221);
            txtContraceña.Margin = new Padding(3, 2, 3, 2);
            txtContraceña.Name = "txtContraceña";
            txtContraceña.Size = new Size(294, 29);
            txtContraceña.TabIndex = 4;
            txtContraceña.UseSystemPasswordChar = true;
            txtContraceña.TextChanged += txtContraceña_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(264, 257);
            label4.Name = "label4";
            label4.Size = new Size(164, 21);
            label4.TabIndex = 7;
            label4.Text = "Confirmar Contraseña";
            label4.Click += label4_Click;
            // 
            // txtConfContra
            // 
            txtConfContra.Font = new Font("Segoe UI", 12F);
            txtConfContra.Location = new Point(264, 280);
            txtConfContra.Margin = new Padding(3, 2, 3, 2);
            txtConfContra.Name = "txtConfContra";
            txtConfContra.Size = new Size(294, 29);
            txtConfContra.TabIndex = 6;
            txtConfContra.UseSystemPasswordChar = true;
            txtConfContra.TextChanged += txtConfContra_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(264, 315);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 9;
            label5.Text = "Grupo";
            // 
            // txtGrup
            // 
            txtGrup.Font = new Font("Segoe UI", 12F);
            txtGrup.Location = new Point(264, 338);
            txtGrup.Margin = new Padding(3, 2, 3, 2);
            txtGrup.Name = "txtGrup";
            txtGrup.Size = new Size(294, 29);
            txtGrup.TabIndex = 8;
            txtGrup.TextChanged += txtGrup_TextChanged;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Font = new Font("Segoe UI", 12F);
            BtnRegresar.Location = new Point(31, 385);
            BtnRegresar.Margin = new Padding(3, 2, 3, 2);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(174, 56);
            BtnRegresar.TabIndex = 10;
            BtnRegresar.Text = "Regresar";
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnRegistrar2
            // 
            BtnRegistrar2.Font = new Font("Segoe UI", 12F);
            BtnRegistrar2.Location = new Point(592, 385);
            BtnRegistrar2.Margin = new Padding(3, 2, 3, 2);
            BtnRegistrar2.Name = "BtnRegistrar2";
            BtnRegistrar2.Size = new Size(174, 56);
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
            Chistepdf.Location = new Point(355, 27);
            Chistepdf.Name = "Chistepdf";
            Chistepdf.Size = new Size(93, 25);
            Chistepdf.TabIndex = 12;
            Chistepdf.TabStop = true;
            Chistepdf.Text = "REGISTRO";
            Chistepdf.LinkClicked += Chistepdf_LinkClicked;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 457);
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
            Margin = new Padding(3, 2, 3, 2);
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