using TestNinjectBindings.Attributes;
using TestNinjectBindings.Weapons;

namespace TestNinjectBindings.Actors
{
    [SingletonDependencies]
    public class Cutpurse : IActor
    {
        private readonly IWeapon weapon;

        public Cutpurse(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public string Attack()
        {
            return $"A Cutpurse attacks with the {weapon.Type} and deals {weapon.Damage}";
        }
    }
}
