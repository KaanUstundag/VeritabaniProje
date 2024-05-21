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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            SqlConnection baglanti = new SqlConnection("Data Source=MSINOTEBOOK;Initial Catalog=VeritabaniProje;Integrated Security=True");
            private void button1_Click(object sender, EventArgs e)
        {
            int SicilNo = Convert.ToInt32(textBox1.Text);


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from asistan where sicilNo='"+SicilNo+"'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Sicil Numarası");
            }
        }
    }
}
