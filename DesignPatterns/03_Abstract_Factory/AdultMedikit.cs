using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Factory
{
    internal class AdultMedikit : Medikit
    {
        public override void Use()
        {
            Console.WriteLine("Thats real medikit for adults");
        }
    }
}
