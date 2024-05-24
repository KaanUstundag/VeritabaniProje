using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniProje
{
    public partial class AsistanEkrani : Form
    {
 
        public int AsistanId { get; set; }
        public AsistanEkrani()
        {
            InitializeComponent();
        }

        public AsistanEkrani(int asistanId )
        {
            InitializeComponent();
            this.AsistanId = asistanId;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Asistanİtiraz asistanİtiraz = new Asistanİtiraz(AsistanId);
            asistanİtiraz.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AsistanÇağrıListesi asistanÇağrıListesi = new AsistanÇağrıListesi(AsistanId);
            asistanÇağrıListesi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
