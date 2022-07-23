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
using static WindowsFormsApp1.SQLServerBilgileri;

namespace WindowsFormsApp1
{
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
            guncelHastaBilgileriniGoster("ACİL");
            guncelHastaBilgileriniGoster("NORMAL");
        }

        private void guncelVerileriGosterButonu_Click(object sender, EventArgs e)
        {
            guncelHastaBilgileriniGoster("ACİL");
            guncelHastaBilgileriniGoster("NORMAL");
        }

        private void guncelHastaBilgileriniGoster(string durum)
        {
            // Normal Nabız Değerleri --> [60, 100]
            // Normal Büyük Tansiyon Değerleri --> [120, 130]
            // Normal Küçük Tansiyon Değerleri --> [70, 90]
            // Normal Vücut Sıcaklığı Değerleri --> [36.1 - 37.2]

            string normalDurum = "Nabız >= 60 AND Nabız <= 100 " +
                "AND BüyükTansiyon >= 120 AND BüyükTansiyon <= 130 " +
                "AND KüçükTansiyon >= 70 AND KüçükTansiyon <= 90 " +
                "AND VücutSıcaklığı >= 36.1 AND VücutSıcaklığı <= 37.2";

            string guncelHastaBilgileriniGosterKomutu = durum.Equals("ACİL") ?
                "SELECT Id FROM Hasta " +
                "WHERE NOT(" + normalDurum + ")":
                "SELECT Id FROM Hasta " +
                "WHERE " + normalDurum;
                

            SqlCommand sqlGuncelHastaBilgileriniGosterKomutu = new SqlCommand(guncelHastaBilgileriniGosterKomutu, sqlServerBaglantısı);
            sqlGuncelHastaBilgileriniGosterKomutu.ExecuteNonQuery();
            SqlDataReader read = sqlGuncelHastaBilgileriniGosterKomutu.ExecuteReader();

            DataSet ds = new DataSet();
            // ds.Tables[0]
            ds.Tables.Add(durum + " Durum Tablosu");

            // Burada veri tabanımızda olmayan yeni bir sütunu dataset e ekliyoruz.
            // Böylece ekranda Acil Durum Bilgisi adında yeni bir sütun oluşacak ve 
            // bu sütunun yanında veri tabanından gelen Id sütunu olacak.
            ds.Tables[0].Columns.Add("Acil Durum Bilgisi", typeof(string));

            ds.Tables[0].Load(read);

            for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                // Yeni eklediğimiz Acil Durum Bilgisi sütunundaki hücreleri dolduruyoruz.
                ds.Tables[0].Rows[i]["Acil Durum Bilgisi"] = durum;
            }

            DataGridView dgw = durum.Equals("ACİL") ?
                acilHastalar :
                normalHastalar;

            dgw.DataSource = ds.Tables[0];
        }

        private void hastaSorgulamaButonu_Click(object sender, EventArgs e)
        {
            string hastayıIdIleBulKomutu = "SELECT Id, Nabız, BüyükTansiyon, KüçükTansiyon, VücutSıcaklığı FROM Hasta WHERE Id = @id";

            SqlCommand sqlHastayıIdIleBulKomutu = new SqlCommand(hastayıIdIleBulKomutu, sqlServerBaglantısı);

            sqlHastayıIdIleBulKomutu.Parameters.AddWithValue("@id", hastaID.Text);
            sqlHastayıIdIleBulKomutu.ExecuteNonQuery();

            SqlDataReader read = sqlHastayıIdIleBulKomutu.ExecuteReader();

            DataSet ds = new DataSet();
            ds.Tables.Add("Aranan Hasta");

            ds.Tables[0].Load(read);

            arananHastaBilgileri.DataSource = ds.Tables[0];
        }
    }
}
