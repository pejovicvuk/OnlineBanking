using System.Data;
using System.Data.SqlClient;

namespace OnlineBanking
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void buttonLoginEmail_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konekcija.Connect();
            string query = "select count(*) from Korisnik where email = @email";
            SqlCommand cmdProvera = new SqlCommand(query, conn);
            cmdProvera.Parameters.AddWithValue("@email", textBoxLoginEmail.Text.Trim());
            
            conn.Open();
            int count = Convert.ToInt32(cmdProvera.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Vec imate nalog po ovom mejlu.");
            }
            else
            {
                SqlCommand cmdInsert = new SqlCommand("Korisnik_Insert", conn);
                cmdInsert.CommandType = CommandType.StoredProcedure;
                cmdInsert.Parameters.Add("@Ime", SqlDbType.VarChar).Value = textBoxLoginIme.Text;
                cmdInsert.Parameters.Add("@Prezime", SqlDbType.VarChar).Value = textBoxLoginPrezime.Text;
                cmdInsert.Parameters.Add("@EMail", SqlDbType.VarChar).Value = textBoxLoginEmail.Text;
                cmdInsert.Parameters.Add("@Sifra", SqlDbType.VarChar).Value = textBoxLoginPass.Text;
                cmdInsert.ExecuteNonQuery();
                Home formahome = new Home();
                formahome.ShowDialog();
            }
            conn.Close();
        }
    }
}
