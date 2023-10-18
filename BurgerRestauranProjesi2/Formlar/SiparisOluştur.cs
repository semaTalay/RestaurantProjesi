using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace BurgerRestauranProjesi2
{
    public partial class SiparisOluştur : Form
    {
        public SiparisOluştur()
        {
            InitializeComponent();
            SonraSiparis = new List<Siparis>();
        }
        List<Siparis> SonraSiparis;
        double toplam = 0;


        private void btnSiparisiEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Menu = (Menu)cboxMenu.SelectedItem;

            foreach (CheckBox cbox in flowLayoutPanel1.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.EkstraMalzemeler.Add((EkstraMalzeme)cbox.Tag);
                }


            }


            if (rdbKucuk.Checked)
            {
                siparis.Boy = Boy.Kucuk;
            }

            else if (rdbOrta.Checked)
            {
                siparis.Boy = Boy.Orta;
            }
            else
            {
                siparis.Boy = Boy.Buyuk;
            }
            siparis.Adet = (int)nmdAdet.Value;
            toplam += (siparis.ToplamFiyat * siparis.Adet);
            lblToplam.Text = toplam.ToString();


            SonraSiparis.Add(siparis);
            lstMusteriSecim.Items.Add(siparis);


            Helper.Temizle(this.Controls);




        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Siparişinizi Onaylıyor Musunuz ? ", "Onaylama Ekranı", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                BurgerRestaurant.Siparisler.AddRange(SonraSiparis);
                lstMusteriSecim.Items.Clear();

            }
            Helper.Temizle(this.Controls);
            lblToplam.Text = "";

        }

        private void SiparisOluştur_Load_1(object sender, EventArgs e)
        {
            foreach (Menu menu in BurgerRestaurant.Menuler)
            {
                cboxMenu.Items.Add(menu);
            }

            foreach (EkstraMalzeme malzeme in BurgerRestaurant.EkstraMalzemeler)
            {


                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = malzeme.Ad, Tag = malzeme });
            }

            cboxMenu.SelectedItem = 0;
            rdbKucuk.Checked = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }
    }
}
