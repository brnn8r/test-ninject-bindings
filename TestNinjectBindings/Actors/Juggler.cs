using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinjectBindings.Weapons;

namespace TestNinjectBindings.Actors
{
    public class Juggler : IActor
    {
        private readonly IWeapon weapon;

        public Juggler(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public string Attack()
        {
            return $"A Juggler attacks with {weapon.Type} and deals {weapon.Damage}";
        }
    }
}
