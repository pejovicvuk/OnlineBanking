using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking
{
    public partial class Nalog : Form
    {
        Register register = new Register();
        Home home = new Home();

        public Nalog()
        {
            InitializeComponent();
        }

        private object IzvuciPodatak(string podatak)
        {
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            string query = $"SELECT {podatak} FROM Korisnik WHERE Id_Korisnik = @KorisnikID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@KorisnikID", KorisnikID);
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }

        private void Nalog_Load(object sender, EventArgs e)
        {
            textBoxNalogIme.Text = IzvuciPodatak("Ime").ToString();
            textBoxNalogPrezime.Text = IzvuciPodatak("Prezime").ToString();
            textBoxNalogEmail.Text = IzvuciPodatak("Email").ToString();
            textBoxNalogSifra.Text = IzvuciPodatak("Sifra").ToString();
        }

        private void checkBoxViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxViewPass.Checked == true)
            {
                textBoxNalogSifra.PasswordChar = '\0';
            }
            else
            {
                textBoxNalogSifra.PasswordChar = '*';
            }
        }

        private void buttonNalogLogout_Click(object sender, EventArgs e)
        {
            Form home= this.MdiParent;
            home.Close();
            LoginInfo.KorisnikID = 0;
            register.ShowDialog();
        }
    }
}
