namespace ProyectoIntegrador_JohanMode_.Forms.Login
{
    partial class FormRecuperarContraseña
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
            btnHamburguesa = new Button();
            PnlMENU = new Panel();
            SuspendLayout();
            // 
            // btnHamburguesa
            // 
            btnHamburguesa.Location = new Point(12, 18);
            btnHamburguesa.Name = "btnHamburguesa";
            btnHamburguesa.Size = new Size(47, 40);
            btnHamburguesa.TabIndex = 1;
            btnHamburguesa.Text = "button1";
            btnHamburguesa.UseVisualStyleBackColor = true;
            // 
            // PnlMENU
            // 
            PnlMENU.Location = new Point(12, 64);
            PnlMENU.Name = "PnlMENU";
            PnlMENU.Size = new Size(208, 457);
            PnlMENU.TabIndex = 2;
            // 
            // FormRecuperarContraseña
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(PnlMENU);
            Controls.Add(btnHamburguesa);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRecuperarContraseña";
            Text = "Form1";
            Load += FormRecuperarContraseña_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHamburguesa;
        private Panel PnlMENU;
    }
}