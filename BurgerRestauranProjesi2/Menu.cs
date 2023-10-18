using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerRestauranProjesi2
{
    public class Menu : Urun
    {
        public override string ToString()
        {
            return $"{this.Ad} Menu";
        }
    }
}
