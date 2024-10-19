namespace IntegradorClubDeportivoEquipo4 {
    partial class FormNoSocio {
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
            SuspendLayout();
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Location = new Point(12, 23);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(50, 15);
            lblDatosUsuario.TabIndex = 2;
            lblDatosUsuario.Text = "Usuario:";
            // 
            // FormNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 353);
            Controls.Add(lblDatosUsuario);
            Name = "FormNoSocio";
            Text = "NoSocioForm";
            Load += FormNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosUsuario;
    }
}