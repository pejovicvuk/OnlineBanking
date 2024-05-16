namespace OnlineBanking
{
    partial class Racuni
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
            panelRacuni = new Panel();
            labelRacuni = new Label();
            dataGridViewRacuni = new DataGridView();
            buttonKreirajRacun = new Button();
            panelRacuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRacuni).BeginInit();
            SuspendLayout();
            // 
            // panelRacuni
            // 
            panelRacuni.AccessibleName = "";
            panelRacuni.BackColor = Color.FromArgb(23, 24, 29);
            panelRacuni.Controls.Add(labelRacuni);
            panelRacuni.Dock = DockStyle.Top;
            panelRacuni.Location = new Point(0, 0);
            panelRacuni.Name = "panelRacuni";
            panelRacuni.Size = new Size(800, 35);
            panelRacuni.TabIndex = 0;
            // 
            // labelRacuni
            // 
            labelRacuni.AutoSize = true;
            labelRacuni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRacuni.ForeColor = Color.White;
            labelRacuni.Location = new Point(340, 9);
            labelRacuni.Name = "labelRacuni";
            labelRacuni.Size = new Size(104, 25);
            labelRacuni.TabIndex = 0;
            labelRacuni.Text = "Vaši računi";
            labelRacuni.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridViewRacuni
            // 
            dataGridViewRacuni.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRacuni.Location = new Point(128, 55);
            dataGridViewRacuni.Name = "dataGridViewRacuni";
            dataGridViewRacuni.Size = new Size(535, 206);
            dataGridViewRacuni.TabIndex = 1;
            // 
            // buttonKreirajRacun
            // 
            buttonKreirajRacun.Location = new Point(307, 297);
            buttonKreirajRacun.Name = "buttonKreirajRacun";
            buttonKreirajRacun.Size = new Size(154, 42);
            buttonKreirajRacun.TabIndex = 2;
            buttonKreirajRacun.Text = "Kreiraj Racun";
            buttonKreirajRacun.UseVisualStyleBackColor = true;
            buttonKreirajRacun.Click += buttonKreirajRacun_Click;
            // 
            // Racuni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonKreirajRacun);
            Controls.Add(dataGridViewRacuni);
            Controls.Add(panelRacuni);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Racuni";
            Text = "Racuni";
            Load += Racuni_Load;
            panelRacuni.ResumeLayout(false);
            panelRacuni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRacuni).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRacuni;
        private Label labelRacuni;
        private DataGridView dataGridViewRacuni;
        private Button buttonKreirajRacun;
    }
}