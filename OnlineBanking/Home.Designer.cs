namespace OnlineBanking
{
    partial class Home
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
            components = new System.ComponentModel.Container();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonPocetna = new Button();
            flowLayoutPanelTransakcije = new FlowLayoutPanel();
            buttonTransakcije = new Button();
            button4 = new Button();
            button3 = new Button();
            buttonNalog = new Button();
            button1 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanelTransakcije.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanel1.Controls.Add(buttonPocetna);
            flowLayoutPanel1.Controls.Add(flowLayoutPanelTransakcije);
            flowLayoutPanel1.Controls.Add(buttonNalog);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(202, 561);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // buttonPocetna
            // 
            buttonPocetna.BackColor = Color.FromArgb(32, 33, 36);
            buttonPocetna.FlatStyle = FlatStyle.Flat;
            buttonPocetna.ForeColor = SystemColors.Control;
            buttonPocetna.Location = new Point(3, 3);
            buttonPocetna.Name = "buttonPocetna";
            buttonPocetna.Size = new Size(195, 42);
            buttonPocetna.TabIndex = 2;
            buttonPocetna.Text = "Pocetna";
            buttonPocetna.UseVisualStyleBackColor = false;
            buttonPocetna.Click += buttonPocetna_Click;
            // 
            // flowLayoutPanelTransakcije
            // 
            flowLayoutPanelTransakcije.BackColor = Color.FromArgb(23, 24, 29);
            flowLayoutPanelTransakcije.Controls.Add(buttonTransakcije);
            flowLayoutPanelTransakcije.Controls.Add(button4);
            flowLayoutPanelTransakcije.Controls.Add(button3);
            flowLayoutPanelTransakcije.Location = new Point(0, 48);
            flowLayoutPanelTransakcije.Margin = new Padding(0);
            flowLayoutPanelTransakcije.Name = "flowLayoutPanelTransakcije";
            flowLayoutPanelTransakcije.Size = new Size(202, 53);
            flowLayoutPanelTransakcije.TabIndex = 4;
            // 
            // buttonTransakcije
            // 
            buttonTransakcije.BackColor = Color.FromArgb(32, 33, 36);
            buttonTransakcije.FlatStyle = FlatStyle.Flat;
            buttonTransakcije.ForeColor = SystemColors.ButtonFace;
            buttonTransakcije.Location = new Point(3, 3);
            buttonTransakcije.Name = "buttonTransakcije";
            buttonTransakcije.Size = new Size(195, 45);
            buttonTransakcije.TabIndex = 3;
            buttonTransakcije.Text = "Transakcije";
            buttonTransakcije.UseVisualStyleBackColor = false;
            buttonTransakcije.Click += buttonTransakcije_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(32, 33, 36);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(3, 54);
            button4.Name = "button4";
            button4.Size = new Size(195, 45);
            button4.TabIndex = 5;
            button4.Text = "Pregled transakcija";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(32, 33, 36);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(3, 105);
            button3.Name = "button3";
            button3.Size = new Size(195, 45);
            button3.TabIndex = 4;
            button3.Text = " Novo placanje";
            button3.UseVisualStyleBackColor = false;
            // 
            // buttonNalog
            // 
            buttonNalog.BackColor = Color.FromArgb(32, 33, 36);
            buttonNalog.FlatStyle = FlatStyle.Flat;
            buttonNalog.ForeColor = SystemColors.Control;
            buttonNalog.Location = new Point(3, 104);
            buttonNalog.Name = "buttonNalog";
            buttonNalog.Size = new Size(195, 42);
            buttonNalog.TabIndex = 5;
            buttonNalog.Text = "Nalog";
            buttonNalog.UseVisualStyleBackColor = false;
            buttonNalog.Click += buttonNalog_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(32, 33, 36);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(3, 152);
            button1.Name = "button1";
            button1.Size = new Size(195, 42);
            button1.TabIndex = 6;
            button1.Text = "Računi";
            button1.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 561);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanelTransakcije.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxClose;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonPocetna;
        private Button buttonTransakcije;
        private FlowLayoutPanel flowLayoutPanelTransakcije;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer menuTransition;
        private Button buttonNalog;
        private Button button1;
    }
}