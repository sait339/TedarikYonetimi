using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TedarikYonetimi
{
    public class SqlBaglanti
    {
        public static string SqlConnection = ConfigurationManager.ConnectionStrings["EmperoSqlConnection"].ConnectionString;
        public static SqlConnection baglanti = new SqlConnection(SqlConnection);
        //public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JRCNLH\\SQLEXPRESS;Initial Catalog=TEDARIKYONETIM;Integrated Security=True;");
    }
}
