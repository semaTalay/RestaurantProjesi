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
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Ad = txtMenuAd.Text;
            menu.Fiyat = (int)nmdMenuFiyat.Value;
            BurgerRestaurant.Menuler.Add(menu);
            Helper.Temizle(this.Controls);
        }
    }
}
