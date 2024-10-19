namespace IntegradorClubDeportivoEquipo4
{
    partial class FormAdmin
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
            lblDatosUsuario = new Label();
            btnListarVencimientos = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Location = new Point(25, 22);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(50, 15);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Usuario:";
            // 
            // btnListarVencimientos
            // 
            btnListarVencimientos.Location = new Point(56, 91);
            btnListarVencimientos.Name = "btnListarVencimientos";
            btnListarVencimientos.Size = new Size(335, 85);
            btnListarVencimientos.TabIndex = 1;
            btnListarVencimientos.Text = "MOSTRAR LISTADO DE SOCIOS CON VENCIMIENTO DE CUOTA";
            btnListarVencimientos.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(56, 201);
            button2.Name = "button2";
            button2.Size = new Size(335, 85);
            button2.TabIndex = 2;
            button2.Text = "ACTUALIZAR ESTADO DE APTO FÍSICO DE CLIENTES";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 353);
            Controls.Add(button2);
            Controls.Add(btnListarVencimientos);
            Controls.Add(lblDatosUsuario);
            Name = "FormAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Admin";
            Load += FormAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosUsuario;
        private Button btnListarVencimientos;
        private Button button2;
    }
}