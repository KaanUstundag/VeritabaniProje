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
                MessageBox.Show("Giriþ baþarýlý!");

                switch (kullaniciBilgileri.Rol)
                {
                    case "Asistan":
                        AsistanEkrani form3 = new AsistanEkrani();
                        form3.AsistanId = kullaniciBilgileri.Id;
                        form3.Show();
                        MessageBox.Show("Asistan");
                        this.Hide();
                        break;
                    case "Takým Lideri":
                        MessageBox.Show("Takým Lideri");
                        this.Hide();
                        break;
                    case "Grup Yöneticisi":
                        MessageBox.Show("Grup Yöneticisi");
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Geçersiz kullanýcý rolü!");
                        return;
                }
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre!");
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
                            kullaniciBilgileri = new KullaniciBilgileri(); // Önce nesneyi oluþturun
                            kullaniciBilgileri.Rol = reader["KullaniciRolü"].ToString();

                            // Rol'e göre ID'yi atayýn
                            if (kullaniciBilgileri.Rol == "Asistan")
                            {
                                kullaniciBilgileri.Id = Convert.ToInt32(reader["Asistan_Id"]);
                            }
                            else if (kullaniciBilgileri.Rol == "Takým Lideri")
                            {
                                kullaniciBilgileri.Id = Convert.ToInt32(reader["TakimLideriId"]);
                            }
                            else if (kullaniciBilgileri.Rol == "Grup Yöneticisi")
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