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
            textBoxRegisterEmail = new TextBox();
            buttonRegisterEmail = new Button();
            textBoxRegisterPass = new TextBox();
            textBoxRegisterPrezime = new TextBox();
            textBoxRegisterIme = new TextBox();
            labelRegisterIme = new Label();
            labelRegisterPrezime = new Label();
            labelRegisterEmail = new Label();
            labelRegisterPass = new Label();
            labelImateNalog = new Label();
            SuspendLayout();
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.Location = new Point(320, 119);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.Size = new Size(100, 23);
            textBoxRegisterEmail.TabIndex = 0;
            // 
            // buttonRegisterEmail
            // 
            buttonRegisterEmail.Location = new Point(259, 223);
            buttonRegisterEmail.Name = "buttonRegisterEmail";
            buttonRegisterEmail.Size = new Size(127, 42);
            buttonRegisterEmail.TabIndex = 1;
            buttonRegisterEmail.Text = "Napravi Nalog";
            buttonRegisterEmail.UseVisualStyleBackColor = true;
            buttonRegisterEmail.Click += buttonRegisterEmail_Click;
            // 
            // textBoxRegisterPass
            // 
            textBoxRegisterPass.Location = new Point(320, 148);
            textBoxRegisterPass.Name = "textBoxRegisterPass";
            textBoxRegisterPass.Size = new Size(100, 23);
            textBoxRegisterPass.TabIndex = 2;
            // 
            // textBoxRegisterPrezime
            // 
            textBoxRegisterPrezime.Location = new Point(320, 90);
            textBoxRegisterPrezime.Name = "textBoxRegisterPrezime";
            textBoxRegisterPrezime.Size = new Size(100, 23);
            textBoxRegisterPrezime.TabIndex = 3;
            // 
            // textBoxRegisterIme
            // 
            textBoxRegisterIme.Location = new Point(320, 61);
            textBoxRegisterIme.Name = "textBoxRegisterIme";
            textBoxRegisterIme.Size = new Size(100, 23);
            textBoxRegisterIme.TabIndex = 4;
            // 
            // labelRegisterIme
            // 
            labelRegisterIme.AutoSize = true;
            labelRegisterIme.Location = new Point(259, 67);
            labelRegisterIme.Name = "labelRegisterIme";
            labelRegisterIme.Size = new Size(30, 15);
            labelRegisterIme.TabIndex = 5;
            labelRegisterIme.Text = "Ime:";
            // 
            // labelRegisterPrezime
            // 
            labelRegisterPrezime.AutoSize = true;
            labelRegisterPrezime.Location = new Point(259, 93);
            labelRegisterPrezime.Name = "labelRegisterPrezime";
            labelRegisterPrezime.Size = new Size(52, 15);
            labelRegisterPrezime.TabIndex = 6;
            labelRegisterPrezime.Text = "Prezime:";
            // 
            // labelRegisterEmail
            // 
            labelRegisterEmail.AutoSize = true;
            labelRegisterEmail.Location = new Point(259, 122);
            labelRegisterEmail.Name = "labelRegisterEmail";
            labelRegisterEmail.Size = new Size(39, 15);
            labelRegisterEmail.TabIndex = 7;
            labelRegisterEmail.Text = "Email:";
            // 
            // labelRegisterPass
            // 
            labelRegisterPass.AutoSize = true;
            labelRegisterPass.Location = new Point(259, 151);
            labelRegisterPass.Name = "labelRegisterPass";
            labelRegisterPass.Size = new Size(50, 15);
            labelRegisterPass.TabIndex = 8;
            labelRegisterPass.Text = "Lozinka:";
            // 
            // labelImateNalog
            // 
            labelImateNalog.AutoSize = true;
            labelImateNalog.Location = new Point(450, 235);
            labelImateNalog.Name = "labelImateNalog";
            labelImateNalog.Size = new Size(75, 30);
            labelImateNalog.TabIndex = 9;
            labelImateNalog.Text = "Imate nalog?\r\nUlogujte se";
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(labelImateNalog);
            Controls.Add(labelRegisterPass);
            Controls.Add(labelRegisterEmail);
            Controls.Add(labelRegisterPrezime);
            Controls.Add(labelRegisterIme);
            Controls.Add(textBoxRegisterIme);
            Controls.Add(textBoxRegisterPrezime);
            Controls.Add(textBoxRegisterPass);
            Controls.Add(buttonRegisterEmail);
            Controls.Add(textBoxRegisterEmail);
            Name = "Pocetna";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRegisterEmail;
        private Button buttonRegisterEmail;
        private TextBox textBoxRegisterPass;
        private TextBox textBoxRegisterPrezime;
        private TextBox textBoxRegisterIme;
        private Label labelRegisterIme;
        private Label labelRegisterPrezime;
        private Label labelRegisterEmail;
        private Label labelRegisterPass;
        private Label labelImateNalog;
    }
}
