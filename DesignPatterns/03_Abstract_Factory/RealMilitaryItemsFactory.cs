using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Factory
{
    internal class RealMilitaryItemsFactory : MilitaryItemsFactory
    {
        public Medikit CreateMedikit()
        {
            return new AdultMedikit();
        }

        public Pistol CreatePistol()
        {
            return new ClassicPistol();
        }
    }
}
