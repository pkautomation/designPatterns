using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Factory
{
    internal class WaterPistol : Pistol
    {
        public override void Shoot()
        {
            Console.WriteLine("Shooting stream of water! Thats kids pistol");
        }
    }
}
