using Ninject;
using System.Diagnostics;
using TestNinjectBindings.Actors;
using TestNinjectBindings.Weapons;

namespace TestNinjectBindings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kernel = new CompositionRoot().Compose();

            var actors = kernel.GetAll<IActor>();

            foreach(var actor in actors)
            {
                Debug.WriteLine(actor.Attack());
            }
        }
    }
}