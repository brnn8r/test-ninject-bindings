using Ninject;
using Ninject.Extensions.Conventions;
using System.Linq;
using TestNinjectBindings.Actors;
using TestNinjectBindings.Attributes;
using TestNinjectBindings.Weapons;

namespace TestNinjectBindings
{
    public class CompositionRoot
    {
        private IKernel kernel;

        public CompositionRoot()
        {
            kernel = new StandardKernel();                            
        }

        public IKernel Compose()
        {
            //Default weapon is dagger
            kernel.Bind<IWeapon>().To<Dagger>();

            kernel.Bind<IWeapon>().To<ThrowingKnives>().WhenInjectedInto<Juggler>();
            
            kernel.Bind<IWeapon>().To<Dagger>().When(r => r.Target.Member.ReflectedType.GetCustomAttributes(false).Any(a => a is SingletonDependenciesAttribute)).InSingletonScope();            


            kernel.Bind(x => x.FromThisAssembly().Select(t => t.IsAssignableTo(typeof(IActor))).BindAllInterfaces());

            return kernel;            
        }
    }
}