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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string musteriAdi = textBox1.Text;
            string musteriSoyadi = textBox2.Text;
            string gorusmeKonusu = comboBox1.Text;
            string gorusmeTarihi = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string gorusmeBasSaati = dateTimePicker2.Value.ToString("HH:mm:ss");
            string gorusmeBitSaati = dateTimePicker3.Value.ToString("HH:mm:ss");
            string gorusmeDurumu = comboBox2.Text;

            SqlConnection baglanti = new SqlConnection("Data Source=MSINOTEBOOK;Initial Catalog=VeritabaniProje;Integrated Security=True");
            SqlCommand komut = new SqlCommand("insert into gorusme(MusteriAdi,MusteriSoyadi,GorusmeKonusu,GorusmeTarihi,gorusmeBaslangicSaati,gorusmeBitisSaati,GorusmeDurumu) values('" + musteriAdi + "','" + musteriSoyadi + "','" + gorusmeKonusu + "','" + gorusmeTarihi + "','" + gorusmeBasSaati + "','" + gorusmeBitSaati + "','" + gorusmeDurumu + "')", baglanti);
        }
    }
}
