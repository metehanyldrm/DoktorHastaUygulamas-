using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.SQLServerBilgileri;
using static WindowsFormsApp1.GirisYapanHasta;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class HastaPaneli : Form
    {
        public string id;
        public HastaPaneli()
        {
            InitializeComponent();
            id = hastaId;
            hastaIdLabel.Text = id;
        }

        private void biglileriGuncelleButonu_Click(object sender, EventArgs e)
        {
           string hastaBilgileriniGuncellemeKomutu = "UPDATE Hasta " +
                "SET Nabız = @nabız," +
                "BüyükTansiyon = @buyukTansiyon," +
                "KüçükTansiyon = @kucukTansiyon," +
                "VücutSıcaklığı = @vucutSıcaklıgı " +
                "WHERE Id = @id";

            SqlCommand sqlHastaBilgileriniGuncellemeKomutu = new SqlCommand(hastaBilgileriniGuncellemeKomutu, sqlServerBaglantısı);

            sqlHastaBilgileriniGuncellemeKomutu.Parameters.AddWithValue("@nabız", nabız.Text);
            sqlHastaBilgileriniGuncellemeKomutu.Parameters.AddWithValue("@buyukTansiyon", buyukTansiyon.Text);
            sqlHastaBilgileriniGuncellemeKomutu.Parameters.AddWithValue("@kucukTansiyon", kucukTansiyon.Text);
            sqlHastaBilgileriniGuncellemeKomutu.Parameters.AddWithValue("@vucutSıcaklıgı", vucutSıcaklıgı.Text);
            sqlHastaBilgileriniGuncellemeKomutu.Parameters.AddWithValue("@id", id);

            sqlHastaBilgileriniGuncellemeKomutu.ExecuteNonQuery();

            MessageBox.Show("Hasta bilgileri başarıyla güncellendi.");
        }
    }
}
