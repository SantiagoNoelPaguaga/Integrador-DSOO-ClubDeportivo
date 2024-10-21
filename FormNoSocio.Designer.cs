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
        private void InitializeComponent()
        {
            lblDatosUsuario = new Label();
            btnRealizarPago = new Button();
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
            // btnRealizarPago
            // 
            btnRealizarPago.Location = new Point(123, 134);
            btnRealizarPago.Name = "btnRealizarPago";
            btnRealizarPago.Size = new Size(190, 46);
            btnRealizarPago.TabIndex = 25;
            btnRealizarPago.Text = "REALIZAR PAGO";
            btnRealizarPago.UseVisualStyleBackColor = true;
            btnRealizarPago.Click += btnRealizarPago_Click;
            // 
            // FormNoSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 353);
            Controls.Add(btnRealizarPago);
            Controls.Add(lblDatosUsuario);
            Name = "FormNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoSocioForm";
            Load += FormNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosUsuario;
        private Button btnRealizarPago;
    }
}