using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace VeritabaniProje
{
    public partial class GirisEkrani : Form
    {
        string connectionString = "Data Source=DESKTOP-SI71SRK;Initial Catalog=VYTS;Integrated Security=True;TrustServerCertificate=True";
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;


            KullaniciBilgileri kullaniciBilgileri = KullaniciGirisKontrol(kullaniciAdi, sifre);

            if (kullaniciBilgileri != null)
            {
                MessageBox.Show("Giri� ba�ar�l�!");

                switch (kullaniciBilgileri.Rol)
                {
                    case "Asistan":
                        AsistanEkrani form3 = new AsistanEkrani();
                        form3.AsistanId = kullaniciBilgileri.Id;
                        form3.Show();
                        MessageBox.Show("Asistan");
                        this.Hide();
                        break;
                    case "Tak�m Lideri":
                        MessageBox.Show("Tak�m Lideri");
                        this.Hide();
                        break;
                    case "Grup Y�neticisi":
                        MessageBox.Show("Grup Y�neticisi");
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Ge�ersiz kullan�c� rol�!");
                        return;
                }
            }
            else
            {
                MessageBox.Show("Hatal� kullan�c� ad� veya �ifre!");
            }
        }


        private KullaniciBilgileri KullaniciGirisKontrol(string kullaniciAdi, string sifre)
        {
            KullaniciBilgileri kullaniciBilgileri = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("KullaniciGirisKontrol", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            kullaniciBilgileri = new KullaniciBilgileri(); // �nce nesneyi olu�turun
                            kullaniciBilgileri.Rol = reader["KullaniciRol�"].ToString();

                            // Rol'e g�re ID'yi atay�n
                            if (kullaniciBilgileri.Rol == "Asistan")
                            {
                                kullaniciBilgileri.Id = Convert.ToInt32(reader["Asistan_Id"]);
                            }
                            else if (kullaniciBilgileri.Rol == "Tak�m Lideri")
                            {
                                kullaniciBilgileri.Id = Convert.ToInt32(reader["TakimLideriId"]);
                            }
                            else if (kullaniciBilgileri.Rol == "Grup Y�neticisi")
                            {
                                kullaniciBilgileri.Id = Convert.ToInt32(reader["GrupYoneticisiId"]);
                            }

                        }
                    }
                }

            }



            return kullaniciBilgileri;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KayitEkrani form2 = new KayitEkrani();
            form2.Show();
            this.Hide();
        }



        public class KullaniciBilgileri
        {
            public int Id { get; set; }
            public string Rol { get; set; }
        }
    }
}