using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking
{
    public partial class Home : Form
    {
        Pocetna pocetna;
        Nalog nalog;

        public Home()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        bool menuExpand = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                flowLayoutPanelTransakcije.Height += 10;
                if (flowLayoutPanelTransakcije.Height >= 156)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanelTransakcije.Height -= 10;
                if (flowLayoutPanelTransakcije.Height <= 55)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void buttonTransakcije_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void buttonPocetna_Click(object sender, EventArgs e)
        {
            if(nalog !=null)
            {
                nalog.Hide();
            }
            if (pocetna == null || !pocetna.Visible)
            {
                pocetna = new Pocetna();
                pocetna.MdiParent = this;
                pocetna.Dock = DockStyle.Fill;
                pocetna.Show();
            }
            else
            {
                pocetna.Hide();
            }
        }

        private void buttonNalog_Click(object sender, EventArgs e)
        {
            if (pocetna != null)
            {
                pocetna.Hide();
            }
            if (nalog == null || !nalog.Visible)
            {
                nalog = new Nalog();
                nalog.MdiParent = this;
                nalog.Dock = DockStyle.Fill;
                nalog.Show();
            }
            else
            {
                nalog.Hide();
            }
        }
    }
}
