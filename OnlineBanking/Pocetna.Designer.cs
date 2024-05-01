namespace OnlineBanking
{
    partial class Pocetna
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
            textBoxStanje = new TextBox();
            labelStanje = new Label();
            labelBankomat = new Label();
            textBoxKoliko = new TextBox();
            buttonDeposit = new Button();
            comboBoxBankomat = new ComboBox();
            labelOdaberiRacun = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            labelRsd = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStanje
            // 
            textBoxStanje.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxStanje.Location = new Point(276, 80);
            textBoxStanje.Name = "textBoxStanje";
            textBoxStanje.ReadOnly = true;
            textBoxStanje.Size = new Size(241, 43);
            textBoxStanje.TabIndex = 1;
            // 
            // labelStanje
            // 
            labelStanje.AutoSize = true;
            labelStanje.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStanje.ForeColor = SystemColors.ControlLightLight;
            labelStanje.Location = new Point(114, -4);
            labelStanje.Name = "labelStanje";
            labelStanje.Size = new Size(152, 30);
            labelStanje.TabIndex = 2;
            labelStanje.Text = "Ukupno Stanje:";
            // 
            // labelBankomat
            // 
            labelBankomat.AutoSize = true;
            labelBankomat.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBankomat.ForeColor = SystemColors.ControlLightLight;
            labelBankomat.Location = new Point(115, -6);
            labelBankomat.Name = "labelBankomat";
            labelBankomat.Size = new Size(111, 30);
            labelBankomat.TabIndex = 3;
            labelBankomat.Text = "Bankomat:";
            // 
            // textBoxKoliko
            // 
            textBoxKoliko.Location = new Point(307, 280);
            textBoxKoliko.Name = "textBoxKoliko";
            textBoxKoliko.Size = new Size(148, 23);
            textBoxKoliko.TabIndex = 4;
            // 
            // buttonDeposit
            // 
            buttonDeposit.Location = new Point(317, 337);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(126, 32);
            buttonDeposit.TabIndex = 6;
            buttonDeposit.Text = "Depozit";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // comboBoxBankomat
            // 
            comboBoxBankomat.FormattingEnabled = true;
            comboBoxBankomat.Location = new Point(322, 236);
            comboBoxBankomat.Name = "comboBoxBankomat";
            comboBoxBankomat.Size = new Size(121, 23);
            comboBoxBankomat.TabIndex = 7;
            // 
            // labelOdaberiRacun
            // 
            labelOdaberiRacun.AutoSize = true;
            labelOdaberiRacun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOdaberiRacun.Location = new Point(114, 234);
            labelOdaberiRacun.Name = "labelOdaberiRacun";
            labelOdaberiRacun.Size = new Size(190, 21);
            labelOdaberiRacun.TabIndex = 8;
            labelOdaberiRacun.Text = "Odaberi Racun za depozit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(114, 280);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 9;
            label3.Text = "Koliko novca:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(labelBankomat);
            panel1.Location = new Point(-1, 194);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 26);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(23, 24, 29);
            panel2.Controls.Add(labelStanje);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 26);
            panel2.TabIndex = 11;
            // 
            // labelRsd
            // 
            labelRsd.AutoSize = true;
            labelRsd.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRsd.ForeColor = SystemColors.ActiveCaptionText;
            labelRsd.Location = new Point(523, 89);
            labelRsd.Name = "labelRsd";
            labelRsd.Size = new Size(41, 30);
            labelRsd.TabIndex = 3;
            labelRsd.Text = "rsd";
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRsd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(labelOdaberiRacun);
            Controls.Add(comboBoxBankomat);
            Controls.Add(buttonDeposit);
            Controls.Add(textBoxKoliko);
            Controls.Add(textBoxStanje);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pocetna";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pocetna";
            Load += Pocetna_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxStanje;
        private Label labelStanje;
        private Label labelBankomat;
        private TextBox textBoxKoliko;
        private Button buttonDeposit;
        private ComboBox comboBoxBankomat;
        private Label labelOdaberiRacun;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label labelRsd;
    }
}