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
using System.Windows.Forms.VisualStyles;

namespace OnlineBanking
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private decimal UkupnoStanje()
        {
            decimal ukupno = 0;
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            string querySum = $"SELECT SUM(Stanje) FROM Racun WHERE Id_Korisnik = @KorisnikID";
            SqlCommand cmdSum = new SqlCommand(querySum, conn);
            cmdSum.Parameters.AddWithValue("@KorisnikID", KorisnikID);
            object result = cmdSum.ExecuteScalar();
            if (result == DBNull.Value)
                ukupno = 0;
            else
                ukupno = Convert.ToDecimal(result);
            return ukupno;
        }
        private void PovecajStanje(decimal koliko)
        {
            SqlConnection conn = Konekcija.Connect();
            conn.Open();

            string brojRacuna = comboBoxBankomat.SelectedItem.ToString();
            string selectQuery = $"SELECT Stanje FROM Racun WHERE Broj_Racuna = @BrojRacuna";
            SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
            selectCmd.Parameters.AddWithValue("@BrojRacuna", brojRacuna);
            decimal currentStanje = Convert.ToDecimal(selectCmd.ExecuteScalar());

            decimal novoStanje = currentStanje + koliko;

            string updateQuery = $"UPDATE Racun SET Stanje = @NovoStanje WHERE Broj_Racuna = @BrojRacuna";
            SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
            updateCmd.Parameters.AddWithValue("@NovoStanje", novoStanje);
            updateCmd.Parameters.AddWithValue("@BrojRacuna", brojRacuna);
            updateCmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            //ukupno stanje sa svih racuna
            
            textBoxStanje.Text = UkupnoStanje().ToString();

            //odabir racuna za slanje para
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            comboBoxBankomat.Text = "Odaberi racun";
            string queryRacuni = $"SELECT Broj_Racuna FROM Racun WHERE Id_Korisnik = @KorisnikID";
            SqlCommand cmdRacuni = new SqlCommand(queryRacuni, conn);
            cmdRacuni.Parameters.AddWithValue("@KorisnikID", KorisnikID);
            SqlDataReader reader = cmdRacuni.ExecuteReader();
            while (reader.Read())
            {
                string brojRacuna = reader.GetString(reader.GetOrdinal("Broj_Racuna"));
                comboBoxBankomat.Items.Add(brojRacuna);
            }
            conn.Close();
        }

        private void KreirajTransakcijuBankomat()
        {
            decimal iznos = Convert.ToDecimal(textBoxKoliko.Text);
            string brojPrimaoca = comboBoxBankomat.SelectedItem.ToString();

            using (SqlConnection conn = Konekcija.Connect())
            {
                conn.Open();
                SqlCommand cmdInsert = new SqlCommand("Transakcija_Insert", conn);
                cmdInsert.CommandType = CommandType.StoredProcedure;

                cmdInsert.Parameters.AddWithValue("@Iznos", iznos);
                cmdInsert.Parameters.AddWithValue("@broj_platioca", "0");
                cmdInsert.Parameters.AddWithValue("@broj_primaoca", brojPrimaoca);
                cmdInsert.Parameters.AddWithValue("@Id_Tip_Transakcije", 1); 

                cmdInsert.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            PovecajStanje(Convert.ToInt32(textBoxKoliko.Text));
            textBoxStanje.Text = UkupnoStanje().ToString();
            KreirajTransakcijuBankomat();
        }
    }
}
