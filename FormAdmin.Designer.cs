﻿namespace IntegradorClubDeportivoEquipo4
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
            rtxtAdmin = new RichTextBox();
            SuspendLayout();
            // 
            // rtxtAdmin
            // 
            rtxtAdmin.Location = new Point(240, 86);
            rtxtAdmin.Name = "rtxtAdmin";
            rtxtAdmin.Size = new Size(294, 271);
            rtxtAdmin.TabIndex = 0;
            rtxtAdmin.Text = "";
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtxtAdmin);
            Name = "FormAdmin";
            Text = "FormAdmin";
            Load += FormAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxtAdmin;
    }
}