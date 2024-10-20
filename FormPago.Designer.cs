namespace IntegradorClubDeportivoEquipo4
{
    partial class FormPago
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
            label1 = new Label();
            txtMonto = new TextBox();
            label2 = new Label();
            rbtEfectivo = new RadioButton();
            rbtTarjeta = new RadioButton();
            lblCantCuotas = new Label();
            cboCantidadCuotas = new ComboBox();
            btnPagar = new Button();
            label4 = new Label();
            dgvActividades = new DataGridView();
            panelActividades = new Panel();
            panelPago = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvActividades).BeginInit();
            panelActividades.SuspendLayout();
            panelPago.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 17);
            label1.Name = "label1";
            label1.Size = new Size(79, 12);
            label1.TabIndex = 5;
            label1.Text = "MONTO A PAGAR";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(164, 32);
            txtMonto.Name = "txtMonto";
            txtMonto.ReadOnly = true;
            txtMonto.Size = new Size(322, 23);
            txtMonto.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(164, 89);
            label2.Name = "label2";
            label2.Size = new Size(78, 12);
            label2.TabIndex = 7;
            label2.Text = "FORMA DE PAGO";
            // 
            // rbtEfectivo
            // 
            rbtEfectivo.AutoSize = true;
            rbtEfectivo.Location = new Point(201, 122);
            rbtEfectivo.Name = "rbtEfectivo";
            rbtEfectivo.Size = new Size(76, 19);
            rbtEfectivo.TabIndex = 8;
            rbtEfectivo.Text = "EFECTIVO";
            rbtEfectivo.UseVisualStyleBackColor = true;
            rbtEfectivo.CheckedChanged += rbtEfectivo_CheckedChanged;
            // 
            // rbtTarjeta
            // 
            rbtTarjeta.AutoSize = true;
            rbtTarjeta.Checked = true;
            rbtTarjeta.Location = new Point(325, 122);
            rbtTarjeta.Name = "rbtTarjeta";
            rbtTarjeta.Size = new Size(134, 19);
            rbtTarjeta.TabIndex = 9;
            rbtTarjeta.TabStop = true;
            rbtTarjeta.Text = "TARJETA DE CRÉDITO";
            rbtTarjeta.UseVisualStyleBackColor = true;
            rbtTarjeta.CheckedChanged += rbtTarjeta_CheckedChanged;
            // 
            // lblCantCuotas
            // 
            lblCantCuotas.AutoSize = true;
            lblCantCuotas.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantCuotas.Location = new Point(164, 177);
            lblCantCuotas.Name = "lblCantCuotas";
            lblCantCuotas.Size = new Size(103, 12);
            lblCantCuotas.TabIndex = 10;
            lblCantCuotas.Text = "CANTIDAD DE CUOTAS";
            // 
            // cboCantidadCuotas
            // 
            cboCantidadCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCantidadCuotas.FormattingEnabled = true;
            cboCantidadCuotas.Location = new Point(164, 192);
            cboCantidadCuotas.Name = "cboCantidadCuotas";
            cboCantidadCuotas.Size = new Size(322, 23);
            cboCantidadCuotas.TabIndex = 11;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(273, 245);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(111, 50);
            btnPagar.TabIndex = 12;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 12);
            label4.TabIndex = 13;
            label4.Text = "SELECCIONAR ACTIVIDADES";
            // 
            // dgvActividades
            // 
            dgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActividades.Location = new Point(39, 34);
            dgvActividades.Name = "dgvActividades";
            dgvActividades.RowTemplate.Height = 25;
            dgvActividades.Size = new Size(577, 247);
            dgvActividades.TabIndex = 14;
            // 
            // panelActividades
            // 
            panelActividades.Controls.Add(label4);
            panelActividades.Controls.Add(dgvActividades);
            panelActividades.Location = new Point(28, 12);
            panelActividades.Name = "panelActividades";
            panelActividades.Size = new Size(663, 295);
            panelActividades.TabIndex = 15;
            // 
            // panelPago
            // 
            panelPago.Controls.Add(label3);
            panelPago.Controls.Add(label1);
            panelPago.Controls.Add(txtMonto);
            panelPago.Controls.Add(btnPagar);
            panelPago.Controls.Add(label2);
            panelPago.Controls.Add(cboCantidadCuotas);
            panelPago.Controls.Add(rbtEfectivo);
            panelPago.Controls.Add(lblCantCuotas);
            panelPago.Controls.Add(rbtTarjeta);
            panelPago.Location = new Point(28, 313);
            panelPago.Name = "panelPago";
            panelPago.Size = new Size(663, 322);
            panelPago.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 35);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 13;
            label3.Text = "$";
            // 
            // FormPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 647);
            Controls.Add(panelPago);
            Controls.Add(panelActividades);
            Name = "FormPago";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Realizar Pago";
            Load += FormPago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvActividades).EndInit();
            panelActividades.ResumeLayout(false);
            panelActividades.PerformLayout();
            panelPago.ResumeLayout(false);
            panelPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMonto;
        private Label label2;
        private RadioButton rbtEfectivo;
        private RadioButton rbtTarjeta;
        private Label lblCantCuotas;
        private ComboBox cboCantidadCuotas;
        private Button btnPagar;
        private Label label4;
        private DataGridView dgvActividades;
        private Panel panelActividades;
        private Panel panelPago;
        private Label label3;
    }
}