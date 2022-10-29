using TestNinjectBindings.Attributes;
using TestNinjectBindings.Weapons;

namespace TestNinjectBindings.Actors
{
    [SingletonDependencies]
    public class SingletonRouge : IActor
    {
        private readonly IWeapon weapon;

        public SingletonRouge(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public string Attack()
        {
            return $"A Singleton Rouge attacks with the {weapon.Type} and deals {weapon.Damage}";
        }
    }
}
