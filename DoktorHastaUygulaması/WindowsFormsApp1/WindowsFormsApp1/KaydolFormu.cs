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
using static WindowsFormsApp1.FormHandler;

namespace WindowsFormsApp1
{
    public partial class KaydolFormu : Form
    {
        public KaydolFormu()
        {
            InitializeComponent();
            sifre.UseSystemPasswordChar = true;
        }

        private void kaydolButonu_Click(object sender, EventArgs e)
        {
            // Doktor radio butonu seçildiyse Doktor tablosuna ekleme yapılır.
            if (doktorMu.Checked)
            {
                // Id uzunluğu 7 olmak zorundadır.
                if (id.Text.Length != 7)
                {
                    MessageBox.Show("Gecersiz ID!! Id 7 karakterli olmalıdır.");
                    return;
                }

                // Eğer Id uzunluğu 7 olarak girildiyse veri tabanına ekleme yapılır.
                try
                {
                    string kontrolKomutu = "SELECT COUNT(*) FROM Doktor WHERE Id = @id";
                    string eklemeKomutu = "INSERT INTO Doktor VALUES(@id, @sifre)";

                    SqlCommand sqlKontrolKomutu = new SqlCommand(kontrolKomutu, sqlServerBaglantısı);

                    sqlKontrolKomutu.Parameters.AddWithValue("@id", id.Text);
                    
                    int doktorSayısı = (int)sqlKontrolKomutu.ExecuteScalar();

                    // Yazılan ID de kullanıcı veri tabanında var ise;
                    if (doktorSayısı == 1)
                    {
                        MessageBox.Show("Bu doktor zaten veri tabanında kayıtlı, başka bir ID ile kayıt olmayı deneyiniz.");
                    }

                    // Yazılan ID de kullanıcı veri tabanında yok ise;
                    else
                    {
                        SqlCommand sqlEklemeKomutu = new SqlCommand(eklemeKomutu, sqlServerBaglantısı);
                        sqlEklemeKomutu.Parameters.AddWithValue("@id", id.Text);
                        sqlEklemeKomutu.Parameters.AddWithValue("@sifre", sifre.Text);
                        sqlEklemeKomutu.ExecuteNonQuery();

                        MessageBox.Show("Kayıt başarılı :)");

                        formDegistir(this, new GirisYapFormu());
                    }
                }

                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }

            // Hasta radio butonu seçildiyse Hasta tablosuna ekleme yapılır.
            else if (hastaMı.Checked)
            {
                // Id uzunluğu 7 olmak zorundadır.
                if (id.Text.Length != 7)
                {
                    MessageBox.Show("Gecersiz ID!! Id 7 karakterli olmalıdır.");
                    return;
                }

                // Eğer Id uzunluğu 7 olarak girildiyse veri tabanına ekleme yapılır.
                try
                {
                    string kontrolKomutu = "SELECT COUNT(*) FROM Hasta WHERE Id = @id";
                    string eklemeKomutu = "INSERT INTO Hasta(Id, Sifre) VALUES(@id, @sifre)";

                    SqlCommand sqlKontrolKomutu = new SqlCommand(kontrolKomutu, sqlServerBaglantısı);

                    sqlKontrolKomutu.Parameters.AddWithValue("@id", id.Text);

                    int hastaSayısı = (int)sqlKontrolKomutu.ExecuteScalar();

                    // Yazılan ID de kullanıcı veri tabanında var ise;
                    if (hastaSayısı == 1)
                    {
                        MessageBox.Show("Bu hasta zaten veri tabanında kayıtlı, başka bir ID ile kayıt olmayı deneyiniz.");
                    }

                    // Yazılan ID de kullanıcı veri tabanında yok ise;
                    else
                    {
                        SqlCommand sqlEklemeKomutu = new SqlCommand(eklemeKomutu, sqlServerBaglantısı);
                        sqlEklemeKomutu.Parameters.AddWithValue("@id", id.Text);
                        sqlEklemeKomutu.Parameters.AddWithValue("@sifre", sifre.Text);
                        sqlEklemeKomutu.ExecuteNonQuery();

                        MessageBox.Show("Kayıt başarılı :)");

                        formDegistir(this, new GirisYapFormu());
                    }

                }

                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }

            else
            {
                MessageBox.Show("Doktor olarak kayıt yaptırmak istiyorsanız doktoru, hasta olarak kayıt yaptırmak istiyorsanız hastayı seçiniz !!!");
            }
        }

        private void gostersinMi_CheckedChanged(object sender, EventArgs e)
        {
            if(gostersinMi.Checked)
            {
                sifre.UseSystemPasswordChar = false;
            }

            else
            {
                sifre.UseSystemPasswordChar = true;
            }
        }
    }
}
