namespace OnlineBanking
{
    partial class Nalog
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
            labelNalogIme = new Label();
            labelNalogPrezime = new Label();
            labelNalogEmail = new Label();
            labelNalogSifra = new Label();
            textBoxNalogIme = new TextBox();
            textBoxNalogPrezime = new TextBox();
            textBoxNalogEmail = new TextBox();
            textBoxNalogSifra = new TextBox();
            checkBoxViewPass = new CheckBox();
            buttonNalogLogout = new Button();
            SuspendLayout();
            // 
            // labelNalogIme
            // 
            labelNalogIme.AutoSize = true;
            labelNalogIme.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNalogIme.Location = new Point(89, 54);
            labelNalogIme.Name = "labelNalogIme";
            labelNalogIme.Size = new Size(48, 30);
            labelNalogIme.TabIndex = 1;
            labelNalogIme.Text = "Ime";
            // 
            // labelNalogPrezime
            // 
            labelNalogPrezime.AutoSize = true;
            labelNalogPrezime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNalogPrezime.Location = new Point(89, 97);
            labelNalogPrezime.Name = "labelNalogPrezime";
            labelNalogPrezime.Size = new Size(87, 30);
            labelNalogPrezime.TabIndex = 2;
            labelNalogPrezime.Text = "Prezime";
            // 
            // labelNalogEmail
            // 
            labelNalogEmail.AutoSize = true;
            labelNalogEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNalogEmail.Location = new Point(89, 139);
            labelNalogEmail.Name = "labelNalogEmail";
            labelNalogEmail.Size = new Size(63, 30);
            labelNalogEmail.TabIndex = 3;
            labelNalogEmail.Text = "Email";
            // 
            // labelNalogSifra
            // 
            labelNalogSifra.AutoSize = true;
            labelNalogSifra.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNalogSifra.Location = new Point(89, 186);
            labelNalogSifra.Name = "labelNalogSifra";
            labelNalogSifra.Size = new Size(83, 30);
            labelNalogSifra.TabIndex = 4;
            labelNalogSifra.Text = "Lozinka";
            // 
            // textBoxNalogIme
            // 
            textBoxNalogIme.Location = new Point(238, 61);
            textBoxNalogIme.Name = "textBoxNalogIme";
            textBoxNalogIme.ReadOnly = true;
            textBoxNalogIme.Size = new Size(224, 23);
            textBoxNalogIme.TabIndex = 5;
            // 
            // textBoxNalogPrezime
            // 
            textBoxNalogPrezime.Location = new Point(238, 104);
            textBoxNalogPrezime.Name = "textBoxNalogPrezime";
            textBoxNalogPrezime.ReadOnly = true;
            textBoxNalogPrezime.Size = new Size(224, 23);
            textBoxNalogPrezime.TabIndex = 6;
            // 
            // textBoxNalogEmail
            // 
            textBoxNalogEmail.Location = new Point(238, 146);
            textBoxNalogEmail.Name = "textBoxNalogEmail";
            textBoxNalogEmail.ReadOnly = true;
            textBoxNalogEmail.Size = new Size(224, 23);
            textBoxNalogEmail.TabIndex = 7;
            // 
            // textBoxNalogSifra
            // 
            textBoxNalogSifra.Location = new Point(238, 193);
            textBoxNalogSifra.Name = "textBoxNalogSifra";
            textBoxNalogSifra.PasswordChar = '*';
            textBoxNalogSifra.ReadOnly = true;
            textBoxNalogSifra.Size = new Size(224, 23);
            textBoxNalogSifra.TabIndex = 8;
            // 
            // checkBoxViewPass
            // 
            checkBoxViewPass.AutoSize = true;
            checkBoxViewPass.Location = new Point(490, 197);
            checkBoxViewPass.Name = "checkBoxViewPass";
            checkBoxViewPass.Size = new Size(61, 19);
            checkBoxViewPass.TabIndex = 9;
            checkBoxViewPass.Text = "Otkriji ";
            checkBoxViewPass.UseVisualStyleBackColor = true;
            checkBoxViewPass.CheckedChanged += checkBoxViewPass_CheckedChanged;
            // 
            // buttonNalogLogout
            // 
            buttonNalogLogout.BackColor = Color.FromArgb(255, 128, 128);
            buttonNalogLogout.FlatStyle = FlatStyle.Flat;
            buttonNalogLogout.ForeColor = SystemColors.ButtonFace;
            buttonNalogLogout.Location = new Point(675, 385);
            buttonNalogLogout.Name = "buttonNalogLogout";
            buttonNalogLogout.Size = new Size(84, 25);
            buttonNalogLogout.TabIndex = 10;
            buttonNalogLogout.Text = "Logout";
            buttonNalogLogout.UseVisualStyleBackColor = false;
            buttonNalogLogout.Click += buttonNalogLogout_Click;
            // 
            // Nalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonNalogLogout);
            Controls.Add(checkBoxViewPass);
            Controls.Add(textBoxNalogSifra);
            Controls.Add(textBoxNalogEmail);
            Controls.Add(textBoxNalogPrezime);
            Controls.Add(textBoxNalogIme);
            Controls.Add(labelNalogSifra);
            Controls.Add(labelNalogEmail);
            Controls.Add(labelNalogPrezime);
            Controls.Add(labelNalogIme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nalog";
            Text = "Nalog";
            Load += Nalog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNalogIme;
        private Label labelNalogPrezime;
        private Label labelNalogEmail;
        private Label labelNalogSifra;
        private TextBox textBoxNalogIme;
        private TextBox textBoxNalogPrezime;
        private TextBox textBoxNalogEmail;
        private TextBox textBoxNalogSifra;
        private CheckBox checkBoxViewPass;
        private Button buttonNalogLogout;
    }
}