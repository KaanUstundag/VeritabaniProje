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
    public partial class KayitEkrani : Form
    {
        string connectionString = "Data Source=DESKTOP-SI71SRK;Initial Catalog=VYTS;Integrated Security=True;TrustServerCertificate=True";

        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string rol = comboBox1.SelectedItem?.ToString();
            string yoneticiID = textBox3.Text;
            int sicilNo = 0;

            if (string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("Lütfen bir rol seçin.");
                return;
            }

            string rastgeleSifre = SifreOlustur().ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "";

                if (rol == "Asistan")
                {
                    if (string.IsNullOrEmpty(yoneticiID))
                    {
                        MessageBox.Show("Lütfen Takım Lideri ID'sini girin.");
                        return;
                    }

                    sicilNo = SonrakiSicilNo(conn);
                    query = "INSERT INTO Asistanlar (Ad, Soyad, TakimLideriID, Sifre, Sicil_Numarasi) VALUES (@ad, @soyad, @yoneticiID, @sifre, @sicilNo)";
                }
                else if (rol == "Grup Yöneticisi")
                {
                    query = "INSERT INTO GrupYoneticileri (Ad, Soyad, Sifre) VALUES (@ad, @soyad, @sifre)";
                }
                else if (rol == "Takım Lideri")
                {
                    if (string.IsNullOrEmpty(yoneticiID))
                    {
                        MessageBox.Show("Lütfen Grup Yöneticisi ID'sini girin.");
                        return;
                    }

                    query = "INSERT INTO TakimLiderleri (Ad, Soyad, GrupYoneticisiID, Sifre) VALUES (@ad, @soyad, @yoneticiID, @sifre)";
                }
                else
                {
                    MessageBox.Show("Geçersiz rol seçildi.");
                    return;
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@sifre", rastgeleSifre);

                    if (rol == "Asistan" || rol == "Takım Lideri")
                    {
                        cmd.Parameters.AddWithValue("@yoneticiID", yoneticiID);
                    }
                    if (rol == "Asistan")
                    {
                        cmd.Parameters.AddWithValue("@sicilNo", sicilNo);
                    }

                    try
                    {
                        cmd.ExecuteNonQuery();

                        if (rol == "Asistan")
                        {
                            MessageBox.Show($"{rol} başarıyla kaydedildi. Şifre: {rastgeleSifre}, Sicil Numarası: {sicilNo}");
                        }
                        else
                        {
                            MessageBox.Show($"{rol} başarıyla kaydedildi. Şifre: {rastgeleSifre}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veri kaydedilirken bir hata oluştu: {ex.Message}");
                    }
                }
            }
        }
        private int SifreOlustur()
        {
            Random rastgele = new Random();
            int sifre = rastgele.Next(100, 1000);
            return sifre;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = comboBox1.SelectedItem.ToString();
            if (selectedRole == "Asistan" || selectedRole == "Takım Lideri")
            {
                label4.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox3.Visible = false;
            }
        }
        private int SonrakiSicilNo(SqlConnection conn)
        {
            string query = $@"
        SELECT TOP 1 Sicil_Numarasi + 1 
        FROM Asistanlar
        WHERE Sicil_Numarasi + 1 NOT IN (SELECT Sicil_Numarasi FROM Asistanlar)
        ORDER BY Sicil_Numarasi";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}