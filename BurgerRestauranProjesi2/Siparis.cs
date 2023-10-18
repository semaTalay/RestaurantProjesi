using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestauranProjesi2
{
    public class Siparis
    {
        public Siparis()
        {
            EkstraMalzemeler = new List<EkstraMalzeme>();
        }

        public Menu Menu { get; set; }
        public Boy Boy { get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public int Adet { get; set; }

        private double toplamFiyat;
        public double ToplamFiyat {
            get 
            { 
                toplamFiyat = Menu.Fiyat;
                if(this.Boy == Boy.Buyuk)
                {
                    toplamFiyat *= 2;
                }
                else if(this.Boy == Boy.Orta)
                {
                    toplamFiyat *= 1.5;
                }

                ToplamEkstraMalzemeFiyatlari();
                return toplamFiyat;
            } 
        }
        public double EkstraMalzemeGeliri()
        {
            double ekstra = 0;
            foreach (EkstraMalzeme ekstralar in this.EkstraMalzemeler)
            {
                ekstra += ekstralar.Fiyat;
            }
            return ekstra;
        }

        public double ToplamEkstraMalzemeFiyatlari()
        {
            
            foreach (EkstraMalzeme eksMalzeme in this.EkstraMalzemeler)
            {
                toplamFiyat += eksMalzeme.Fiyat;
            }
            return toplamFiyat;
        }

        public override string ToString()
        {
            string ekstraMalzemelerYaz = string.Empty;
            foreach (EkstraMalzeme ekstraMalzeme in EkstraMalzemeler)
            {
                ekstraMalzemelerYaz += ekstraMalzeme.Ad + " ";
            }
            
            string bilgi = $" {this.Adet} adet - {this.Menu} - {this.Boy} boy - {ekstraMalzemelerYaz}. Menü Fiyat : {this.ToplamFiyat * this.Adet}";
            return bilgi;
        }


    }
}
