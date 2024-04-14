using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineBanking
{
    internal class Konekcija
    {
        static public SqlConnection Connect()
        {
            string cs;
            cs = ConfigurationManager.ConnectionStrings["csconfig"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            return connection;
        }
    }
}
