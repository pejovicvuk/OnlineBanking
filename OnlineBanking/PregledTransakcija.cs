using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
            List<string> userAccounts = new List<string>();

            using (SqlConnection conn = Konekcija.Connect())
            {
                conn.Open();

                string queryRacun = "SELECT Broj_Racuna FROM Racun WHERE ID_Korisnik = @KorisnikID";
                using (SqlCommand cmd = new SqlCommand(queryRacun, conn))
                {
                    cmd.Parameters.AddWithValue("@KorisnikID", KorisnikID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string brojRacuna = reader.GetString(0);
                            userAccounts.Add(brojRacuna);
                        }
                    }
                }

                DataTable dtbl = new DataTable();
                dtbl.Columns.Add("Iznos");
                dtbl.Columns.Add("Vreme");
                dtbl.Columns.Add("Broj_Racuna_Primaoca");
                dtbl.Columns.Add("Broj_Racuna_Platioca");

                foreach (string brojRacuna in userAccounts)
                {
                    string queryTabela = "SELECT Iznos, Vreme, Broj_Racuna_Primaoca, Broj_Racuna_Platioca FROM Transakcije WHERE Broj_Racuna_Primaoca = @BrojRacuna OR Broj_Racuna_Platioca = @BrojRacuna";
                    using (SqlCommand cmdTabela = new SqlCommand(queryTabela, conn))
                    {
                        cmdTabela.Parameters.AddWithValue("@BrojRacuna", brojRacuna);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmdTabela))
                        {
                            DataTable tempTable = new DataTable();
                            adapter.Fill(tempTable);

                            foreach (DataRow row in tempTable.Rows)
                            {
                                dtbl.ImportRow(row);
                            }
                        }
                    }
                }

                dataGridViewTransakcije.DataSource = dtbl;
            }
        }

    }
}
