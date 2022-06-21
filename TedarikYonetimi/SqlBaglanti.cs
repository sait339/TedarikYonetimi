using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedarikYonetimi
{
    public class SqlBaglanti
    {
        public static SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-3JRCNLH\\SQLEXPRESS;Initial Catalog=TEDARIKYONETIM;Integrated Security=True;");
    }
}
