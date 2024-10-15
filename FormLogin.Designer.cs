namespace IntegradorClubDeportivoEquipo4
{
    partial class FormLogin
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnIniciarSesion = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 67);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(306, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "********";
            txtPassword.Size = new Size(306, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(181, 169);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(126, 43);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "INICIAR SESIÓN";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // button2
            // 
            button2.Location = new Point(181, 254);
            button2.Name = "button2";
            button2.Size = new Size(126, 40);
            button2.TabIndex = 3;
            button2.Text = "REGISTRARSE";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 236);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 4;
            label1.Text = "¿No tienes cuenta aún?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(94, 52);
            label2.Name = "label2";
            label2.Size = new Size(30, 12);
            label2.TabIndex = 5;
            label2.Text = "EMAIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 111);
            label3.Name = "label3";
            label3.Size = new Size(64, 12);
            label3.TabIndex = 6;
            label3.Text = "CONTRASEÑA";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 335);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "FormLogin";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnIniciarSesion;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
