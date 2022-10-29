namespace TestNinjectBindings.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SingletonDependenciesAttribute : Attribute
    {
        public SingletonDependenciesAttribute()
        {
        }
    }
}
