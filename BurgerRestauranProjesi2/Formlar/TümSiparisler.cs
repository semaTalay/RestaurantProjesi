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
    public partial class TümSiparisler : Form
    {
        public TümSiparisler()
        {
            InitializeComponent();
        }

        private void TümSiparisler_Load(object sender, EventArgs e)
        {
            double ciro = 0;
            int toplamSiparis = 0;
            double ekstraMalzemeGeliri = 0;
            int satilanUrunAdedi = 0;
            lstAlinanTumSiparisler.Items.Clear();
            foreach (Siparis siparis in BurgerRestaurant.Siparisler)
            {

                lstAlinanTumSiparisler.Items.Add(siparis);
                ciro += (siparis.ToplamFiyat * siparis.Adet);

                ekstraMalzemeGeliri += siparis.EkstraMalzemeGeliri();
                satilanUrunAdedi += siparis.Adet;
                satilanUrunAdedi += siparis.EkstraMalzemeler.Count;

            }

            toplamSiparis = BurgerRestaurant.Siparisler.Count;

            lblCiro.Text = ciro.ToString();
            lblToplamSiparis.Text = toplamSiparis.ToString();
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString();
            lblSatılanUrunAdedi.Text = satilanUrunAdedi.ToString();
        }
    }
}
