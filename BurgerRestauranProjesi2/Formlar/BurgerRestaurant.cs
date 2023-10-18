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
    public partial class BurgerRestaurant : Form
    {
        public BurgerRestaurant()
        {
            InitializeComponent();
            Siparisler = new List<Siparis>();
        }
        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{Ad="Tavuk Dürüm",Fiyat=250},
            new Menu{Ad="Zurna Dürüm",Fiyat=300}

        };

        public static List<EkstraMalzeme> EkstraMalzemeler = new List<EkstraMalzeme>()
        {
            new EkstraMalzeme{Ad="Ketçap",Fiyat=5},
            new EkstraMalzeme{Ad="Mayonez",Fiyat=10}
        };


        public static List<Siparis> Siparisler;
        private void BurgerRestaurant_Load(object sender, EventArgs e)
        {
            SiparisOlusturEkraniGetir();
        }
        private void SiparisOlusturEkraniGetir()
        {
            FormlarıKapat();
            SiparisOluştur siparisOlusturEkrani = new SiparisOluştur();
            siparisOlusturEkrani.MdiParent = this;
            siparisOlusturEkrani.Dock = DockStyle.Fill;
            this.Width = siparisOlusturEkrani.Width + 30;
            this.Height = siparisOlusturEkrani.Height + 60;
            siparisOlusturEkrani.Show();

        }

        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisOlusturEkraniGetir();

        }

        private void FormlarıKapat()
        {
            Form[] forms = this.MdiChildren;
            foreach (Form form in forms)
            {
                form.Close();
            }



        }

        private void tümSiparişlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TümSiparisler tumSiparislerEkrani = new TümSiparisler();
            tumSiparislerEkrani.MdiParent = this;
            tumSiparislerEkrani.Dock = DockStyle.Fill;
            this.Width = tumSiparislerEkrani.Width + 30;
            this.Height = tumSiparislerEkrani.Height + 60;
            tumSiparislerEkrani.Show();
        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEkle menuEkleEkrani = new MenuEkle();
            menuEkleEkrani.MdiParent = this;
            menuEkleEkrani.Dock = DockStyle.Fill;
            this.Width = menuEkleEkrani.Width + 30;
            this.Height = menuEkleEkrani.Height + 60;
            menuEkleEkrani.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMalzemeEkle ekstraMalzemeEkleEkrani = new EkstraMalzemeEkle();
            ekstraMalzemeEkleEkrani.MdiParent = this;
            ekstraMalzemeEkleEkrani.Dock = DockStyle.Fill;
            this.Width = ekstraMalzemeEkleEkrani.Width + 30;
            this.Height = ekstraMalzemeEkleEkrani.Height + 60;
            ekstraMalzemeEkleEkrani.Show();
        }
    }
}
