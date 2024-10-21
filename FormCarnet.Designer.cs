namespace IntegradorClubDeportivoEquipo4 {
    partial class FormCarnet {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            txtNombreCompleto = new TextBox();
            txtNumeroSocio = new TextBox();
            lblSocio = new Label();
            lblDocumento = new Label();
            txtNumeroDocumento = new TextBox();
            pbImagenCarnet = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagenCarnet).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Enabled = false;
            txtNombreCompleto.Location = new Point(38, 52);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(220, 23);
            txtNombreCompleto.TabIndex = 3;
            // 
            // txtNumeroSocio
            // 
            txtNumeroSocio.Enabled = false;
            txtNumeroSocio.Location = new Point(86, 110);
            txtNumeroSocio.Name = "txtNumeroSocio";
            txtNumeroSocio.Size = new Size(172, 23);
            txtNumeroSocio.TabIndex = 4;
            // 
            // lblSocio
            // 
            lblSocio.AutoSize = true;
            lblSocio.Location = new Point(38, 113);
            lblSocio.Name = "lblSocio";
            lblSocio.Size = new Size(45, 15);
            lblSocio.TabIndex = 7;
            lblSocio.Text = "SOCIO:";
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(38, 163);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(84, 15);
            lblDocumento.TabIndex = 8;
            lblDocumento.Text = "DOCUMENTO:";
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Enabled = false;
            txtNumeroDocumento.Location = new Point(124, 160);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(134, 23);
            txtNumeroDocumento.TabIndex = 9;
            // 
            // pbImagenCarnet
            // 
            pbImagenCarnet.Image = Properties.Resources.imagen_por_defecto;
            pbImagenCarnet.Location = new Point(307, 52);
            pbImagenCarnet.Margin = new Padding(0);
            pbImagenCarnet.Name = "pbImagenCarnet";
            pbImagenCarnet.Size = new Size(147, 137);
            pbImagenCarnet.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenCarnet.TabIndex = 23;
            pbImagenCarnet.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(345, 294);
            button1.Name = "button1";
            button1.Size = new Size(190, 46);
            button1.TabIndex = 24;
            button1.Text = "DESCARGAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pbImagenCarnet);
            panel1.Controls.Add(txtNumeroDocumento);
            panel1.Controls.Add(lblDocumento);
            panel1.Controls.Add(lblSocio);
            panel1.Controls.Add(txtNumeroSocio);
            panel1.Controls.Add(txtNombreCompleto);
            panel1.Location = new Point(31, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(504, 236);
            panel1.TabIndex = 25;
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(31, 294);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(190, 46);
            btnInicio.TabIndex = 26;
            btnInicio.Text = "IR AL INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // FormCarnet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnInicio);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "FormCarnet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCarnet";
            ((System.ComponentModel.ISupportInitialize)pbImagenCarnet).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreCompleto;
        private TextBox txtNumeroSocio;
        private Label lblSocio;
        private Label lblDocumento;
        private TextBox txtNumeroDocumento;
        private PictureBox pbImagenCarnet;
        private Button button1;
        private Panel panel1;
        private Button btnInicio;
    }
}