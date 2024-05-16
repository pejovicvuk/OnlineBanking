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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineBanking
{
    public partial class NovoPlacanje : Form
    {
        public NovoPlacanje()
        {
            InitializeComponent();
        }

        private void NovoPlacanje_Load(object sender, EventArgs e)
        {
            int KorisnikID = LoginInfo.KorisnikID;
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            comboBoxPlacanje.Text = "Odaberi racun";
            string queryRacuni = $"SELECT Broj_Racuna FROM Racun WHERE Id_Korisnik = @KorisnikID";
            SqlCommand cmdRacuni = new SqlCommand(queryRacuni, conn);
            cmdRacuni.Parameters.AddWithValue("@KorisnikID", KorisnikID);
            SqlDataReader reader = cmdRacuni.ExecuteReader();
            while (reader.Read())
            {
                string brojRacuna = reader.GetString(reader.GetOrdinal("Broj_Racuna"));
                comboBoxPlacanje.Items.Add(brojRacuna);
            }
            conn.Close();
        }

        private void buttonUplati_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = Konekcija.Connect())
            {
                conn.Open();

                string query = "SELECT Stanje FROM Racun where Broj_Racuna = @BrojRacuna";
                using (SqlCommand proveraCmd = new SqlCommand(query, conn))
                {
                    proveraCmd.Parameters.AddWithValue("@BrojRacuna", comboBoxPlacanje.SelectedItem.ToString());
                    decimal stanjeRacun = Convert.ToDecimal(proveraCmd.ExecuteScalar());

                    if(stanjeRacun < Convert.ToDecimal(textBoxPlacanjeSuma.Text))
                    {
                        MessageBox.Show("Nemate dovoljno para na racunu");
                        return;
                    }
                }
                
                if (comboBoxPlacanje.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Odaberi/Napravi racun");
                    return;
                }

                string brojRacunaPlatioc = comboBoxPlacanje.SelectedItem.ToString();
                string brojRacunaPrimaoc = textBoxPrimaoc.Text;
                string oduzmiQuery = "UPDATE Racun SET Stanje = Stanje - @TransakcijaSuma WHERE Broj_Racuna = @BrojRacunaPlatioc";
                string dodajQuery = "UPDATE Racun SET Stanje = Stanje + @TransakcijaSuma WHERE Broj_Racuna = @BrojRacunaPrimaoc";

                using (SqlCommand platiocCmd = new SqlCommand(oduzmiQuery, conn))
                {
                    platiocCmd.Parameters.AddWithValue("@TransakcijaSuma", Convert.ToDecimal(textBoxPlacanjeSuma.Text));
                    platiocCmd.Parameters.AddWithValue("@BrojRacunaPlatioc", brojRacunaPlatioc);
                    platiocCmd.ExecuteNonQuery();
                }
                using (SqlCommand primaocCmd = new SqlCommand(dodajQuery, conn))
                {
                    primaocCmd.Parameters.AddWithValue("@TransakcijaSuma", Convert.ToDecimal(textBoxPlacanjeSuma.Text));
                    primaocCmd.Parameters.AddWithValue("@BrojRacunaPrimaoc", brojRacunaPrimaoc);
                    primaocCmd.ExecuteNonQuery();
                }

                using (SqlCommand cmdInsert = new SqlCommand("Transakcija_Insert", conn))
                {
                    cmdInsert.CommandType = CommandType.StoredProcedure;

                    cmdInsert.Parameters.AddWithValue("@Iznos", Convert.ToDecimal(textBoxPlacanjeSuma.Text));
                    cmdInsert.Parameters.AddWithValue("@broj_platioca", brojRacunaPlatioc);
                    cmdInsert.Parameters.AddWithValue("@broj_primaoca", brojRacunaPrimaoc);
                    cmdInsert.Parameters.AddWithValue("@Id_Tip_Transakcije", 2);
                    cmdInsert.ExecuteNonQuery();
                }
            }
        }
    }
}
