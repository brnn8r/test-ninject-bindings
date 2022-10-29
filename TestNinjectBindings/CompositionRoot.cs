using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ninject;

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
            return kernel;            
        }
    }
}