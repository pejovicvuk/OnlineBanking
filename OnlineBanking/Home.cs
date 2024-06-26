﻿using System;
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
        Racuni racuni;
        NovoPlacanje placanje;
        PregledTransakcija pregled;
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
            nalog?.Hide();
            racuni?.Hide();
            placanje?.Hide();
            pregled?.Hide();
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
            pocetna?.Hide();
            racuni?.Hide();
            placanje?.Hide();
            pregled?.Hide();
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

        private void buttonRacuni_Click(object sender, EventArgs e)
        {
            pocetna?.Hide();
            nalog?.Hide();
            placanje?.Hide();
            pregled?.Hide();
            if (racuni == null || !racuni.Visible)
            {
                racuni = new Racuni();
                racuni.MdiParent = this;
                racuni.Dock = DockStyle.Fill;
                racuni.Show();
            }
            else
            {
                racuni.Hide();
            }
        }

        private void buttonNovoPlacanje_Click(object sender, EventArgs e)
        {
            pocetna?.Hide();
            nalog?.Hide();
            racuni?.Hide();
            pregled?.Hide();
            if (placanje == null || !placanje.Visible)
            {
                placanje = new NovoPlacanje();
                placanje.MdiParent = this;
                placanje.Dock = DockStyle.Fill;
                placanje.Show();
            }
            else
            {
                placanje.Hide();
            }
        }

        private void buttonPregled_Click(object sender, EventArgs e)
        {
            pocetna?.Hide();
            nalog?.Hide();
            racuni?.Hide();
            placanje?.Hide();

            if (pregled == null || !pregled.Visible)
            {
                pregled = new PregledTransakcija();
                pregled.MdiParent = this;
                pregled.Dock = DockStyle.Fill;
                pregled.Show();
            }
            else
            {
                pregled.Hide();
            }
        }
    }
}
