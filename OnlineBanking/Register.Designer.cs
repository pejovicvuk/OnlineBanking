﻿namespace OnlineBanking
{
    partial class Register
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
            labelRegisterPass = new Label();
            labelRegisterEmail = new Label();
            labelRegisterPrezime = new Label();
            labelRegisterIme = new Label();
            textBoxRegisterIme = new TextBox();
            textBoxRegisterPrezime = new TextBox();
            textBoxRegisterPass = new TextBox();
            buttonRegister = new Button();
            textBoxRegisterEmail = new TextBox();
            labelRegister = new Label();
            SuspendLayout();
            // 
            // labelRegisterPass
            // 
            labelRegisterPass.AutoSize = true;
            labelRegisterPass.Location = new Point(276, 188);
            labelRegisterPass.Name = "labelRegisterPass";
            labelRegisterPass.Size = new Size(50, 15);
            labelRegisterPass.TabIndex = 17;
            labelRegisterPass.Text = "Lozinka:";
            // 
            // labelRegisterEmail
            // 
            labelRegisterEmail.AutoSize = true;
            labelRegisterEmail.Location = new Point(276, 159);
            labelRegisterEmail.Name = "labelRegisterEmail";
            labelRegisterEmail.Size = new Size(39, 15);
            labelRegisterEmail.TabIndex = 16;
            labelRegisterEmail.Text = "Email:";
            // 
            // labelRegisterPrezime
            // 
            labelRegisterPrezime.AutoSize = true;
            labelRegisterPrezime.Location = new Point(276, 130);
            labelRegisterPrezime.Name = "labelRegisterPrezime";
            labelRegisterPrezime.Size = new Size(52, 15);
            labelRegisterPrezime.TabIndex = 15;
            labelRegisterPrezime.Text = "Prezime:";
            // 
            // labelRegisterIme
            // 
            labelRegisterIme.AutoSize = true;
            labelRegisterIme.Location = new Point(276, 104);
            labelRegisterIme.Name = "labelRegisterIme";
            labelRegisterIme.Size = new Size(30, 15);
            labelRegisterIme.TabIndex = 14;
            labelRegisterIme.Text = "Ime:";
            // 
            // textBoxRegisterIme
            // 
            textBoxRegisterIme.Location = new Point(337, 98);
            textBoxRegisterIme.Name = "textBoxRegisterIme";
            textBoxRegisterIme.Size = new Size(124, 23);
            textBoxRegisterIme.TabIndex = 13;
            // 
            // textBoxRegisterPrezime
            // 
            textBoxRegisterPrezime.Location = new Point(337, 127);
            textBoxRegisterPrezime.Name = "textBoxRegisterPrezime";
            textBoxRegisterPrezime.Size = new Size(124, 23);
            textBoxRegisterPrezime.TabIndex = 12;
            // 
            // textBoxRegisterPass
            // 
            textBoxRegisterPass.Location = new Point(337, 185);
            textBoxRegisterPass.Name = "textBoxRegisterPass";
            textBoxRegisterPass.Size = new Size(124, 23);
            textBoxRegisterPass.TabIndex = 11;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(254, 226, 113);
            buttonRegister.Location = new Point(299, 238);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(162, 42);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Napravi Nalog";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.Location = new Point(337, 156);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.Size = new Size(124, 23);
            textBoxRegisterEmail.TabIndex = 9;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRegister.Location = new Point(337, 302);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(87, 34);
            labelRegister.TabIndex = 18;
            labelRegister.Text = "Imate nalog? \r\nUlogujte se";
            labelRegister.Click += labelRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRegister);
            Controls.Add(labelRegisterPass);
            Controls.Add(labelRegisterEmail);
            Controls.Add(labelRegisterPrezime);
            Controls.Add(labelRegisterIme);
            Controls.Add(textBoxRegisterIme);
            Controls.Add(textBoxRegisterPrezime);
            Controls.Add(textBoxRegisterPass);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxRegisterEmail);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRegisterPass;
        private Label labelRegisterEmail;
        private Label labelRegisterPrezime;
        private Label labelRegisterIme;
        private TextBox textBoxRegisterIme;
        private TextBox textBoxRegisterPrezime;
        private TextBox textBoxRegisterPass;
        private Button buttonRegister;
        private TextBox textBoxRegisterEmail;
        private Label labelRegister;
    }
}