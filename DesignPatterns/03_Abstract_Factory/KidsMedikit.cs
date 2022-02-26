using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Abstract_Factory
{
    internal class KidsMedikit : Medikit
    {
        public override void Use()
        {
            Console.WriteLine("This medikit is full of candies... Its probably just for kids");
        }
    }
}
