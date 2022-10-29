namespace TestNinjectBindings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var kernel = new CompositionRoot().Compose();

            Console.WriteLine("Hello, World!");
        }
    }    
}



