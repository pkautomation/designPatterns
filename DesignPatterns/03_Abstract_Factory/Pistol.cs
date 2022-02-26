using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Factory
{
    internal abstract class Pistol : IWeapon
    {
        public abstract void Shoot();
    }
}
