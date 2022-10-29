using TestNinjectBindings.Weapons;

namespace TestNinjectBindings.Actors
{
    public class TransientRouge : IActor
    {
        private readonly IWeapon weapon;

        public TransientRouge(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public string Attack()
        {
            return $"A Transient Rouge attacks with the {weapon.Type} and deals {weapon.Damage}";
        }
    }
}
