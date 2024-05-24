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

namespace VeritabaniProje
{
    public partial class AsistanÇağrıekleme : Form
    {
        private int asistanId;
        string connectionString = "Data Source=DESKTOP-SI71SRK;Initial Catalog=VYTS;Integrated Security=True;TrustServerCertificate=True";

        public AsistanÇağrıekleme()
        {
            InitializeComponent();
        }

        public AsistanÇağrıekleme(int asistanId)
        {
            InitializeComponent();
            this.asistanId = asistanId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteriAdi = textBox1.Text;
            string musteriSoyadi = textBox2.Text;
            string gorusmeKonusu = comboBox1.Text;
            string gorusmeTarihi = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string gorusmeBasSaati = dateTimePicker2.Value.ToString("HH:mm:ss");
            string gorusmeBitSaati = dateTimePicker3.Value.ToString("HH:mm:ss");
            string durum = comboBox2.Text;
            YeniMusteriVeGorusmeEkle(musteriAdi, musteriSoyadi, asistanId, gorusmeKonusu,
                                   DateTime.Parse(gorusmeTarihi), TimeSpan.Parse(gorusmeBasSaati),
                                   TimeSpan.Parse(gorusmeBitSaati), durum);


            MessageBox.Show("Müşteri ve görüşme başarıyla eklendi.");
            AsistanÇağrıListesi asistanÇağrıListesi = new AsistanÇağrıListesi(asistanId);
            asistanÇağrıListesi.Show();
            this.Hide();
        }

        private int TakimLideriIdBul(int asistanId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                using (SqlCommand cmd = new SqlCommand("SELECT dbo.TakımLideriIdBul(@AsistanId)", conn))
                {
                    cmd.Parameters.AddWithValue("@AsistanId", asistanId);

                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }

            return -1; // Hata durumunda -1 döndür
        }

        public void YeniMusteriVeGorusmeEkle(string ad, string soyad, int asistanId, string gorusmeDetayi, DateTime gorusmeTarihi, TimeSpan baslamaSaati, TimeSpan bitisSaati, string durum)
        {
            int takimLideriId = TakimLideriIdBul(asistanId);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (Ad, Soyad, TakimLideriId) VALUES (@Ad, @Soyad, @TakimLideriId); SELECT SCOPE_IDENTITY();", conn))
                {
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@TakimLideriId", takimLideriId);

                    int musteriId = Convert.ToInt32(cmd.ExecuteScalar());

                    using (SqlCommand cmd2 = new SqlCommand("INSERT INTO GorusmeDetay (AsistanId, MusteriId, GorusmeDetayi, Tarih, BaslamaSaati, BitisSaati, Durum) VALUES (@AsistanId, @MusteriId, @GorusmeDetayi, @GorusmeTarihi, @BaslamaSaati, @BitisSaati, @Durum)", conn))
                    {
                        cmd2.Parameters.AddWithValue("@AsistanId", asistanId);
                        cmd2.Parameters.AddWithValue("@MusteriId", musteriId);
                        cmd2.Parameters.AddWithValue("@GorusmeDetayi", gorusmeDetayi);
                        cmd2.Parameters.AddWithValue("@GorusmeTarihi", gorusmeTarihi);
                        cmd2.Parameters.AddWithValue("@BaslamaSaati", baslamaSaati);
                        cmd2.Parameters.AddWithValue("@BitisSaati", bitisSaati);
                        cmd2.Parameters.AddWithValue("@Durum", durum);

                        cmd2.ExecuteNonQuery();
                       
                    }
                }
            }
        }
    }
}