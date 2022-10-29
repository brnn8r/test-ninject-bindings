using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinjectBindings
{
    public class Dagger : IWeapon
    {
        public string Attack()
        {
            return "Dagger hits for 1d4 dmg";
        }
    }
}
