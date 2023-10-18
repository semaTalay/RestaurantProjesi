using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerRestauranProjesi2
{
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkstraEkle_Click(object sender, EventArgs e)
        {
            EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
            ekstraMalzeme.Ad = txtEkstraAd.Text;
            ekstraMalzeme.Fiyat = (int)nmdEkstraAd.Value;

            BurgerRestaurant.EkstraMalzemeler.Add(ekstraMalzeme);
            Helper.Temizle(this.Controls);
        }
    }
}
