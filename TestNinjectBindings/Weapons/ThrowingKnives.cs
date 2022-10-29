using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNinjectBindings.Weapons
{
    public class ThrowingKnives : IWeapon
    {
        public int Damage
        {
            get
            {
                Random rnd = new Random();

                var numberOfKnifes = rnd.Next(1, 10);
                int totalDamage = Enumerable.Range(0, numberOfKnifes)
                    .Aggregate(0, (sum, val) => sum + rnd.Next(1, 4));

                return totalDamage;
            }
        }

        public string Type => $"Throwing Knives:ID={GetHashCode()}";
    }
}
