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
    public partial class Racuni : Form
    {
        public Racuni()
        {
            InitializeComponent();
        }

        private void RacuniPokazi()
        {
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            string query = $"SELECT Broj_Racuna, Stanje FROM Racun WHERE Id_Korisnik = {KorisnikID}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            adapter.Fill(dtbl);
            dataGridViewRacuni.DataSource = dtbl;
            conn.Close();
        }

        private void Racuni_Load(object sender, EventArgs e)
        {
            RacuniPokazi();
        }

        private void buttonKreirajRacun_Click(object sender, EventArgs e)
        {
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            string query = $"Racun_Insert {KorisnikID}";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            RacuniPokazi();
            conn.Close();
        }
    }
}
