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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konekcija.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Id_Korisnik FROM Korisnik WHERE Email = @Email and Sifra = @Password", conn);         
            cmd.Parameters.AddWithValue("@Email", textBoxLoginEmail.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxLoginPass.Text);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                LoginInfo.KorisnikID = Convert.ToInt16(result);
                Home formahome = new Home();
                this.Hide();
                formahome.ShowDialog();

            }
            else
            {
                MessageBox.Show("Korisnik ne postoji/Sifra nije tacna.");
            }
        }
    }
}
