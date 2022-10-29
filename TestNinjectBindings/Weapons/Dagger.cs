namespace TestNinjectBindings.Weapons
{
    public class Dagger : IWeapon
    {
        public int Damage 
        {
            get 
            {
                Random rnd = new Random();
                return rnd.Next(1, 4);
            }
        }

        public string Type => $"Dagger:ID={GetHashCode()}";
    }
}
