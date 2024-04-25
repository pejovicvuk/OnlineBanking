namespace OnlineBanking
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
            labelRegisterPass.Location = new Point(320, 216);
            labelRegisterPass.Name = "labelRegisterPass";
            labelRegisterPass.Size = new Size(50, 15);
            labelRegisterPass.TabIndex = 17;
            labelRegisterPass.Text = "Lozinka:";
            // 
            // labelRegisterEmail
            // 
            labelRegisterEmail.AutoSize = true;
            labelRegisterEmail.Location = new Point(320, 187);
            labelRegisterEmail.Name = "labelRegisterEmail";
            labelRegisterEmail.Size = new Size(39, 15);
            labelRegisterEmail.TabIndex = 16;
            labelRegisterEmail.Text = "Email:";
            // 
            // labelRegisterPrezime
            // 
            labelRegisterPrezime.AutoSize = true;
            labelRegisterPrezime.Location = new Point(320, 158);
            labelRegisterPrezime.Name = "labelRegisterPrezime";
            labelRegisterPrezime.Size = new Size(52, 15);
            labelRegisterPrezime.TabIndex = 15;
            labelRegisterPrezime.Text = "Prezime:";
            // 
            // labelRegisterIme
            // 
            labelRegisterIme.AutoSize = true;
            labelRegisterIme.Location = new Point(320, 132);
            labelRegisterIme.Name = "labelRegisterIme";
            labelRegisterIme.Size = new Size(30, 15);
            labelRegisterIme.TabIndex = 14;
            labelRegisterIme.Text = "Ime:";
            // 
            // textBoxRegisterIme
            // 
            textBoxRegisterIme.Location = new Point(381, 126);
            textBoxRegisterIme.Name = "textBoxRegisterIme";
            textBoxRegisterIme.Size = new Size(100, 23);
            textBoxRegisterIme.TabIndex = 13;
            // 
            // textBoxRegisterPrezime
            // 
            textBoxRegisterPrezime.Location = new Point(381, 155);
            textBoxRegisterPrezime.Name = "textBoxRegisterPrezime";
            textBoxRegisterPrezime.Size = new Size(100, 23);
            textBoxRegisterPrezime.TabIndex = 12;
            // 
            // textBoxRegisterPass
            // 
            textBoxRegisterPass.Location = new Point(381, 213);
            textBoxRegisterPass.Name = "textBoxRegisterPass";
            textBoxRegisterPass.Size = new Size(100, 23);
            textBoxRegisterPass.TabIndex = 11;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(336, 269);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(127, 42);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Napravi Nalog";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxRegisterEmail
            // 
            textBoxRegisterEmail.Location = new Point(381, 184);
            textBoxRegisterEmail.Name = "textBoxRegisterEmail";
            textBoxRegisterEmail.Size = new Size(100, 23);
            textBoxRegisterEmail.TabIndex = 9;
            // 
            // labelRegister
            // 
            labelRegister.AutoSize = true;
            labelRegister.Location = new Point(484, 269);
            labelRegister.Name = "labelRegister";
            labelRegister.Size = new Size(78, 30);
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