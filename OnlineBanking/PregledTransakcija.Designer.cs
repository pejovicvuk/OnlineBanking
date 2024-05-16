namespace OnlineBanking
{
    partial class PregledTransakcija
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
            dataGridViewTransakcije = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransakcije).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransakcije
            // 
            dataGridViewTransakcije.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransakcije.Location = new Point(97, 71);
            dataGridViewTransakcije.Name = "dataGridViewTransakcije";
            dataGridViewTransakcije.Size = new Size(555, 294);
            dataGridViewTransakcije.TabIndex = 0;
            // 
            // PregledTransakcija
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewTransakcije);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PregledTransakcija";
            Text = "PregledTransakcija";
            Load += PregledTransakcija_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransakcije).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTransakcije;
    }
}