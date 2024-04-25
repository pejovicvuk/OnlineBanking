namespace OnlineBanking
{
    partial class Login
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
            textBoxLoginEmail = new TextBox();
            textBoxLoginPass = new TextBox();
            buttonLogin = new Button();
            labelLoginEmail = new Label();
            labelLoginPass = new Label();
            SuspendLayout();
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Location = new Point(309, 91);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(100, 23);
            textBoxLoginEmail.TabIndex = 0;
            // 
            // textBoxLoginPass
            // 
            textBoxLoginPass.Location = new Point(309, 139);
            textBoxLoginPass.Name = "textBoxLoginPass";
            textBoxLoginPass.Size = new Size(100, 23);
            textBoxLoginPass.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(309, 215);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(133, 48);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Uloguj Se";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelLoginEmail
            // 
            labelLoginEmail.AutoSize = true;
            labelLoginEmail.Location = new Point(250, 94);
            labelLoginEmail.Name = "labelLoginEmail";
            labelLoginEmail.Size = new Size(36, 15);
            labelLoginEmail.TabIndex = 3;
            labelLoginEmail.Text = "Email";
            // 
            // labelLoginPass
            // 
            labelLoginPass.AutoSize = true;
            labelLoginPass.Location = new Point(250, 142);
            labelLoginPass.Name = "labelLoginPass";
            labelLoginPass.Size = new Size(47, 15);
            labelLoginPass.TabIndex = 4;
            labelLoginPass.Text = "Lozinka";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelLoginPass);
            Controls.Add(labelLoginEmail);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxLoginPass);
            Controls.Add(textBoxLoginEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLoginEmail;
        private TextBox textBoxLoginPass;
        private Button buttonLogin;
        private Label labelLoginEmail;
        private Label labelLoginPass;
    }
}