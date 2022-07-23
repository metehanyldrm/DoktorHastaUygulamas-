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
using static WindowsFormsApp1.GirisYapanHasta;

namespace WindowsFormsApp1
{
    public partial class GirisYapFormu : Form
    {
        private void veriTabanınıOlustur()
        {
            try
            {
                // Veri tabanında DoktorHasta veri tabanının olup olmadığını kontrol ediyoruz. Eğer o isimde bir veri tabanı yoksa bu veri tabanınını
                // SQL Server a ekliyoruz. Eğer o isimde bir veri tabanı varsa hiçbir işlem yapmıyoruz.
                string veriTabanınıOlusturmaKomutu = "IF NOT EXISTS(SELECT name FROM master.dbo.sysdatabases WHERE name = N'DoktorHasta')" +
                "CREATE DATABASE DoktorHasta";

                // Bu komut yazılmazsa aşağıdaki komutlar(CREATE TABLE Doktor ve CREATE TABLE Hasta) çalıştırılamaz.
                string veriTabanınıKullanmaKomutu = "USE DoktorHasta";

                // Veri tabanında Doktor isimli tablonun olup olmadığını kontrol ediyoruz. Eğer o isimde bir tablo yoksa bu tabloyu
                // SQL Server a ekliyoruz. Eğer o isimde bir tablo varsa hiçbir işlem yapmıyoruz.
                string doktorTablosunuOlusturmaKomutu = "IF NOT EXISTS(SELECT name FROM sys.sysobjects WHERE Name = N'Doktor')" + 
                "CREATE TABLE Doktor(" +
                "Id CHAR(7) NOT NULL," +
                "Sifre VARCHAR(30) NOT NULL," +
                "PRIMARY KEY(Id)" +
                ")";

                // Veri tabanında Hasta isimli tablonun olup olmadığını kontrol ediyoruz. Eğer o isimde bir tablo yoksa bu tabloyu
                // SQL Server a ekliyoruz. Eğer o isimde bir tablo varsa hiçbir işlem yapmıyoruz.
                string hastaTablosunuOlusturmaKomutu = "IF NOT EXISTS(SELECT name FROM sys.sysobjects WHERE Name = N'Hasta')" +
                "CREATE TABLE Hasta(" +
                "Id char(7) NOT NULL," +
                "Sifre varchar(30) NOT NULL," +
                "Nabız DECIMAL(4, 1)," +
                "BüyükTansiyon DECIMAL(4, 1)," +
                "KüçükTansiyon DECIMAL(4, 1)," +
                "VücutSıcaklığı DECIMAL(4, 1)," +
                "PRIMARY KEY(Id)" +
                ")";

                // Uygulama her seferinde yeniden başlatıldığında eğer DoktorHasta adında bir veri tabanı SQL Server da bulunuyorsa
                // o veri tabanı yeniden oluşturulmaz, DoktorHasta veri tabanındaki bilgiler olduğu gibi kalır, bilgiler silinmez.
                // Fakat DoktorHasta adında bir veri tabanı SQL Server da bulunmuyorsa o zaman yeni veri tabanı oluşturulur.
                SqlCommand sqlVeriTabanınıOlusturmaKomutu = new SqlCommand(veriTabanınıOlusturmaKomutu, sqlServerBaglantısı);
          
                SqlCommand sqlVeriTabanınıKullanmaKomutu = new SqlCommand(veriTabanınıKullanmaKomutu, sqlServerBaglantısı);
                SqlCommand sqlDoktorTablosunuOlusturmaKomutu = new SqlCommand(doktorTablosunuOlusturmaKomutu, sqlServerBaglantısı);
                SqlCommand sqlHastaTablosunuOlusturmaKomutu = new SqlCommand(hastaTablosunuOlusturmaKomutu, sqlServerBaglantısı);

                sqlServerBaglantısı.Open();
                sqlVeriTabanınıOlusturmaKomutu.ExecuteNonQuery();
                sqlVeriTabanınıKullanmaKomutu.ExecuteNonQuery();
                sqlDoktorTablosunuOlusturmaKomutu.ExecuteNonQuery();
                sqlHastaTablosunuOlusturmaKomutu.ExecuteNonQuery();

                // Burada sqlServerBaglantısı.Close() u kullanarak veri tabanı bağlantısını kapamadım.
                // Eğer burada veri tabanı bağlantısını kapasaydım diğer yapacağım tüm işlemlerde
                // authentication, kayıt olma vs. sqlServerBaglantısı.Open() ve USE DoktorHasta ve sqlServerBaglantısı.Close()
                // komutlarını her seferinde kullanmam gerekiyordu. Çünkü connection kapandığında SQL Server DoktorHasta veri
                // tabanını tanımaz ve yaptığımız tüm işlemler(insert, delete, update, create vs) işlemleri veri tabanında yapılmaz.
                // Bu yüzden her veri tabanı işlemi yapmamız gerektiğinde USE DoktorHasta komutunu yazmamız gerekir.
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public GirisYapFormu()
        {
            veriTabanınıOlustur();
            InitializeComponent();
            sifre.UseSystemPasswordChar = true;
        }

        private void girisYapButonu_Click(object sender, EventArgs e)
        {
            if(doktorMu.Checked) {
                try
                {
                    string doktorKontrolKomutu = "SELECT COUNT(*) FROM Doktor WHERE Id = @id AND Sifre = @sifre";
                    
                    SqlCommand sqlDoktorKontrolKomutu = new SqlCommand(doktorKontrolKomutu, sqlServerBaglantısı);
                    
                    sqlDoktorKontrolKomutu.Parameters.AddWithValue("@id", id.Text);
                    sqlDoktorKontrolKomutu.Parameters.AddWithValue("@sifre", sifre.Text);

                    int doktorSayısı = (int)sqlDoktorKontrolKomutu.ExecuteScalar();

                    // Doktorun ID ve şifresi doğru ise;
                    if (doktorSayısı == 1)
                    {
                        yeniFormAc(new DoktorPaneli());
                    }

                    // Doktorun bilgileri geçersiz ise;
                    else
                    {
                        MessageBox.Show("Doktor bilgileri geçersiz !!!");
                    }
                }

                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }

            else if(hastaMı.Checked) {
                try
                {
                    string hastaKontrolKomutu = "SELECT COUNT(*) FROM Hasta WHERE Id = @id AND Sifre = @sifre";
                    SqlCommand sqlHastaKontrolKomutu = new SqlCommand(hastaKontrolKomutu, sqlServerBaglantısı);

                    sqlHastaKontrolKomutu.Parameters.AddWithValue("@id", id.Text);
                    sqlHastaKontrolKomutu.Parameters.AddWithValue("@sifre", sifre.Text);

                    int hastaSayısı = (int)sqlHastaKontrolKomutu.ExecuteScalar();

                    // Hastanın ID ve şifresi doğru ise;
                    if (hastaSayısı == 1)
                    {
                        hastaId = id.Text;
                        yeniFormAc(new HastaPaneli());
                    }

                    // Hastanan bilgileri geçersiz ise;
                    else
                    {
                        MessageBox.Show("Hasta bilgileri geçersiz !!!");
                    }

                }
                catch(Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }

            else
            {
                MessageBox.Show("Doktor olarak giriş yapmak istiyorsanız doktoru, hasta olarak giriş yapmak istiyorsanız hastayı seçiniz !!!");
            }
        }

        private void kaydolLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formDegistir(this, new KaydolFormu());
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
