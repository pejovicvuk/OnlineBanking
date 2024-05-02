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
    public partial class PregledTransakcija : Form
    {
        public PregledTransakcija()
        {
            InitializeComponent();
        }

        private void PregledTransakcija_Load(object sender, EventArgs e)
        {
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();

            string queryRacun = "SELECT Broj_Racuna FROM Racun WHERE ID_Korisnik = @KorisnikID";
            SqlCommand cmd = new SqlCommand(queryRacun, conn);
            cmd.Parameters.AddWithValue("@KorisnikID", KorisnikID);
            string brojRacuna = cmd.ExecuteScalar()?.ToString();

            if (!string.IsNullOrEmpty(brojRacuna))
            {
                string queryTabela = "SELECT * FROM Transakcije WHERE Broj_Racuna_Primaoca = @BrojRacuna OR Broj_Racuna_Platioca = @BrojRacuna";
                SqlCommand cmdTabela = new SqlCommand(queryTabela, conn);
                cmdTabela.Parameters.AddWithValue("@BrojRacuna", brojRacuna);
                SqlDataAdapter adapter = new SqlDataAdapter(cmdTabela);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);
                dataGridViewTransakcije.DataSource = dtbl;
            }
            else
            {
                MessageBox.Show("Korisnik nema racun");
            }

            conn.Close();
        }

    }
}
