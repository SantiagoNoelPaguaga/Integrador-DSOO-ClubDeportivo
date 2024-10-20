namespace IntegradorClubDeportivoEquipo4 {
    partial class FormSocio {
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
        private void InitializeComponent() {
            lblDatosUsuario = new Label();
            btnCarnet = new Button();
            SuspendLayout();
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Location = new Point(22, 23);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(50, 15);
            lblDatosUsuario.TabIndex = 1;
            lblDatosUsuario.Text = "Usuario:";
            // 
            // btnCarnet
            // 
            btnCarnet.Location = new Point(128, 114);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(190, 46);
            btnCarnet.TabIndex = 23;
            btnCarnet.Text = "VISUALIZAR CARNET";
            btnCarnet.UseVisualStyleBackColor = true;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // FormSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 353);
            Controls.Add(btnCarnet);
            Controls.Add(lblDatosUsuario);
            Name = "FormSocio";
            Text = "FormSocio";
            Load += FormSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosUsuario;
        private Button btnCarnet;
    }
}