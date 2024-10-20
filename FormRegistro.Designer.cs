namespace IntegradorClubDeportivoEquipo4
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtDocumento = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            cboTipoDocumento = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnAgregarAptoFisico = new Button();
            rbtSocio = new RadioButton();
            rbtNoSocio = new RadioButton();
            label9 = new Label();
            pbImagenCarnet = new PictureBox();
            label10 = new Label();
            btnSubirImagen = new Button();
            btnContinuar = new Button();
            lblNombreArchivo = new Label();
            panelSocio = new Panel();
            cboPlanes = new ComboBox();
            label12 = new Label();
            txtRepetirPassword = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagenCarnet).BeginInit();
            panelSocio.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(50, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(268, 79);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(50, 134);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(268, 134);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 3;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(268, 191);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(194, 23);
            txtDocumento.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(412, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 303);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(412, 23);
            txtPassword.TabIndex = 6;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(50, 191);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(194, 23);
            cboTipoDocumento.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(50, 61);
            label1.Name = "label1";
            label1.Size = new Size(45, 12);
            label1.TabIndex = 8;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(268, 64);
            label2.Name = "label2";
            label2.Size = new Size(49, 12);
            label2.TabIndex = 9;
            label2.Text = "APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 119);
            label3.Name = "label3";
            label3.Size = new Size(51, 12);
            label3.TabIndex = 10;
            label3.Text = "TELÉFONO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(268, 119);
            label4.Name = "label4";
            label4.Size = new Size(55, 12);
            label4.TabIndex = 11;
            label4.Text = "DIRECCIÓN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 176);
            label5.Name = "label5";
            label5.Size = new Size(102, 12);
            label5.TabIndex = 12;
            label5.Text = "TIPO DE DOCUMENTO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(268, 176);
            label6.Name = "label6";
            label6.Size = new Size(65, 12);
            label6.TabIndex = 13;
            label6.Text = "DOCUMENTO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(50, 232);
            label7.Name = "label7";
            label7.Size = new Size(33, 12);
            label7.TabIndex = 14;
            label7.Text = "EMAIL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(50, 288);
            label8.Name = "label8";
            label8.Size = new Size(65, 12);
            label8.TabIndex = 15;
            label8.Text = "CONTRASEÑA";
            // 
            // btnAgregarAptoFisico
            // 
            btnAgregarAptoFisico.Location = new Point(50, 419);
            btnAgregarAptoFisico.Name = "btnAgregarAptoFisico";
            btnAgregarAptoFisico.Size = new Size(412, 67);
            btnAgregarAptoFisico.TabIndex = 16;
            btnAgregarAptoFisico.Text = "SELECCIONAR ARCHIVO tipo .png .jpg .jpeg";
            btnAgregarAptoFisico.UseVisualStyleBackColor = true;
            btnAgregarAptoFisico.Click += btnAgregarAptoFisico_Click;
            // 
            // rbtSocio
            // 
            rbtSocio.AutoSize = true;
            rbtSocio.Location = new Point(136, 527);
            rbtSocio.Name = "rbtSocio";
            rbtSocio.Size = new Size(60, 19);
            rbtSocio.TabIndex = 17;
            rbtSocio.Text = "SOCIO";
            rbtSocio.UseVisualStyleBackColor = true;
            rbtSocio.CheckedChanged += rbtSocio_CheckedChanged;
            // 
            // rbtNoSocio
            // 
            rbtNoSocio.AutoSize = true;
            rbtNoSocio.Checked = true;
            rbtNoSocio.Location = new Point(252, 527);
            rbtNoSocio.Name = "rbtNoSocio";
            rbtNoSocio.Size = new Size(81, 19);
            rbtNoSocio.TabIndex = 18;
            rbtNoSocio.TabStop = true;
            rbtNoSocio.Text = "NO SOCIO";
            rbtNoSocio.UseVisualStyleBackColor = true;
            rbtNoSocio.CheckedChanged += rbtNoSocio_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(199, 404);
            label9.Name = "label9";
            label9.Size = new Size(103, 12);
            label9.TabIndex = 19;
            label9.Text = "AGREGAR APTO FÍSICO";
            // 
            // pbImagenCarnet
            // 
            pbImagenCarnet.Image = Properties.Resources.imagen_por_defecto;
            pbImagenCarnet.Location = new Point(149, 103);
            pbImagenCarnet.Margin = new Padding(0);
            pbImagenCarnet.Name = "pbImagenCarnet";
            pbImagenCarnet.Size = new Size(91, 91);
            pbImagenCarnet.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenCarnet.TabIndex = 21;
            pbImagenCarnet.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(131, 91);
            label10.Name = "label10";
            label10.Size = new Size(121, 12);
            label10.TabIndex = 22;
            label10.Text = "SUBIR IMAGEN DE CARNET";
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.AutoSize = true;
            btnSubirImagen.Location = new Point(149, 197);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(91, 28);
            btnSubirImagen.TabIndex = 23;
            btnSubirImagen.Text = "Seleccionar";
            btnSubirImagen.UseVisualStyleBackColor = true;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(175, 812);
            btnContinuar.Margin = new Padding(3, 3, 3, 40);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(158, 47);
            btnContinuar.TabIndex = 24;
            btnContinuar.Text = "CONTINUAR";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Location = new Point(50, 489);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(72, 15);
            lblNombreArchivo.TabIndex = 25;
            lblNombreArchivo.Text = "Archivo.png";
            lblNombreArchivo.Visible = false;
            // 
            // panelSocio
            // 
            panelSocio.Anchor = AnchorStyles.None;
            panelSocio.AutoSize = true;
            panelSocio.Controls.Add(cboPlanes);
            panelSocio.Controls.Add(label12);
            panelSocio.Controls.Add(pbImagenCarnet);
            panelSocio.Controls.Add(btnSubirImagen);
            panelSocio.Controls.Add(label10);
            panelSocio.Location = new Point(50, 552);
            panelSocio.Name = "panelSocio";
            panelSocio.Size = new Size(432, 237);
            panelSocio.TabIndex = 26;
            panelSocio.Visible = false;
            // 
            // cboPlanes
            // 
            cboPlanes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlanes.FormattingEnabled = true;
            cboPlanes.Location = new Point(96, 41);
            cboPlanes.Name = "cboPlanes";
            cboPlanes.Size = new Size(236, 23);
            cboPlanes.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(96, 26);
            label12.Name = "label12";
            label12.Size = new Size(92, 12);
            label12.TabIndex = 24;
            label12.Text = "SELECCIONAR PLAN";
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new Point(50, 358);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PasswordChar = '*';
            txtRepetirPassword.Size = new Size(412, 23);
            txtRepetirPassword.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(50, 343);
            label11.Name = "label11";
            label11.Size = new Size(103, 12);
            label11.TabIndex = 28;
            label11.Text = "REPETIR CONTRASEÑA";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(513, 871);
            Controls.Add(label11);
            Controls.Add(txtRepetirPassword);
            Controls.Add(panelSocio);
            Controls.Add(lblNombreArchivo);
            Controls.Add(btnContinuar);
            Controls.Add(label9);
            Controls.Add(rbtNoSocio);
            Controls.Add(rbtSocio);
            Controls.Add(btnAgregarAptoFisico);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboTipoDocumento);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtDocumento);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FormRegistro";
            StartPosition = FormStartPosition.Manual;
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)pbImagenCarnet).EndInit();
            panelSocio.ResumeLayout(false);
            panelSocio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtDocumento;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox cboTipoDocumento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnAgregarAptoFisico;
        private RadioButton rbtSocio;
        private RadioButton rbtNoSocio;
        private Label label9;
        private PictureBox pbImagenCarnet;
        private Label label10;
        private Button btnSubirImagen;
        private Button btnContinuar;
        private Label lblNombreArchivo;
        private Panel panelSocio;
        private TextBox txtRepetirPassword;
        private Label label11;
        private ComboBox cboPlanes;
        private Label label12;
    }
}