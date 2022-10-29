using Ninject;
using System.Diagnostics;

namespace TestNinjectBindings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kernel = new CompositionRoot().Compose();

            var weapon = kernel.Get<IWeapon>();

            Debug.WriteLine($"Weapon attack: {weapon.Attack()}");
        }
    }
}