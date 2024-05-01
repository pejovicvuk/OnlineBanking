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

        private void buttonRegisterEmail_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konekcija.Connect();
            string query = "select count(*) from Korisnik where email = @email";
            SqlCommand cmdProvera = new SqlCommand(query, conn);
            cmdProvera.Parameters.AddWithValue("@email", textBoxRegisterEmail.Text.Trim());

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
                cmdInsert.Parameters.Add("@Ime", SqlDbType.VarChar).Value = textBoxRegisterIme.Text;
                cmdInsert.Parameters.Add("@Prezime", SqlDbType.VarChar).Value = textBoxRegisterPrezime.Text;
                cmdInsert.Parameters.Add("@EMail", SqlDbType.VarChar).Value = textBoxRegisterEmail.Text;
                cmdInsert.Parameters.Add("@Sifra", SqlDbType.VarChar).Value = textBoxRegisterPass.Text;
                cmdInsert.ExecuteNonQuery();
                Home formahome = new Home();
                formahome.ShowDialog();
            }
            conn.Close();
        }
    }
}
