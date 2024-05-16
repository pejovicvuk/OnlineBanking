namespace OnlineBanking
{
    partial class NovoPlacanje
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
            comboBoxPlacanje = new ComboBox();
            textBoxPrimaoc = new TextBox();
            textBoxPlacanjeSuma = new TextBox();
            buttonUplati = new Button();
            labelPrimaoc = new Label();
            labelSumaPlacanje = new Label();
            SuspendLayout();
            // 
            // comboBoxPlacanje
            // 
            comboBoxPlacanje.FormattingEnabled = true;
            comboBoxPlacanje.Location = new Point(77, 80);
            comboBoxPlacanje.Name = "comboBoxPlacanje";
            comboBoxPlacanje.Size = new Size(198, 23);
            comboBoxPlacanje.TabIndex = 0;
            // 
            // textBoxPrimaoc
            // 
            textBoxPrimaoc.Location = new Point(301, 80);
            textBoxPrimaoc.Name = "textBoxPrimaoc";
            textBoxPrimaoc.Size = new Size(100, 23);
            textBoxPrimaoc.TabIndex = 1;
            // 
            // textBoxPlacanjeSuma
            // 
            textBoxPlacanjeSuma.Location = new Point(435, 80);
            textBoxPlacanjeSuma.Name = "textBoxPlacanjeSuma";
            textBoxPlacanjeSuma.Size = new Size(100, 23);
            textBoxPlacanjeSuma.TabIndex = 2;
            // 
            // buttonUplati
            // 
            buttonUplati.Location = new Point(287, 153);
            buttonUplati.Name = "buttonUplati";
            buttonUplati.Size = new Size(126, 43);
            buttonUplati.TabIndex = 3;
            buttonUplati.Text = "Izvrsi uplatu";
            buttonUplati.UseVisualStyleBackColor = true;
            buttonUplati.Click += buttonUplati_Click;
            // 
            // labelPrimaoc
            // 
            labelPrimaoc.AutoSize = true;
            labelPrimaoc.Location = new Point(301, 51);
            labelPrimaoc.Name = "labelPrimaoc";
            labelPrimaoc.Size = new Size(96, 15);
            labelPrimaoc.TabIndex = 4;
            labelPrimaoc.Text = "Racun Primaoca:";
            // 
            // labelSumaPlacanje
            // 
            labelSumaPlacanje.AutoSize = true;
            labelSumaPlacanje.Location = new Point(435, 51);
            labelSumaPlacanje.Name = "labelSumaPlacanje";
            labelSumaPlacanje.Size = new Size(40, 15);
            labelSumaPlacanje.TabIndex = 5;
            labelSumaPlacanje.Text = "Suma:";
            // 
            // NovoPlacanje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSumaPlacanje);
            Controls.Add(labelPrimaoc);
            Controls.Add(buttonUplati);
            Controls.Add(textBoxPlacanjeSuma);
            Controls.Add(textBoxPrimaoc);
            Controls.Add(comboBoxPlacanje);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NovoPlacanje";
            Text = "NovoPlacanje";
            Load += NovoPlacanje_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPlacanje;
        private TextBox textBoxPrimaoc;
        private TextBox textBoxPlacanjeSuma;
        private Button buttonUplati;
        private Label labelPrimaoc;
        private Label labelSumaPlacanje;
    }
}