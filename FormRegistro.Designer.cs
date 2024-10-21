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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            rbtNoSocio = new RadioButton();
            rbtSocio = new RadioButton();
            lblNombreArchivo = new Label();
            btnAgregarAptoFisico = new Button();
            label9 = new Label();
            txtRepetirPassword = new TextBox();
            label11 = new Label();
            txtPassword = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtDocumento = new TextBox();
            label6 = new Label();
            cboTipoDocumento = new ComboBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnContinuar = new Button();
            panelSocio = new Panel();
            btnSubirImagen = new Button();
            pbImagenCarnet = new PictureBox();
            lblImagenCarnet = new Label();
            cboPlanes = new ComboBox();
            lblSeleccionarPlan = new Label();
            btnVolver = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenCarnet).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panelSocio, 1, 0);
            tableLayoutPanel1.Location = new Point(-3, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(891, 611);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtNoSocio);
            panel1.Controls.Add(rbtSocio);
            panel1.Controls.Add(lblNombreArchivo);
            panel1.Controls.Add(btnAgregarAptoFisico);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtRepetirPassword);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboTipoDocumento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 550);
            panel1.TabIndex = 0;
            // 
            // rbtNoSocio
            // 
            rbtNoSocio.AutoSize = true;
            rbtNoSocio.Checked = true;
            rbtNoSocio.Location = new Point(310, 502);
            rbtNoSocio.Name = "rbtNoSocio";
            rbtNoSocio.Size = new Size(81, 19);
            rbtNoSocio.TabIndex = 35;
            rbtNoSocio.TabStop = true;
            rbtNoSocio.Text = "NO SOCIO";
            rbtNoSocio.UseVisualStyleBackColor = true;
            rbtNoSocio.CheckedChanged += rbtNoSocio_CheckedChanged;
            // 
            // rbtSocio
            // 
            rbtSocio.AutoSize = true;
            rbtSocio.Location = new Point(191, 502);
            rbtSocio.Name = "rbtSocio";
            rbtSocio.Size = new Size(60, 19);
            rbtSocio.TabIndex = 34;
            rbtSocio.Text = "SOCIO";
            rbtSocio.UseVisualStyleBackColor = true;
            rbtSocio.CheckedChanged += rbtSocio_CheckedChanged;
            // 
            // lblNombreArchivo
            // 
            lblNombreArchivo.AutoSize = true;
            lblNombreArchivo.Location = new Point(80, 456);
            lblNombreArchivo.Name = "lblNombreArchivo";
            lblNombreArchivo.Size = new Size(72, 15);
            lblNombreArchivo.TabIndex = 33;
            lblNombreArchivo.Text = "Archivo.png";
            lblNombreArchivo.Visible = false;
            // 
            // btnAgregarAptoFisico
            // 
            btnAgregarAptoFisico.Location = new Point(80, 386);
            btnAgregarAptoFisico.Name = "btnAgregarAptoFisico";
            btnAgregarAptoFisico.Size = new Size(412, 67);
            btnAgregarAptoFisico.TabIndex = 32;
            btnAgregarAptoFisico.Text = "SELECCIONAR ARCHIVO tipo .png .jpg .jpeg";
            btnAgregarAptoFisico.UseVisualStyleBackColor = true;
            btnAgregarAptoFisico.Click += btnAgregarAptoFisico_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(217, 371);
            label9.Name = "label9";
            label9.Size = new Size(103, 12);
            label9.TabIndex = 31;
            label9.Text = "AGREGAR APTO FÍSICO";
            // 
            // txtRepetirPassword
            // 
            txtRepetirPassword.Location = new Point(80, 329);
            txtRepetirPassword.Name = "txtRepetirPassword";
            txtRepetirPassword.PasswordChar = '*';
            txtRepetirPassword.Size = new Size(412, 23);
            txtRepetirPassword.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(80, 314);
            label11.Name = "label11";
            label11.Size = new Size(103, 12);
            label11.TabIndex = 29;
            label11.Text = "REPETIR CONTRASEÑA";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(80, 274);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(412, 23);
            txtPassword.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(80, 259);
            label8.Name = "label8";
            label8.Size = new Size(65, 12);
            label8.TabIndex = 23;
            label8.Text = "CONTRASEÑA";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(80, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(412, 23);
            txtEmail.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(80, 205);
            label7.Name = "label7";
            label7.Size = new Size(33, 12);
            label7.TabIndex = 21;
            label7.Text = "EMAIL";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(298, 159);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(194, 23);
            txtDocumento.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(298, 144);
            label6.Name = "label6";
            label6.Size = new Size(65, 12);
            label6.TabIndex = 19;
            label6.Text = "DOCUMENTO";
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(80, 159);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(194, 23);
            cboTipoDocumento.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(80, 144);
            label5.Name = "label5";
            label5.Size = new Size(102, 12);
            label5.TabIndex = 17;
            label5.Text = "TIPO DE DOCUMENTO";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(298, 99);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(194, 23);
            txtDireccion.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(298, 84);
            label4.Name = "label4";
            label4.Size = new Size(55, 12);
            label4.TabIndex = 15;
            label4.Text = "DIRECCIÓN";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(80, 99);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(194, 23);
            txtTelefono.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 84);
            label3.Name = "label3";
            label3.Size = new Size(51, 12);
            label3.TabIndex = 13;
            label3.Text = "TELÉFONO";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(298, 41);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(194, 23);
            txtApellido.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(298, 26);
            label2.Name = "label2";
            label2.Size = new Size(49, 12);
            label2.TabIndex = 11;
            label2.Text = "APELLIDO";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(80, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(194, 23);
            txtNombre.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 12);
            label1.TabIndex = 9;
            label1.Text = "NOMBRE";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnVolver);
            panel2.Controls.Add(btnContinuar);
            panel2.Location = new Point(3, 559);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 52);
            panel2.TabIndex = 1;
            // 
            // btnContinuar
            // 
            btnContinuar.Location = new Point(350, 0);
            btnContinuar.Margin = new Padding(3, 3, 3, 40);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(142, 40);
            btnContinuar.TabIndex = 25;
            btnContinuar.Text = "CONTINUAR";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // panelSocio
            // 
            panelSocio.Controls.Add(btnSubirImagen);
            panelSocio.Controls.Add(pbImagenCarnet);
            panelSocio.Controls.Add(lblImagenCarnet);
            panelSocio.Controls.Add(cboPlanes);
            panelSocio.Controls.Add(lblSeleccionarPlan);
            panelSocio.Location = new Point(582, 3);
            panelSocio.Name = "panelSocio";
            panelSocio.Size = new Size(306, 550);
            panelSocio.TabIndex = 2;
            // 
            // btnSubirImagen
            // 
            btnSubirImagen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSubirImagen.Location = new Point(70, 338);
            btnSubirImagen.Name = "btnSubirImagen";
            btnSubirImagen.Size = new Size(91, 25);
            btnSubirImagen.TabIndex = 29;
            btnSubirImagen.Text = "Seleccionar";
            btnSubirImagen.UseVisualStyleBackColor = true;
            btnSubirImagen.Click += btnSubirImagen_Click;
            // 
            // pbImagenCarnet
            // 
            pbImagenCarnet.Image = Properties.Resources.imagen_por_defecto;
            pbImagenCarnet.Location = new Point(70, 244);
            pbImagenCarnet.Margin = new Padding(0);
            pbImagenCarnet.Name = "pbImagenCarnet";
            pbImagenCarnet.Size = new Size(91, 91);
            pbImagenCarnet.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagenCarnet.TabIndex = 28;
            pbImagenCarnet.TabStop = false;
            // 
            // lblImagenCarnet
            // 
            lblImagenCarnet.AutoSize = true;
            lblImagenCarnet.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblImagenCarnet.Location = new Point(49, 225);
            lblImagenCarnet.Name = "lblImagenCarnet";
            lblImagenCarnet.Size = new Size(121, 12);
            lblImagenCarnet.TabIndex = 27;
            lblImagenCarnet.Text = "SUBIR IMAGEN DE CARNET";
            // 
            // cboPlanes
            // 
            cboPlanes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlanes.FormattingEnabled = true;
            cboPlanes.Location = new Point(3, 172);
            cboPlanes.Name = "cboPlanes";
            cboPlanes.Size = new Size(236, 23);
            cboPlanes.TabIndex = 26;
            // 
            // lblSeleccionarPlan
            // 
            lblSeleccionarPlan.AutoSize = true;
            lblSeleccionarPlan.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSeleccionarPlan.Location = new Point(3, 157);
            lblSeleccionarPlan.Name = "lblSeleccionarPlan";
            lblSeleccionarPlan.Size = new Size(92, 12);
            lblSeleccionarPlan.TabIndex = 25;
            lblSeleccionarPlan.Text = "SELECCIONAR PLAN";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(80, 0);
            btnVolver.Margin = new Padding(3, 3, 3, 40);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(142, 40);
            btnVolver.TabIndex = 26;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 616);
            Controls.Add(tableLayoutPanel1);
            Name = "FormRegistro";
            StartPosition = FormStartPosition.Manual;
            Text = "Registrarse";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panelSocio.ResumeLayout(false);
            panelSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImagenCarnet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private ComboBox cboTipoDocumento;
        private Label label6;
        private TextBox txtDocumento;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private TextBox txtPassword;
        private Label label11;
        private TextBox txtRepetirPassword;
        private Label label9;
        private Button btnAgregarAptoFisico;
        private Label lblNombreArchivo;
        private RadioButton rbtSocio;
        private RadioButton rbtNoSocio;
        private Panel panel2;
        private Button btnContinuar;
        private Panel panelSocio;
        private Label lblSeleccionarPlan;
        private ComboBox cboPlanes;
        private Label lblImagenCarnet;
        private PictureBox pbImagenCarnet;
        private Button btnSubirImagen;
        private Button btnVolver;
    }
}