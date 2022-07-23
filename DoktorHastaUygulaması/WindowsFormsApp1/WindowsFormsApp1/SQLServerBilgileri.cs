using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class SQLServerBilgileri
    {
        // Buraya bilgisayarınızdaki SQLServer' ın bağlantı metnini girdiğinizde program veritabanına bağlanır.
        // Her bilgisayar için bu bağlantı metni farklıdır. Programın çalışması için kendi bilgisayarınızdaki
        // SQLServer ın bağlantı metnini giriniz.
        public static string sqlServerBaglantıMetni = "Data Source=TORMUND\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
        public static SqlConnection sqlServerBaglantısı = new SqlConnection(sqlServerBaglantıMetni);
    }
}
