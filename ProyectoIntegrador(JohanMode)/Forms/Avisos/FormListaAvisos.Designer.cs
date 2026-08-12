namespace ProyectoIntegrador_JohanMode_.Forms.Avisos
{
    partial class FormListaAvisos
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
            panelEncabezado = new Panel();
            lblTituloVista = new Label();
            btnRegresar = new Button();
            flpAvisos = new FlowLayoutPanel();
            panelEncabezado.SuspendLayout();
            SuspendLayout();
            // 
            // panelEncabezado
            // 
            panelEncabezado.Controls.Add(lblTituloVista);
            panelEncabezado.Controls.Add(btnRegresar);
            panelEncabezado.Dock = DockStyle.Top;
            panelEncabezado.Location = new Point(0, 0);
            panelEncabezado.Margin = new Padding(5);
            panelEncabezado.Name = "panelEncabezado";
            panelEncabezado.Size = new Size(702, 78);
            panelEncabezado.TabIndex = 0;
            panelEncabezado.Paint += panelEncabezado_Paint;
            // 
            // lblTituloVista
            // 
            lblTituloVista.AutoSize = true;
            lblTituloVista.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloVista.Location = new Point(269, 23);
            lblTituloVista.Name = "lblTituloVista";
            lblTituloVista.Size = new Size(161, 31);
            lblTituloVista.TabIndex = 2;
            lblTituloVista.Text = "Lista de avisos";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Location = new Point(14, 3);
            btnRegresar.Margin = new Padding(5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(78, 70);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "←";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // flpAvisos
            // 
            flpAvisos.AutoScroll = true;
            flpAvisos.BackColor = Color.DimGray;
            flpAvisos.Dock = DockStyle.Fill;
            flpAvisos.FlowDirection = FlowDirection.TopDown;
            flpAvisos.Location = new Point(0, 78);
            flpAvisos.Name = "flpAvisos";
            flpAvisos.Size = new Size(702, 702);
            flpAvisos.TabIndex = 1;
            flpAvisos.WrapContents = false;
            // 
            // FormListaAvisos
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 780);
            Controls.Add(flpAvisos);
            Controls.Add(panelEncabezado);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormListaAvisos";
            Text = "FormListaAvisos";
            Load += FormListaAvisos_Load;
            panelEncabezado.ResumeLayout(false);
            panelEncabezado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEncabezado;
        private Label lblTituloVista;
        private Button btnRegresar;
        private FlowLayoutPanel flpAvisos;
    }
}