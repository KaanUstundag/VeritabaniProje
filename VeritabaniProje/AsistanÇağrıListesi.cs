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
    public partial class AsistanÇağrıListesi : Form
    {
        private int asistanId;
        private SqlConnection connection;

        public AsistanÇağrıListesi()
        {
            InitializeComponent();
        }

        public AsistanÇağrıListesi(int asistanId)
        {
            this.asistanId = asistanId;
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-SI71SRK;Initial Catalog=VYTS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"); 

            LoadCalls();
        }

        private void LoadCalls()
        {
 
            try
            {
                connection.Open();
                string query = "SELECT * FROM GorusmeDetay WHERE AsistanId = @asistanId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@asistanId", asistanId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsistanÇağrıekleme form5 = new AsistanÇağrıekleme(asistanId);
            form5.Show();
            this.Hide();
        }
    }
}