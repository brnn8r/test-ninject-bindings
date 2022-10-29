using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinjectBindings.Weapons
{
    public interface IWeapon
    {
        int Damage { get; }

        string Type { get; }
    }
}
