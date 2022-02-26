using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Factory
{
    internal class KidsMilitaryItemsFactory : MilitaryItemsFactory
    {
        public  Medikit CreateMedikit()
        {
            return new KidsMedikit();
        }

        public Pistol CreatePistol()
        {
            return new WaterPistol();
        }
    }
}
