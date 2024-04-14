namespace OnlineBanking
{
    partial class Pocetna
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
            textBoxLoginEmail = new TextBox();
            buttonLoginEmail = new Button();
            textBoxLoginPass = new TextBox();
            textBoxLoginPrezime = new TextBox();
            textBoxLoginIme = new TextBox();
            labelLoginIme = new Label();
            labelLoginPrezime = new Label();
            labelLoginEmail = new Label();
            labelLoginPass = new Label();
            SuspendLayout();
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Location = new Point(320, 119);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(100, 23);
            textBoxLoginEmail.TabIndex = 0;
            // 
            // buttonLoginEmail
            // 
            buttonLoginEmail.Location = new Point(293, 217);
            buttonLoginEmail.Name = "buttonLoginEmail";
            buttonLoginEmail.Size = new Size(127, 42);
            buttonLoginEmail.TabIndex = 1;
            buttonLoginEmail.Text = "Napravi Nalog";
            buttonLoginEmail.UseVisualStyleBackColor = true;
            buttonLoginEmail.Click += buttonLoginEmail_Click;
            // 
            // textBoxLoginPass
            // 
            textBoxLoginPass.Location = new Point(320, 148);
            textBoxLoginPass.Name = "textBoxLoginPass";
            textBoxLoginPass.Size = new Size(100, 23);
            textBoxLoginPass.TabIndex = 2;
            // 
            // textBoxLoginPrezime
            // 
            textBoxLoginPrezime.Location = new Point(320, 90);
            textBoxLoginPrezime.Name = "textBoxLoginPrezime";
            textBoxLoginPrezime.Size = new Size(100, 23);
            textBoxLoginPrezime.TabIndex = 3;
            // 
            // textBoxLoginIme
            // 
            textBoxLoginIme.Location = new Point(320, 61);
            textBoxLoginIme.Name = "textBoxLoginIme";
            textBoxLoginIme.Size = new Size(100, 23);
            textBoxLoginIme.TabIndex = 4;
            // 
            // labelLoginIme
            // 
            labelLoginIme.AutoSize = true;
            labelLoginIme.Location = new Point(259, 67);
            labelLoginIme.Name = "labelLoginIme";
            labelLoginIme.Size = new Size(30, 15);
            labelLoginIme.TabIndex = 5;
            labelLoginIme.Text = "Ime:";
            // 
            // labelLoginPrezime
            // 
            labelLoginPrezime.AutoSize = true;
            labelLoginPrezime.Location = new Point(259, 93);
            labelLoginPrezime.Name = "labelLoginPrezime";
            labelLoginPrezime.Size = new Size(52, 15);
            labelLoginPrezime.TabIndex = 6;
            labelLoginPrezime.Text = "Prezime:";
            // 
            // labelLoginEmail
            // 
            labelLoginEmail.AutoSize = true;
            labelLoginEmail.Location = new Point(259, 122);
            labelLoginEmail.Name = "labelLoginEmail";
            labelLoginEmail.Size = new Size(39, 15);
            labelLoginEmail.TabIndex = 7;
            labelLoginEmail.Text = "Email:";
            // 
            // labelLoginPass
            // 
            labelLoginPass.AutoSize = true;
            labelLoginPass.Location = new Point(259, 151);
            labelLoginPass.Name = "labelLoginPass";
            labelLoginPass.Size = new Size(50, 15);
            labelLoginPass.TabIndex = 8;
            labelLoginPass.Text = "Lozinka:";
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLoginPass);
            Controls.Add(labelLoginEmail);
            Controls.Add(labelLoginPrezime);
            Controls.Add(labelLoginIme);
            Controls.Add(textBoxLoginIme);
            Controls.Add(textBoxLoginPrezime);
            Controls.Add(textBoxLoginPass);
            Controls.Add(buttonLoginEmail);
            Controls.Add(textBoxLoginEmail);
            Name = "Pocetna";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLoginEmail;
        private Button buttonLoginEmail;
        private TextBox textBoxLoginPass;
        private TextBox textBoxLoginPrezime;
        private TextBox textBoxLoginIme;
        private Label labelLoginIme;
        private Label labelLoginPrezime;
        private Label labelLoginEmail;
        private Label labelLoginPass;
    }
}
